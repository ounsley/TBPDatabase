using System;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using NHibernate;
using TBPDatabase.Domain;
using NHibernate.Transform;
using System.Collections.Generic;
using TBPDatabase.Utilities;
using System.ComponentModel;
using System.Drawing;

namespace TBPDatabase.DailyInput
{
    public partial class MissingIndividualsWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;
        public bool CurrentlyValid { get { return valid; } }
        public string Heading { get { return heading; } }

        protected string heading = "Record any troop members that were not seen today, " + 
            "or foreign individuals that were sighted with the troop.";
        protected bool listIndividualsFromTroop = true;

        bool valid = false;

        int maxUncertainSightings = 4;

        ISession session;
        ITransaction tx;

        // Cache these values, so we don't have to keep retrieving them
        Sighting notSeen;
        Sighting seen;
        Sighting absent;
        Sighting immigrated;

        // Binding list to display to the user
        BindingList<IndividualSighting> currentNotSeen = new BindingList<IndividualSighting>();

        // List for combo box maybe we only need name and ids for the combo box
        List<Individual> individuals = new List<Individual>();

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
            absent = session.Get<Sighting>("A");
            immigrated = session.Get<Sighting>("IM");

            // Get the last 5 (maxUncertainSightings) troop visits before this date
            lastTroopVisits = new List<TroopVisit>(session
                    .CreateQuery("select tv from TroopVisit as tv " +
                    "left join fetch tv.Troop as t " +
                    "where t.TroopID = :troopID and " +
                    "tv.Date < :date " +
                    "order by tv.Date desc")
                    .SetParameter<string>("troopID", DailyData.Current.TroopVisit.Troop.TroopID)
                    .SetParameter<DateTime>("date", DailyData.Current.TroopVisit.Date.Date)
                    .SetMaxResults(maxUncertainSightings)
                    .List<TroopVisit>());

            // Note the mostRecentTroopVisit prior to this one
            if (lastTroopVisits.Count > 0)
                mostRecentTroopVisit = lastTroopVisits[0];

            // Get all the individuals
            individuals = Individual.LoadAll(session);

            // We want all individual sightings for this troop visit and the last
            // if possible
            List<IndividualSighting> currentIndividualSightings = null;
            if (mostRecentTroopVisit != null && DailyData.Current.RetrievedData)
            {
                currentIndividualSightings = new List<IndividualSighting>(
                session.CreateQuery("select s from IndividualSighting as s " +
                    "where s.TroopVisit = :troopVisit or " + 
                    "s.TroopVisit = :troopVisit2")
                    .SetParameter<TroopVisit>("troopVisit", mostRecentTroopVisit)
                    .SetParameter<TroopVisit>("troopVisit2", DailyData.Current.TroopVisit)
                    //.SetMaxResults(maxUncertainSightings)
                    .List<IndividualSighting>());
            }
            else if (mostRecentTroopVisit != null)
            {
                TroopVisit tv = DailyData.Current.RetrievedData ? DailyData.Current.TroopVisit : mostRecentTroopVisit;
                currentIndividualSightings = new List<IndividualSighting>(
                    session.CreateQuery("select s from IndividualSighting as s " +
                        "where s.TroopVisit = :troopVisit ")
                        .SetParameter<TroopVisit>("troopVisit",tv)
                        //.SetMaxResults(maxUncertainSightings)
                        .List<IndividualSighting>());
            }

            tx.Commit();

            // A list for sorting
            List<IndividualSighting> sightings = new List<IndividualSighting>();

            // List an entry for each individual
            foreach (Individual i in individuals)
            {
                // Find any sightings for this troop visit or the last troop visit
                // for this individual
                List<IndividualSighting> individualSightingCandidates = new List<IndividualSighting>();
                if(currentIndividualSightings != null)
                    individualSightingCandidates = currentIndividualSightings.FindAll(x => x.Individual.ID == i.ID);

                if (individualSightingCandidates.Count > 0) // Does this individual have an uncertain entry to list?
                {
                    // we want the most recent one to be displayed
                    IndividualSighting mostRecent = null;
                    foreach (IndividualSighting s in individualSightingCandidates)
                    {
                        if (mostRecent == null || s.TroopVisit.Date > mostRecent.TroopVisit.Date)
                            mostRecent = s;
                    }
                    sightings.Add(mostRecent);
                }
                else // if not add the current certain sighting that is an inclusion
                {
                    IndividualSighting s = i.CurrentSighting(DailyData.Current.TroopVisit,
                       true);
                    if (s != null && s.State.Inclusion)
                        sightings.Add(s);
                }
            }

            // Sort reverse date order
            sightings.Sort((x, y) => -1 * x.TroopVisit.Date.CompareTo(y.TroopVisit.Date));

            // Add to the datagridview
            currentNotSeen = new BindingList<IndividualSighting>(sightings);
            this.individualSightingBindingSource.DataSource = currentNotSeen;

            // Filter individuals not from this troop only, either current troop == null
            // or current troop is differnet
            individuals = individuals.FindAll(new Predicate<Individual>(x =>
                x.CurrentTroop(DailyData.Current.TroopVisit.Date) == null || (
                    x.CurrentTroop(DailyData.Current.TroopVisit.Date) != null &&
                    (x.CurrentTroop(DailyData.Current.TroopVisit.Date).TroopID != DailyData.Current.TroopVisit.Troop.TroopID))));

            // Add to combo box
            this.comboBoxIndividuals.DataSource = individuals;

            CheckComplete();
            this.FinishedLoading(this, null);
        }

        /// <summary>
        /// Enable the update button once a selection is made
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.dataGridViewNotSeen.Focus();
            this.buttonUpdate.Enabled = false;

            if (dataGridViewNotSeen.SelectedRows.Count > 0)
            {
                int currentIndex = this.dataGridViewNotSeen.SelectedRows[0].Index;

                // Set the label to the selected individual
                this.labelIndividual.Text = currentNotSeen[currentIndex].Individual.Name;
            }
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
                // Check if this individual has reached the threshold for a change in certain
                // troop membership

                // First find all uncertain sightings that match with our last troop visits list
                List<IndividualSighting> matches = new List<IndividualSighting>(newIS.Individual.SightingHistory)
                    .FindAll(x =>
                        x.State.Certain == false &&
                        lastTroopVisits.Contains(x.TroopVisit));

                if (matches.Count >= maxUncertainSightings)
                {
                    int threshold = maxUncertainSightings + 1;
                    Sighting uncertainValue = null;
                    Sighting certainValue = null;
                    if (matches[0].Sighting.ID == seen.ID)
                    {
                        uncertainValue = seen;
                        certainValue = immigrated;
                    }
                    else
                    {
                        uncertainValue = notSeen;
                        certainValue = absent;
                    }

                    IndividualSighting certainSighting = new IndividualSighting();
                    certainSighting.Individual = newIS.Individual;
                    certainSighting.TroopVisit = lastTroopVisits[lastTroopVisits.Count - 1];
                    certainSighting.Sighting = certainValue;
                    certainSighting.Comments = "AUTOMATICALLY GENERATED ENTRY :- Troop membership updated after " + threshold +
                        " " + uncertainValue.ID + " sightings";

                    // Ask if we want to change the troop membership for this individual
                    if (MessageBox.Show(newIS.Individual.Name + " " + uncertainValue.Description.ToLower() +
                        " for the last " + threshold + " troop visits. These entries will be removed " +
                        " and the individual will be marked as '" + certainSighting.Sighting.Description +
                        "' on troop visit " + certainSighting.TroopVisit.ToString() + ". Do you want to make this change?",
                        "Troop membership changed for " + newIS.Individual.Name,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        // Add the new entry
                        DailyData.Current.NewSightings.Add(certainSighting);
                        // Delete the old entries
                        DailyData.Current.SightingsToDelete.AddRange(matches);

                        // We also want to remove reproductive states for females so..
                        List<IndividualReproductiveState> reproductiveStates =
                            new List<IndividualReproductiveState>(newIS.Individual.ReproductiveStateHistory)
                        .FindAll(x => lastTroopVisits.Contains(x.TroopVisit));

                        DailyData.Current.ReproductiveStatesToDelete.AddRange(reproductiveStates);
                        DailyData.Current.MigratedToday.Add(newIS.Individual);
                    }
                    else
                    {
                        if (newIS.State.ID == "NS")
                            DailyData.Current.MissingToday.Add(newIS.Individual);
                        if (newIS.ID == 0)
                            DailyData.Current.NewSightings.Add(newIS);
                    }
                }
                else // Not a migration so
                {
                    // Add those whose id is new
                    if (newIS.ID == 0)
                        DailyData.Current.NewSightings.Add(newIS);

                    if (newIS.State.ID == "NS")
                        DailyData.Current.MissingToday.Add(newIS.Individual);
                }
            }

            return true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // The index of the selected row
            int index = dataGridViewNotSeen.SelectedRows[0].Index;
            IndividualSighting sighting = currentNotSeen[index];

            // What has the user selected for this individual
            Sighting selection = seen;
            if (radioButtonNotSeen.Checked)
                selection = notSeen;

            // What is the current state of the individual?
            // If we are updating a seen individual it is foreign
            if (sighting.Sighting.ID == seen.ID)
            {
                // If they have been seen again we need to add another entry for the individual
                if (selection.ID == seen.ID)
                {
                    IndividualSighting newIS = new IndividualSighting();
                    newIS.TroopVisit = DailyData.Current.TroopVisit;
                    newIS.Individual = sighting.Individual;
                    newIS.Sighting = selection;
                    newIS.Comments = textBoxComments.Text;

                    // Replace the entry
                    currentNotSeen[index] = newIS;

                    // Set that we have updated this
                    SetCheckBox(index, true);

                    // Move to next entry
                    if (dataGridViewNotSeen.Rows.Count > index + 1)
                        dataGridViewNotSeen.Rows[index + 1].Selected = true;
                }
                else // Remove them from the list, we do not need
                // to make any new entries
                {
                    currentNotSeen.RemoveAt(index);

                    // Move to next entry
                    if (dataGridViewNotSeen.Rows.Count > index)
                        dataGridViewNotSeen.Rows[index].Selected = true;
                }
            }
            else // the individual is not foreign
            {
                // Are we marking them as not seen?
                // If so we need to add a new entry
                if (selection.ID == notSeen.ID)
                {
                    IndividualSighting newIS = new IndividualSighting();
                    newIS.TroopVisit = DailyData.Current.TroopVisit;
                    newIS.Individual = sighting.Individual;
                    newIS.Sighting = selection;
                    newIS.Comments = textBoxComments.Text;

                    // Replace the entry
                    currentNotSeen[index] = newIS;

                    // Set that we have updated this
                    SetCheckBox(index, true);

                    // Move to next entry
                    if (dataGridViewNotSeen.Rows.Count > index + 1)
                        dataGridViewNotSeen.Rows[index + 1].Selected = true;
                }
                else // We need to show the last certain sighting
                    // and check as done
                {
                    currentNotSeen[index] = sighting.Individual.CurrentSighting(DailyData.Current.TroopVisit, true);

                    // Set that we have updated this
                    SetCheckBox(index, true);

                    // Move to next entry
                    if (dataGridViewNotSeen.Rows.Count > index + 1)
                        dataGridViewNotSeen.Rows[index + 1].Selected = true;
                }
            }

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

                if (currentNotSeen[r.Index].State.Certain == false)
                    r.DefaultCellStyle.BackColor = Color.Yellow;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }

            if (complete != valid)
            {
                this.valid = complete;
                this.ValidityChanged(this, null);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IndividualSighting s = new IndividualSighting();
            s.TroopVisit = DailyData.Current.TroopVisit;
            s.Individual = (Individual)comboBoxIndividuals.SelectedValue;
            s.Comments = textBoxNewComments.Text;
            s.Sighting = seen;

            foreach (IndividualSighting x in currentNotSeen)
            {
                if (x.Individual.ID == s.Individual.ID)
                {
                    MessageBox.Show("This " + s.Individual.Name + " already has an entry in the list. " +
                "Update the individuals detail with the 'Update' control.");
                    return;
                }
            }

            // Add to top of the list
            this.currentNotSeen.Insert(0, s);
            // Check the box
            SetCheckBox(0, true);

            CheckComplete();
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
                    // Values check certain values automatically
                    if (currentNotSeen[i].State.Certain)
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
