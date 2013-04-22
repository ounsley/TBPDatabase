using System;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using NHibernate;
using TBPDatabase.Domain;
using NHibernate.Transform;
using System.Collections.Generic;
using TBPDatabase.Utilities;
using System.ComponentModel;

namespace TBPDatabase.DailyInput
{
    public partial class MissingIndividualsWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;
        public bool CurrentlyValid { get { return valid; } }
        public string Heading { get { return heading; } }

        protected string sightingTypeId = "NS";
        protected string heading = "Update the status of individuals that have" +
            " not recently been seen, and add individuals not seen today.";
        protected bool listIndividualsFromTroop = true;

        bool valid = false;

        int maxUncertainSightings = 4;

        ISession session;
        ITransaction tx;

        // Cache these values, so we don't have to keep retrieving them
        Sighting notSeen;
        Sighting seen;

        // Specific to this class or child class
        Sighting sightingType;
        Sighting certainAlternative;

        // Binding list to display to the user
        BindingList<IndividualSighting> currentNotSeen = new BindingList<IndividualSighting>();

        // Cache for initial values
        List<IndividualSighting> initialNotSeen = new List<IndividualSighting>();

        // List for combo box maybe we only need name and ids for the combo box
        List<Individual> individuals;

        // The previous troop visit for this troop
        TroopVisit mostRecentTroopVisit = null;
        List<TroopVisit> lastTroopVisits = new List<TroopVisit>();

        public MissingIndividualsWizardPage()
        {
            InitializeComponent();

            this.dataGridViewNotSeen.SelectionChanged += new EventHandler(dataGridViewNotSeen_SelectionChanged);
            this.radioButtonNotSeen.Click += new EventHandler(radioButtonNotSeen_Click);
            this.radioButtonSeen.Click += new EventHandler(radioButtonNotSeen_Click);
        }


        public void LoadData()
        {
            this.currentNotSeen.Clear();

            // Should never happen but...
            if (DailyData.Current.TroopVisit == null)
            {
                MessageBox.Show("There is no current troop visit, cannot load data.");
                return;
            }

            session = NHibernateHelper.OpenNewSession();
            tx = session.BeginTransaction();

            // Cache these values for later
            notSeen = session.Get<Sighting>("NS");
            seen = session.Get<Sighting>("S");

            // Set the sighting type
            if (notSeen.ID == sightingTypeId)
            {
                sightingType = notSeen;
                certainAlternative = session.Get<Sighting>("A");
            }
            else
            {
                certainAlternative = session.Get<Sighting>("IM");
                sightingType = seen;
            }

            // Get the last 5 (maxUncertainSightings) troop visits before this date
            lastTroopVisits = new List<TroopVisit>(session
                    .CreateQuery("select tv from TroopVisit as tv " +
                    "left join fetch tv.Troop as t " +
                //"left join fetch tv.Observers " +
                    "where t.TroopID = :troopID and " +
                    "tv.Date < :date " +
                    "order by tv.Date desc")
                    .SetParameter<string>("troopID", DailyData.Current.TroopVisit.Troop.TroopID)
                    .SetParameter<DateTime>("date", DailyData.Current.TroopVisit.Date.Date)
                    .SetMaxResults(maxUncertainSightings)
                    .List<TroopVisit>());

            if (lastTroopVisits.Count > 0)
                mostRecentTroopVisit = lastTroopVisits[0];

            // Lets get any individual sightings for the previous troop visit
            // that are uncertain
            IList<IndividualSighting> previousUncertainSightings = null;
            if (mostRecentTroopVisit != null)
            {
                previousUncertainSightings = session
                .CreateQuery("select s from IndividualSighting as s " +
                "left join fetch s.TroopVisit as tv " +
                "left join fetch tv.Observers " +
                "where tv = :troopVisit " +
                "and s.Sighting.Uncertain = True ")
                .SetParameter<TroopVisit>("troopVisit", mostRecentTroopVisit)
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .List<IndividualSighting>();
            }

            // Add the not seen entries to the list, note which individuals
            // are uncertain
            List<Individual> uncertainIndividuals = new List<Individual>();
            if (previousUncertainSightings != null)
            {
                foreach (IndividualSighting sighting in previousUncertainSightings)
                {
                    if (sighting != null
                        && sighting.TroopVisit.Troop.TroopID == DailyData.Current.TroopVisit.Troop.TroopID
                        && sighting.Sighting.Uncertain)
                    {
                        if (sighting.Sighting.ID == sightingType.ID)
                        {
                            currentNotSeen.Add(sighting);
                            uncertainIndividuals.Add(sighting.Individual);
                        }
                    }
                }
            }

            // Get any sightings for todays troop visit that may already exist
            // for the individuals that were uncertain or any new uncertain
            // sightings
            // Cache for values already in database for today
            List<IndividualSighting> todaysSightings = new List<IndividualSighting>();
            if (DailyData.Current.RetrievedData)
            {
                todaysSightings = (List<IndividualSighting>)session
                    .CreateQuery("select s from IndividualSighting as s " +
                    "left join fetch s.TroopVisit as tv " +
                    "where tv = :troopVisit " +
                    "and s.Sighting = :sighting ")
                    .SetParameter<TroopVisit>("troopVisit", DailyData.Current.TroopVisit)
                    .SetParameter<Sighting>("sighting", sightingType)
                    .SetResultTransformer(new DistinctRootEntityResultTransformer())
                    .List<IndividualSighting>();
            }

            // Absentees can only be existing members from this troop
            // This should be modified
            individuals = Individual.LoadAll(session);

            tx.Commit();

            // Make a copy of initial list to revert back to.
            initialNotSeen = new List<IndividualSighting>(currentNotSeen);
            this.individualSightingBindingSource.DataSource = currentNotSeen;

            // Replace sightings with todays sightings if for the same individual
            // add new uncertain sightings for this day to the end and check as done
            foreach (IndividualSighting sighting in todaysSightings)
            {
                bool replacement = false;
                for (int i = 0; i < currentNotSeen.Count; i++)
                {
                    if (currentNotSeen[i].Individual.ID == sighting.Individual.ID)
                    {
                        currentNotSeen[i] = sighting;
                        SetCheckBox(i, true);
                        replacement = true;
                        break;
                    }
                }
                // The individual is not already listed
                // so add to the end
                if (!replacement)
                {
                    // Check that this is not an entirely new individual
                    if (sighting.Individual.FirstSighting() != sighting)
                    {
                        currentNotSeen.Add(sighting);
                        SetCheckBox(currentNotSeen.IndexOf(sighting), true);
                    }
                }
            }

            // Filter individuals from this troop only
            individuals = individuals.FindAll(new Predicate<Individual>(x =>
                    x.CurrentTroop(DailyData.Current.TroopVisit.Date) != null &&
                        // A bit funny, but we want to find values who are included or excluded based on
                        // 'included'
                        // if 'included' is true then we require the troop ids to match otherwise we
                        // require them to differ
                    (listIndividualsFromTroop == (x.CurrentTroop(DailyData.Current.TroopVisit.Date).TroopID == DailyData.Current.TroopVisit.Troop.TroopID))));

            try
            {
                // Sort individuals by the most recent certain current sighting
                individuals.Sort((x, y) =>
                        x.CurrentSighting(DailyData.Current.TroopVisit.Date, true) != null ?
                        x.CurrentSighting(DailyData.Current.TroopVisit.Date, true).CompareTo(y.CurrentSighting(DailyData.Current.TroopVisit.Date, true))
                        : 1);
            }
            catch (Exception e)
            { }// Not such a big deal if we can't sort

            this.comboBoxIndividuals.DataSource = individuals;

            CheckComplete();
            this.FinishedLoading(this, null);
        }

        void radioButtonNotSeen_Click(object sender, EventArgs e)
        {
            this.buttonUpdate.Enabled = true;
        }

        void dataGridViewNotSeen_SelectionChanged(object sender, EventArgs e)
        {
            // Reset the editing controls
            this.radioButtonSeen.Enabled = true;
            this.radioButtonNotSeen.Enabled = true;
            this.radioButtonNotSeen.Checked = false;
            this.radioButtonSeen.Checked = false;
            this.textBoxComments.Clear();
            this.buttonUpdate.Enabled = false;
            this.buttonRevert.Enabled = false;
            this.dataGridViewNotSeen.Focus();

            if (dataGridViewNotSeen.SelectedRows.Count > 0)
            {
                int currentIndex = this.dataGridViewNotSeen.SelectedRows[0].Index;

                // Set the label to the selected individual
                this.labelIndividual.Text = currentNotSeen[currentIndex].Individual.Name;

                // Then fill in the data if it has already been entered
                if (RowChecked(currentIndex))
                {
                    buttonUpdate.Enabled = true;
                    this.textBoxComments.Text = currentNotSeen[currentIndex].Comments;
                    if (currentNotSeen[currentIndex].Sighting == seen)
                        radioButtonSeen.Checked = true;
                    else
                        radioButtonNotSeen.Checked = true;

                    // Enable the revert button for already entered items
                    this.buttonRevert.Enabled = true;
                    this.buttonUpdate.Enabled = false;
                    this.radioButtonNotSeen.Enabled = false;
                    this.radioButtonSeen.Enabled = false;
                }
            }
        }

        private bool RowChecked(int index)
        {
            return ((DataGridViewCheckBoxCell)dataGridViewNotSeen.Rows[index].Cells["sightedCheckBoxColumn"])
                .Value == sightedCheckBoxColumn.TrueValue;
        }

        private void SetCheckBox(int index, bool value)
        {
            ((DataGridViewCheckBoxCell)dataGridViewNotSeen.Rows[index].Cells["sightedCheckBoxColumn"])
                .Value = (value ? sightedCheckBoxColumn.TrueValue : sightedCheckBoxColumn.FalseValue);
        }

        public bool Finish()
        {
            // New version, we just need to add the values in currentNotSeen
            // and currentSeen to the database, as they should all have been 
            // replaced
            foreach (IndividualSighting newIS in currentNotSeen)
            {
                // Check if this individual has reached the threshold

                // First find all sightings that match with our last troop visits list
                List<IndividualSighting> matches = new List<IndividualSighting>(newIS.Individual.SightingHistory)
                    .FindAll(new Predicate<IndividualSighting>(x =>
                        lastTroopVisits.Contains(x.TroopVisit)));

                if (matches.Count >= maxUncertainSightings)
                {
                    int threshold = maxUncertainSightings + 1;

                    IndividualSighting certainSighting = new IndividualSighting();
                    certainSighting.Individual = newIS.Individual;
                    certainSighting.TroopVisit = lastTroopVisits[lastTroopVisits.Count - 1];
                    certainSighting.Sighting = certainAlternative;
                    certainSighting.Comments = "AUTOMATICALLY GENERATED ENTRY :- Troop membership updated after " + threshold +
                        " " + sightingType.ID + " sightings";

                    MessageBox.Show(newIS.Individual.Name + " " + sightingType.Description.ToLower() +
                        " for the last " + threshold + " troop visits. These entries will be removed " +
                        " and the individual will be marked as '" + certainSighting.Sighting.Description +
                        "' on troop visit " + certainSighting.TroopVisit.ToString());

                    // Add the new entry
                    DailyData.Current.NewSightings.Add(certainSighting);
                    // Delete the old entries
                    DailyData.Current.SightingsToDelete.AddRange(matches);
                }
                else
                {
                    if (newIS.ID == 0)
                        DailyData.Current.NewSightings.Add(newIS);
                }
            }

            return true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // The index of the selected row
            int index = dataGridViewNotSeen.SelectedRows[0].Index;

            // What has the user selected for this individual
            Sighting selection = seen;
            if (radioButtonNotSeen.Checked)
                selection = notSeen;

            // Is this selction type that we are dealing with?
            // If so we need to make a new entry and replace the existing one
            if (selection.ID == sightingType.ID)
            {
                IndividualSighting currentIS = (IndividualSighting)dataGridViewNotSeen.SelectedRows[0].DataBoundItem;
                IndividualSighting newIS = new IndividualSighting();
                newIS.TroopVisit = DailyData.Current.TroopVisit;
                newIS.Individual = currentIS.Individual;
                newIS.Sighting = selection;
                newIS.Comments = textBoxComments.Text;

                // Replace the entry
                currentNotSeen[index] = newIS;
            }

            // Set that we have updated this
            SetCheckBox(index, true);

            // Move to next entry
            if (dataGridViewNotSeen.Rows.Count > index + 1)
                dataGridViewNotSeen.Rows[index + 1].Selected = true;

            // Is this page complete?
            CheckComplete();
        }

        private void CheckComplete()
        {
            // Check that all pending uncertain sightings have been 
            // addressed
            bool complete = true;

            foreach (DataGridViewRow r in dataGridViewNotSeen.Rows)
            {
                DataGridViewCheckBoxCell c = (DataGridViewCheckBoxCell)r.Cells["sightedCheckBoxColumn"];
                complete &= c.Value == c.TrueValue;
            }

            if (complete != valid)
            {
                this.valid = complete;
                this.ValidityChanged(this, null);
            }
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            //IndividualSighting currentIS = (IndividualSighting)dataGridViewNotSeen.SelectedRows[0].DataBoundItem;
            int currentIndex = dataGridViewNotSeen.SelectedRows[0].Index;
            if (RowChecked(currentIndex))
            {
                // Add the current value to the delete list
                IndividualSighting toBeRemoved = currentNotSeen[currentIndex];
                // If already persistent then add to remove list
                if (toBeRemoved.ID > 0)
                    DailyData.Current.SightingsToDelete.Add(toBeRemoved);

                // We want to go back to initial value, or remove
                // if there was none
                if (currentIndex > initialNotSeen.Count - 1)
                {
                    // Removing value
                    currentNotSeen.RemoveAt(currentIndex);
                }
                else
                {
                    // Replacing value with previous
                    currentNotSeen[currentIndex] = initialNotSeen[currentIndex];
                    // Uncheck the box
                    ((DataGridViewCheckBoxCell)this.dataGridViewNotSeen["sightedCheckBoxColumn", currentIndex])
                        .Value = sightedCheckBoxColumn.FalseValue;
                }
            }

            // Is the page valid?
            this.dataGridViewNotSeen_SelectionChanged(this, null);
            this.CheckComplete();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IndividualSighting s = new IndividualSighting();
            s.TroopVisit = DailyData.Current.TroopVisit;
            s.Individual = (Individual)comboBoxIndividuals.SelectedValue;
            s.Comments = textBoxNewComments.Text;
            s.Sighting = sightingType;

            foreach (IndividualSighting x in currentNotSeen)
            {
                if (x.Individual.ID == s.Individual.ID)
                {
                    MessageBox.Show("This " + s.Individual.Name + " already has an entry in the list. " +
                "Update the individuals detail with the 'Update' control.");
                    return;
                }
            }

            this.currentNotSeen.Add(s);
            int index = currentNotSeen.Count - 1;
            // Check the box
            ((DataGridViewCheckBoxCell)this.dataGridViewNotSeen["sightedCheckBoxColumn", index])
                .Value = sightedCheckBoxColumn.TrueValue;

            this.dataGridViewNotSeen_SelectionChanged(this, null);
        }

        // Need to update checkboxes for some reason after
        // load - maybe to do with tab page visibility
        public void Selected()
        {
            // If this is retrieved data, then we can check all
            // the boxes
            if (DailyData.Current.RetrievedData)
            {
                for (int i = 0; i < currentNotSeen.Count; i++)
                    SetCheckBox(i, true);
            }
            else
            {
                for (int i = 0; i < currentNotSeen.Count; i++)
                {
                    // Values already complete should be checked
                    if (currentNotSeen[i].TroopVisit.ID == DailyData.Current.TroopVisit.ID)
                        SetCheckBox(i, true);
                }
            }

            if (dataGridViewNotSeen.Rows.Count > 0)
                this.dataGridViewNotSeen.Rows[0].Selected = true;
            this.dataGridViewNotSeen_SelectionChanged(this, null);
            this.CheckComplete();
        }

    }
}
