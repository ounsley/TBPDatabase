using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHibernate.Transform;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using TBPDatabase.Editors;
using TBPDatabase.Utilities;

namespace TBPDatabase.SessionForms
{
    public partial class IndiviualForm : SessionForm
    {
        // Editors for Individual items
        SightingEditor tce;
        ReproductiveStateEditor rse;
        AgeClassEditor ace;
        Individual individual;

        private Individual Individual
        {
            //get { return (Individual)this.individualBindingSource.Current; }
            get { return individual; }
        }

        /// <summary>
        /// This form handles user interaction and viewing of data from an Individual
        /// centered point of view. Handles basic integrity checks and allows modifications.
        /// </summary>
        public IndiviualForm(Individual individual)
        {
            InitializeComponent();            

            // initialization
            this.individual = Individual.LoadIndividual(Session,individual);
            this.individualBindingSource.DataSource = individual;


            
            
            // Set additional binding sources
            SetData();

            // Lets get rid of reproductive state stuff for the fellas
            if (Individual.Sex == Domain.Individual.SexEnum.M)
                tabControlHistories.TabPages.RemoveAt(0);
        }

        void individualBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // Update binding sources for controls when the Individual is changed
            SetData();
        }

        /// <summary>
        /// Set the bindingi source data, should be called when the individual binding source changes
        /// </summary>
        private void SetData()
        {
            this.RefreshLabels();
            this.notchControl.SetIndividual(individual);
            this.individualSightingBindingSource.DataSource = new SortableBindingList<IndividualSighting>(Individual.SightingHistory);
            this.individualReproductiveStateBindingSource.DataSource = new SortableBindingList<IndividualReproductiveState>(Individual.ReproductiveStateHistory);
            this.individualAgeClassBindingSource.DataSource = new SortableBindingList<IndividualAgeClass>(Individual.AgeClassHistory);
            IList<IndividualEvent> ie = Session
                .CreateQuery("select i from IndividualEvent as i " +
                "where i.Individual = :individual").SetParameter<Individual>("individual", this.Individual)
                .List<IndividualEvent>();
            this.individualEventBindingSource.DataSource = new SortableBindingList<IndividualEvent>(ie);
            IList<IndividualInteraction> ii = Session
                .CreateQuery("select i from IndividualInteraction as i " +
                "where i.Individual1 = :individual").SetParameter<Individual>("individual", this.Individual)
                .List<IndividualInteraction>();
            this.individualInteractionBindingSource.DataSource = new SortableBindingList<IndividualInteraction>(ii);
        }

        /// <summary>
        /// Calculate derived values and set labels accordingly
        /// </summary>
        private void RefreshLabels()
        {
            SetCurrentTroopLabel();
            SetAgeClassLabel();
            SetFirstObserved();
        }

        private void SetFirstObserved()
        {
            this.labelFirstObserved.Text = Individual.TroopVisitFirstObserved().ToString();
        }

        private void SetAgeClassLabel()
        {
            this.labelCurrentAgeClass.Text = Individual.CurrentAgeClass() == null ? "None" : Individual.CurrentAgeClass().ToString();
        }

        void SetCurrentTroopLabel()
        {
            Troop currentTroop = Individual.CurrentTroop();
            if (currentTroop == null)
            {
                // Set a blank label
                this.labelCurrentTroop.Text = "No Troop";

                /// INTEGRITY CHECK
                // No current troop so we need to ask for a new entry
                bool askForTroopInfo = false;
                if (askForTroopInfo)
                {
                    DialogResult result = MessageBox.Show("There is no current troop information for "
                        + Individual.Name
                        + ". Click Ok to add an entry, or cancel to leave blank for now.",
                        "No current troop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        // Create individual sighting entry
                        tce = new SightingEditor(Session, this.Individual);
                        DialogResult tceResult = tce.ShowDialog();
                        if (tceResult == System.Windows.Forms.DialogResult.OK)
                        {
                            Individual.SightingHistory.Add(tce.State);
                            SetCurrentTroopLabel();
                        }
                    }
                }
            }
            else
            {
                this.labelCurrentTroop.Text = currentTroop.TroopID;
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            rse = new ReproductiveStateEditor(Session,this.Individual);
            DialogResult result = rse.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Individual.ReproductiveStateHistory.Add(rse.State);
                this.individualReproductiveStateBindingSource.Add(rse.State);
                this.RefreshLabels();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            tce = new SightingEditor(Session,this.Individual);
            DialogResult result = tce.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                this.Individual.SightingHistory.Add(tce.State);
                this.individualSightingBindingSource.Add(tce.State);
                this.RefreshLabels();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ace = new AgeClassEditor(Session, this.Individual);
            DialogResult result = ace.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Individual.AgeClassHistory.Add(ace.State);
                this.individualAgeClassBindingSource.Add(ace.State);
                this.RefreshLabels();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry from the database?",
                "Delete Data?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                // Careful, need to delete from individual before from binding source!
                this.Individual.SightingHistory.Remove((IndividualSighting)individualSightingBindingSource.Current);
                this.individualSightingBindingSource.Remove(individualSightingBindingSource.Current);
                this.RefreshLabels();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry from the database?",
                "Delete Data?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Individual.ReproductiveStateHistory.Remove((IndividualReproductiveState)individualReproductiveStateBindingSource.Current);
                this.individualReproductiveStateBindingSource.Remove(individualReproductiveStateBindingSource.Current);
                this.RefreshLabels();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry from the database?",
                "Delete Data?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Individual.AgeClassHistory.Remove((IndividualAgeClass)individualAgeClassBindingSource.Current);
                this.individualAgeClassBindingSource.Remove(individualAgeClassBindingSource.Current);
                this.RefreshLabels();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Session.SaveOrUpdate(Individual);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonEditReproductiveState_Click(object sender, EventArgs e)
        {
            rse = new ReproductiveStateEditor(Session,this.Individual,
                (IndividualReproductiveState)individualReproductiveStateBindingSource.Current);
            rse.ShowDialog();
            dataGridViewIndividualReproductiveState.Refresh();
        }

        private void buttonEditIndividualSighting_Click(object sender, EventArgs e)
        {
            tce = new SightingEditor(Session,this.Individual,
                (IndividualSighting)individualSightingBindingSource.Current);
            tce.ShowDialog();
            dataGridViewIndividualSighting.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ace = new AgeClassEditor(Session, this.Individual,
               (IndividualAgeClass)individualAgeClassBindingSource.Current);
            ace.ShowDialog();
            this.dataGridViewIndividualAgeClass.Refresh();
        }

        private void buttonEditDetails_Click(object sender, EventArgs e)
        {
            new IndividualEditor(Individual.TroopVisitFirstObserved(), Individual).ShowDialog();
        }

        private void buttonNewEvent_Click(object sender, EventArgs e)
        {
            EventEditor tce = new EventEditor(Session, this.Individual);
            DialogResult result = tce.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //this.Individual.SightingHistory.Add(tce.State);
                this.individualEventBindingSource.Add(tce.State);
                Session.SaveOrUpdate(tce.State);
                this.RefreshLabels();
            }
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry from the database?",
                "Delete Data?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Individual.AgeClassHistory.Remove((IndividualAgeClass)individualAgeClassBindingSource.Current);
                if (((IndividualEvent)this.individualEventBindingSource.Current).ID > 0)
                    Session.Delete(this.individualEventBindingSource.Current);
                this.individualEventBindingSource.Remove(individualEventBindingSource.Current);
                this.RefreshLabels();
            }
        }

        private void buttonNewInteraction_Click(object sender, EventArgs e)
        {
            InteractionEditor tce = new InteractionEditor(Session, this.Individual);
            DialogResult result = tce.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //this.Individual.SightingHistory.Add(tce.State);
                this.individualInteractionBindingSource.Add(tce.State);
                Session.SaveOrUpdate(tce.State);
                this.RefreshLabels();
            }
        }

        private void buttonDeleteInteraction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry from the database?",
                "Delete Data?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Individual.AgeClassHistory.Remove((IndividualAgeClass)individualAgeClassBindingSource.Current);
                if (((IndividualInteraction)this.individualInteractionBindingSource.Current).ID > 0)
                    Session.Delete(this.individualInteractionBindingSource.Current);
                this.individualInteractionBindingSource.Remove(individualInteractionBindingSource.Current);
                this.RefreshLabels();
            }
        }

        private void buttonEditInteraction_Click(object sender, EventArgs e)
        {

        }

            

    }
}
