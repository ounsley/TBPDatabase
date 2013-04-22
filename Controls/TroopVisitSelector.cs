using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using NHibernate;

namespace TBPDatabase.Controls
{
    /// <summary>
    /// Contains both a date selector and troop lookup, to define a
    /// specific TroopVisit. If none are found prompts to create a new default
    /// TroopVisit.
    /// </summary>
    class TroopVisitSelector : PersistentObjectSelector<TroopVisit>
    {
        ComboBox troopComboBox;
        DateTimePicker dateTimePicker;

        /// <summary>
        /// Creates and Instance of the TroopVisit Selector
        /// </summary>
        /// <param name="troopVisit">The a troop visit to be pre selected</param>
        public TroopVisitSelector(TroopVisit troopVisit = null)
        {
            this.dateTimePicker = new DateTimePicker();
            this.dateTimePicker.Format = DateTimePickerFormat.Short;
            if (troopVisit != null)
                this.dateTimePicker.Value = troopVisit.Date;
            this.dateTimePicker.Width = 100;

            this.troopComboBox = CreateComboBoxSelector("Troop", "TroopID", "TroopID", troopVisit.Troop.TroopID);
            this.Controls.AddRange(new Control[] { new TBPLabel("Troop Visit"), troopComboBox, dateTimePicker });
        }

        public override TroopVisit GetProperty()
        {
            Troop troop = (Troop)this.GetPersistentObjectFromComboBox(troopComboBox, typeof(Troop));
            DateTime date = dateTimePicker.Value;
            List<TroopVisit> troopVisits = new List<TroopVisit>();

            IQuery query = NHibernateHelper.GetCurrentSession()
                    .CreateQuery("select t from TroopVisit as t where t.Date =:date and t.Troop =:troop")
                    .SetParameter("date", date).SetParameter("troop", troop);
            troopVisits = (List<TroopVisit>)query.List<TroopVisit>();

            ///INTEGRITY CHECK
            if (troopVisits.Count < 1)
            {
                MessageBox.Show("There were no TroopVisit entries found for "
                    + troop.TroopID + " on " + date.ToShortDateString()
                    + ". Would you like to create a default entry for these values?",
                    "No Troop Visit found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
            }

            return troopVisits[0];
        }
    }
}
