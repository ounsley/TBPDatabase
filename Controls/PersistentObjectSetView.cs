using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Forms;

namespace TBPDatabase.Controls
{
    class PersistentObjectSetView : DataGridView
    { 
        public PersistentObjectSetView():base()
        {
            this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.ReadOnly = true;
            this.AllowUserToDeleteRows = false;
            this.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.MultiSelect = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.DoubleClick += new EventHandler(PersistentObjectSetView_DoubleClick);
        }

        void PersistentObjectSetView_DoubleClick(object sender, EventArgs e)
        {
            new TroopCompositionEditor((TroopComposition)this.SelectedPersistentObject()).ShowDialog();
            this.RefreshSelectedRow();
        }

        
        /// <summary>
        /// Use the information in the persistent object to set the columns
        /// </summary>
        /// <param name="persistentObject"></param>
        public void AddPersistentObjectColumns(PersistentObject persistentObject)
        {
            foreach (PropertyInfo p in persistentObject.GetType().GetProperties())
            {
                this.Columns.Add(p.Name, p.Name);
            }            
        }

        /// <summary>
        /// Add each persistent object in the set to the View
        /// </summary>
        /// <param name="persistentObjectsSet"></param>
        public void AddPersistentObjectRows(ICollection<PersistentObject> persistentObjectsSet)
        {
            List<PersistentObject> persistentObjects = new List<PersistentObject>(persistentObjectsSet);
            if (persistentObjects.Count > 0)
            {
                //Add the persistent objects as new persistentObjectRows
                foreach (PersistentObject persistentObject in persistentObjects)
                {
                    PersistentObjectRow row = new PersistentObjectRow(persistentObject);
                    row.CreateCells(this);
                    row.SetValues();
                    this.Rows.Add(row);
                }
            }
        }

        public PersistentObject SelectedPersistentObject()
        {
            return ((PersistentObjectRow)SelectedRows[0]).PersistentObject;
        }

        private void RefreshSelectedRow()
        {
            ((PersistentObjectRow)SelectedRows[0]).Refresh();
        }

    }
}
