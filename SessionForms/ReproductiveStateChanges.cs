using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

using TBPDatabase.Editors;
using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.Utilities;
using NHibernate.Transform;
using System.Drawing;

namespace TBPDatabase.SessionForms
{
    class ReproductiveStateChanges : DataTableForm
    {
        TroopVisit troopVisit;
        SortableBindingList<IndividualReproductiveState> currentStates;
        BindingSource bindingSource;

        class ReproductiveStateButton : ToolStripButton
        {
            ReproductiveState state;
            public ReproductiveState State
            {
                get { return state; }
            }
            public ReproductiveStateButton(ReproductiveState state)
            {
                this.state = state;
                this.Text = "Change to " + state.State;
            }
        }

        public ReproductiveStateChanges(TroopVisit troopVisit)
        {
            this.troopVisit = troopVisit;
            this.Text = "Reproducive States:- " + troopVisit.ToString();

            foreach (ReproductiveState r in Session
                .CreateQuery("from ReproductiveState").List<ReproductiveState>())
            {
                ReproductiveStateButton b = new ReproductiveStateButton(r);
                b.Click += new System.EventHandler(ReproductiveStateButton_click);
                this.DataGridView.ContextMenuStrip.Items.Add(b);
            }
        }

        void ReproductiveStateButton_click(object sender, System.EventArgs e)
        {
            Individual individual = currentStates[DataGridView.CurrentRow.Index].Individual;
            IndividualReproductiveState newState = new IndividualReproductiveState();
            newState.State = ((ReproductiveStateButton)sender).State;
            newState.TroopVisit = troopVisit;
            newState.Individual = individual;
            individual.ReproductiveStateHistory.Add(newState);
            RefreshRow(DataGridView.CurrentRow);
            
            //this.AddNewEntry(currentState, DataGridView.CurrentRow);
        }
        /*
        private void AddNewEntry(IndividualReproductiveState rs, DataGridViewRow row)
        {
            IndividualReproductiveState currentState = individual.GetIndividualReproductiveStateOnDate(troopVisit.Date);
            this.currentStates[row.Index] = rs;
            this.DataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
        }
        */
        public override void  LoadData()
        {
            List<Individual> individuals = Individual.LoadAll(Session);

            currentStates = new SortableBindingList<IndividualReproductiveState>();
            foreach (Individual i in individuals)
            {
                IndividualReproductiveState irs = i.CurrentReproductiveState(troopVisit.Date);
                if(irs != null && 
                    i.CurrentTroop() != null &&
                    i.CurrentTroop().TroopID == troopVisit.Troop.TroopID)
                    currentStates.Add(irs);
            }

            this.bindingSource = new BindingSource();
            this.bindingSource.DataSource = currentStates;
            this.DataGridView.DataSource = bindingSource;

            // Re-order columns a bit
            this.DataGridView.Columns["Id"].DisplayIndex = 0;
            this.DataGridView.Columns["Individual"].DisplayIndex = 1;
            this.DataGridView.Columns["State"].DisplayIndex = 2;
        }

        protected override void RowAction(DataGridViewRow row)
        {
            Individual individual = (Individual)row.Cells["Individual"].Value;
            //IndividualReproductiveState irc = NHibernateHelper.GetCurrentSession().Get<IndividualReproductiveState>(row.Cells["Id"].Value);

            IndividualReproductiveState irs = null;

            if (troopVisit != null)
            {
                irs = new IndividualReproductiveState();
                irs.Individual = individual;
                irs.TroopVisit = troopVisit;
            }

            ReproductiveStateEditor rce = new ReproductiveStateEditor(Session,individual,irs);

            if (rce.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                individual.ReproductiveStateHistory.Add(rce.State);
                RefreshRow(row);
            }
        }

        protected override void OkAction()
        {
            //SaveNewEntries();
        }

        private void SaveNewEntries()
        {
            foreach (IndividualReproductiveState rs in currentStates)
            {
                // Select unentered rows and save
                if (rs.ID == 0)
                {
                    Session.SaveOrUpdate(rs);
                }
            }
        }

        protected override void RefreshRow(DataGridViewRow row)
        {
            Individual individual = currentStates[row.Index].Individual;
            //this.Session.Refresh(individual);

            IndividualReproductiveState currentState = individual.CurrentReproductiveState(troopVisit.Date);
            
            this.currentStates[row.Index] = currentState;
            this.DataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
