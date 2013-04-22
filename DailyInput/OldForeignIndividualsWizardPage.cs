using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBPDatabase.Utilities;
using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using NHibernate;
using NHibernate.Transform;

namespace TBPDatabase.DailyInput
{
    public partial class OldForeignIndividualsWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;

        ISession session;
        ITransaction tx;

        SortableBindingList<IndividualSighting> currentNotSeen = new SortableBindingList<IndividualSighting>();
        SortableBindingList<IndividualSighting> initialNotSeen = new SortableBindingList<IndividualSighting>();
        IList<IndividualSighting> previousSightings;
        List<Individual> individuals;
        TroopVisit mostRecentTroopVisit;

        Sighting notSeen;
        Sighting seen;
        private BackgroundWorker worker;
        private bool valid = false;

        public bool CurrentlyValid
        {
            get { return true; }
        }

        public string Heading
        {
            get { return "Update the status of foreign individuals who have recently been seen with the troop, and list any individuals seen with the troop today."; }
        }

        public OldForeignIndividualsWizardPage()
        {
            InitializeComponent();
            if (this.ValidityChanged != null)
                this.ValidityChanged(this, null);

            this.dataGridViewNotSeen.SelectionChanged += new EventHandler(dataGridViewNotSeen_SelectionChanged);
            this.radioButtonNotSeen.Click += new EventHandler(radioButtonNotSeen_Click);
            this.radioButtonSeen.Click += new EventHandler(radioButtonNotSeen_Click);

            this.worker = new BackgroundWorker();

            this.worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
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

            // Load data asyncronously
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            session = NHibernateHelper.OpenNewSession();
            tx = session.BeginTransaction();

            // Get all troop visits before this date
            mostRecentTroopVisit = session
                    .CreateQuery("select tv from TroopVisit as tv " +
                    "left join fetch tv.Troop as t " +
                    "where t.TroopID = :troopID and " +
                    "tv.Date < :date " +
                    "order by tv.Date desc")
                    .SetParameter<string>("troopID", DailyData.Current.TroopVisit.Troop.TroopID)
                    .SetParameter<DateTime>("date", DailyData.Current.TroopVisit.Date.Date)
                    .SetMaxResults(1)
                    .UniqueResult<TroopVisit>();

            // Lets get any individual sightings for this troop visit
            // that are uncertain
            if (mostRecentTroopVisit != null)
            {
                previousSightings = session
                .CreateQuery("select s from IndividualSighting as s " +
                "left join fetch s.TroopVisit as tv " +
                "left join fetch s.Individual as i " +
                "left join fetch i.ReproductiveStateHistory " +
                "left join fetch i.AgeClassHistory " +
                "left join fetch i.SightingHistory " +
                "left join fetch s.Sighting " +
                "left join fetch i.Mother as m " +
                "left join fetch m.ReproductiveStateHistory " +
                "left join fetch m.AgeClassHistory " +
                "left join fetch m.SightingHistory " +
                "where tv = :troopVisit ")
                .SetParameter<TroopVisit>("troopVisit", mostRecentTroopVisit)
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .List<IndividualSighting>();
            }

            // Absentees can only be existing members from this troop
            individuals = Individual.LoadAll(session);

            // Cache these values for later
            notSeen = session.Get<Sighting>("NS");
            seen = session.Get<Sighting>("S");

            tx.Commit();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Add any uncertain sightings form the most recent troop visit 
            // that are uncertain and add them to the interface.
            foreach (IndividualSighting sighting in previousSightings)
            {
                if (sighting != null
                    && sighting.TroopVisit.Troop.TroopID == DailyData.Current.TroopVisit.Troop.TroopID
                    && sighting.Sighting.Uncertain)
                {
                    if (sighting.Sighting.ID == "S")
                        currentNotSeen.Add(sighting);
                }
            }

            this.comboBoxIndividuals.DataSource = individuals
                .FindAll(new Predicate<Individual>(x =>
                    x.CurrentTroop() != null &&
                    x.CurrentTroop().TroopID == DailyData.Current.TroopVisit.Troop.TroopID));

            // Make a copy of initial list to revert back to.
            initialNotSeen = new SortableBindingList<IndividualSighting>(currentNotSeen);
            this.individualSightingBindingSource.DataSource = currentNotSeen;
            if (initialNotSeen.Count == 0)
            {
                this.valid = true;
                this.ValidityChanged(this, null);
            }

            this.FinishedLoading(this, null);
        }

        public bool Finish()
        {
            // New version, we just need to add the values in currentNotSeen
            // and currentSeen to the database, as they should all have been 
            // replaced
            foreach (IndividualSighting newIS in currentNotSeen)
                DailyData.Current.NewSightings.Add(newIS);

            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IndividualSighting s = new IndividualSighting();
            s.TroopVisit = DailyData.Current.TroopVisit;
            s.Individual = (Individual)comboBoxIndividuals.SelectedValue;
            s.Comments = textBoxNewComments.Text;
            s.Sighting = seen;

            this.currentNotSeen.Add(s);
            int index = currentNotSeen.Count - 1;
            // Check the box
            ((DataGridViewCheckBoxCell)this.dataGridViewNotSeen["sightedCheckBoxColumn", index])
                .Value = sightedCheckBoxColumn.TrueValue;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            IndividualSighting currentIS = (IndividualSighting)dataGridViewNotSeen.SelectedRows[0].DataBoundItem;
            IndividualSighting newIS = new IndividualSighting();
            newIS.TroopVisit = DailyData.Current.TroopVisit;
            newIS.Individual = currentIS.Individual;
            newIS.Sighting = (radioButtonSeen.Checked ? seen : notSeen);
            newIS.Comments = textBoxComments.Text;

            int index = dataGridViewNotSeen.SelectedRows[0].Index;

            // Replace the entry
            currentNotSeen[index] = newIS;

            // Set that we have updated this
            ((DataGridViewCheckBoxCell)dataGridViewNotSeen.Rows[index].Cells["sightedCheckBoxColumn"]).Value = sightedCheckBoxColumn.TrueValue;

            if (dataGridViewNotSeen.Rows.Count > index + 1)
                dataGridViewNotSeen.Rows[index + 1].Selected = true;

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
                // We want to go back to initial value, or remove
                // if there was none
                if (currentIndex > initialNotSeen.Count - 1)
                {
                    currentNotSeen.RemoveAt(currentIndex);
                }
                else
                {
                    // Get the old value;
                    currentNotSeen[currentIndex] = initialNotSeen[currentIndex];
                    // Uncheck the box
                    ((DataGridViewCheckBoxCell)this.dataGridViewNotSeen["sightedCheckBoxColumn", currentIndex])
                        .Value = sightedCheckBoxColumn.FalseValue;
                }
            }

            this.CheckComplete();
        }

        private bool RowChecked(int index)
        {
            return ((DataGridViewCheckBoxCell)dataGridViewNotSeen.Rows[index].Cells["sightedCheckBoxColumn"])
                .Value == sightedCheckBoxColumn.TrueValue;
        }

        void radioButtonNotSeen_Click(object sender, EventArgs e)
        {
            this.buttonUpdate.Enabled = true;
        }

        void dataGridViewNotSeen_SelectionChanged(object sender, EventArgs e)
        {
            // Reset the editing controls
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
                }
            }
        }

        public void Selected()
        {
        }
    }
}
