using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using NHibernate;

namespace TBPDatabase.Controls
{
    /// <summary>
    /// A Control that enables lookup and selection of a type of
    /// PersistentObject form the database
    /// </summary>
    public abstract class PersistentObjectSelector<T> :PropertyControl<T> where T:PersistentObject 
    {
        /// <summary>
        /// A helper class for combo box items. Stores a description for display
        /// and an Id for lookups, can be add to ComboBox.Items
        /// </summary>
        protected class IDComboBoxItem
        {
            public object id;
            public object description;

            public IDComboBoxItem(object[] result)
            {
                this.id = result[0];
                this.description = (string)result[1];
            }

            public override string ToString()
            {
                return this.description.ToString();
            }
        }

        public PersistentObjectSelector()
        {
            this.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
        }

        /// <summary>
        /// Helper method for creating selectors for persistent objects, which
        /// display a description property whilst allowing for id lookups
        /// </summary>
        /// <param name="poName">The name of the persistent object type</param>
        /// <param name="idObject">The name of the id property of the persistent object</param>
        /// <param name="descriptionObject">The property to be displayed</param>
        /// <param name="initialId">The initial value to be selected</param>
        /// <returns></returns>
        protected static ComboBox CreateComboBoxSelector(string poName, string idObject, string descriptionObject, object initialId = null)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Width = 80;

            ISession session = NHibernateHelper.GetCurrentSession();

            IQuery query = session.CreateQuery("select po." + idObject + ", po." + descriptionObject +
                " from " + poName + " as po order by po." + descriptionObject);
            foreach (object[] idNameResults in query.Enumerable())
            {
                IDComboBoxItem item = new IDComboBoxItem(idNameResults);
                comboBox.Items.Add(item);
                if (initialId != null && item.id.ToString() == initialId.ToString())
                    comboBox.SelectedIndex = comboBox.Items.IndexOf(item);
            }
            return comboBox;
        }

        /// <summary>
        /// Return the selected IPersistentObject from a given comboBox
        /// </summary>
        /// <param name="comboBox">The comboBox to use</param>
        /// <param name="overridingEntityName">An entity type to retrieve  other than default</param>
        /// <returns>The persistent object selected in the combobox</returns>
        protected PersistentObject GetPersistentObjectFromComboBox(ComboBox comboBox, Type overridingEntityName = null)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            object id = ((IDComboBoxItem)comboBox.SelectedItem).id;
            PersistentObject persistentObject = null;
                if (overridingEntityName == null)
                    persistentObject = session.Get<T>(id);
                else
                    persistentObject = (PersistentObject)session.Get(overridingEntityName, id);
            return persistentObject;
        }
    }
}
