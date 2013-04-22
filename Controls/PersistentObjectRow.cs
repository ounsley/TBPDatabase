using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

using TBPDatabase.Domain;

namespace TBPDatabase.Controls
{
    class PersistentObjectRow : DataGridViewRow
    {
        PersistentObject persistentObject;

        public PersistentObject PersistentObject { get { return this.persistentObject; } }

        public PersistentObjectRow(PersistentObject persistentObject)
            : base()
        {
            this.persistentObject = persistentObject;
        }

        public PersistentObjectRow() : base() { }

        /// <summary>
        /// Set the default values of the row via reflection
        /// </summary>
        public void SetValues() 
        {
            Type type = persistentObject.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance|BindingFlags.Public);
            object[] rowValues = new object[properties.Length];
            int i = 0;
            foreach (PropertyInfo p in properties)
            {
                object value = p.GetValue(persistentObject, null);
                if (value == null)
                    rowValues[i] = "N/A";
                else if (value.GetType().GetInterface("IPersistentObject") == typeof(PersistentObject))
                    rowValues[i] = ((PersistentObject)value).ToString();
                else
                    rowValues[i] = value.ToString();
                i++;
            }
            this.SetValues(rowValues);
        }

        internal void Refresh()
        {
            this.SetValues();
        }
    }
}
