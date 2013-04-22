using System.Windows.Forms;
using System.Collections.Generic;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.Editors;
using TBPDatabase.Utilities;
using NHibernate.Transform;
using System.Drawing;
using System;
using NHibernate;

namespace TBPDatabase.SessionForms
{
    class SightingChanges : DataTableForm
    {
        Troop troop;
        TroopVisit troopVisit;
        BindingSource bindingSource;

        SortableBindingList<IndividualSighting> currentStates;
 
        public SightingChanges(TroopVisit tv)
        {
            this.bindingSource = new BindingSource();

            this.troop = tv.Troop;
            this.troopVisit = tv;
            this.Text = "Current Sightings:- " + tv.ToString() ;
            
            // Add context menu to datagridview
            ContextMenuStrip rowContextMenu = new ContextMenuStrip();
            ToolStripMenuItem notSeenButton = new ToolStripMenuItem();
            notSeenButton.Text = "Set to Not Seen";
            notSeenButton.Click += new System.EventHandler(notSeenButton_Click);
            ToolStripMenuItem editButton = new ToolStripMenuItem();
            editButton.Text = "Advanced entry";
            editButton.Click += new System.EventHandler(editButton_Click);
            //this.DataGridView.ContextMenuStrip = rowContextMenu;
            this.DataGridView.ContextMenuStrip.Items.AddRange(new ToolStripItem[] {notSeenButton,editButton});
        }

        void editButton_Click(object sender, System.EventArgs e)
        {
            RowAction(DataGridView.CurrentRow);
        }

        void notSeenButton_Click(object sender, System.EventArgs e)
        {
            // Create a new entry for the selectded individual with the current troop visit
            // and set to not seen.
            Individual individual = currentStates[DataGridView.CurrentRow.Index].Individual;
            IndividualSighting notSeen = new IndividualSighting();
            notSeen.TroopVisit = troopVisit;
            notSeen.Individual = individual;
            notSeen.Sighting = Session.Get<Sighting>("NS");
            
            individual.SightingHistory.Add(notSeen);
            IndividualSighting current = individual.CurrentSighting(troopVisit.Date);
            //this.AddNewEntry(notSeen, DataGridView.CurrentRow);
            RefreshRow(DataGridView.CurrentRow);
        }

        /// <summary>
        /// Needs to be called after the form is created to populate
        /// the datagridview and add context menus etc.
        /// </summary>
        public override void LoadData()
        {
            // Get all the individuals then find their current states
            IList<Individual> individuals = Session
                    .CreateQuery("from Individual as i " +
                    "join fetch i.SightingHistory as tc " +
                    "join fetch tc.TroopVisit as tv " +
                    "left join fetch i.ReproductiveStateHistory " +
                    "join fetch tc.Sighting ")
                    .SetResultTransformer(new DistinctRootEntityResultTransformer())
                    .List<Individual>();

            // Create a list for the current states
            currentStates = new SortableBindingList<IndividualSighting>();
            // Add each individuals current sighting
            foreach (Individual i in individuals)
            {
                IndividualSighting tc = i.CurrentSighting(troopVisit.Date);
                if (tc != null
                    && tc.TroopVisit.Troop.TroopID == troop.TroopID)
                    currentStates.Add(tc);
            }

            this.bindingSource.DataSource = currentStates;
            this.DataGridView.DataSource = bindingSource;
            this.DataGridView.Columns["Id"].DisplayIndex = 0;
            this.DataGridView.Columns["Individual"].DisplayIndex = 1;
            this.DataGridView.Columns["Sighting"].DisplayIndex = 2;

        }

        protected override void RowAction(DataGridViewRow row)
        {
            Individual individual = currentStates[row.Index].Individual;

            IndividualSighting tc = null;

            // We are making an entry for a specific date
            if (troopVisit != null)
            {
                tc = new IndividualSighting();
                tc.Individual = individual;
                tc.TroopVisit = troopVisit;
            }

            SightingEditor tce = new SightingEditor(Session,individual, tc);
            if (tce.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                individual.SightingHistory.Add(tce.State);
                RefreshRow(row);
            }

        }

        private void AddNewEntry(IndividualSighting tc, DataGridViewRow row)
        {
            this.currentStates[row.Index] = tc;
            this.DataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void SaveNewEntries()
        {
            foreach (IndividualSighting tc in currentStates)
            {
                // Select unentered rows and save
                if (tc.ID == 0)
                {
                    Session.SaveOrUpdate(tc);
                }
            }
        }

        protected override void OkAction()
        {
            //SaveNewEntries();
        }

        protected override void RefreshRow(DataGridViewRow row)
        {
            Individual individual = currentStates[row.Index].Individual;
            this.currentStates[row.Index] = individual.CurrentSighting(troopVisit.Date);
            this.DataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
