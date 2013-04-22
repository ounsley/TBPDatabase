using System.Windows.Forms;
using System;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using TBPDatabase.Utilities;

using System.ComponentModel;
using NHibernate.Transform;
using TBPDatabase.Editors;

namespace TBPDatabase.SessionForms
{
    /// <summary>
    /// Displays a dialog enabling the user to select a Troop Visit
    /// </summary>
    public partial class TroopVisitSelector : SessionForm
    {
        TroopVisit tv;
        SortableBindingList<TroopVisit> bindingList;

        /// <summary>
        /// Get the selected TroopVisist
        /// </summary>
        public TroopVisit TroopVisit
        {
            get { return tv; }
        }

        public TroopVisitSelector(Troop troop = null)
        {
            InitializeComponent();

            this.dataGridView1.AutoSize = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /// TODO
            /// Revise query
            string query = "Select t from TroopVisit as t " +
                    "left join fetch t.AMSleepingCliff " +
                    "left join fetch t.PMSleepingCliff " +
                    "left join fetch t.Observers " +
                    "left join fetch t.Troop ";
            if (troop != null)
                query += "where t.Troop.TroopID = '" + troop.TroopID + "' ";
            query += "order by Date desc";

            // Attempt to add sorting to bindings.
            this.dataGridView1.DataBindings.Clear();
            this.bindingList = new SortableBindingList<TroopVisit>(Session
                  .CreateQuery(query)
                  .SetResultTransformer(new DistinctRootEntityResultTransformer())
                  .List<TroopVisit>());
            this.dataGridView1.DataSource = bindingList;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Save();
            this.tv = (TroopVisit)bindingList[dataGridView1.SelectedRows[0].Index];
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            TroopVisitEditor tve = new TroopVisitEditor(Session,bindingList[dataGridView1.CurrentRow.Index]);
            tve.ShowDialog();
            RefreshData();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            TroopVisitEditor tve = new TroopVisitEditor(Session);
            if (tve.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.bindingList.Insert(0,tve.TroopVisit);
            }
        }

        private void RefreshData()
        {
            bindingList.ResetBindings();
            dataGridView1.DataSource = bindingList;
        }

        private void Save()
        {
            foreach (TroopVisit tv in bindingList)
            {
                Session.SaveOrUpdate(tv);
            }
        }

    }
}
