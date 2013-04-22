using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Domain;
using NHibernate;
using TBPDatabase.Repositories;

namespace TBPDatabase.Controls
{
    class IndividualSelector : PersistentObjectSelector<Individual>
    {
        ComboBox comboBox;

        /// <summary>
        /// Creates a new Individual Selector instance
        /// </summary>
        /// <param name="individual">A default individual to pre select</param>
        public IndividualSelector(Individual individual = null)
            : base()
        {
            this.comboBox = CreateComboBoxSelector("Individual","ID","Name",individual.ID);
            this.Controls.Add(new TBPLabel("Individual"));
            this.Controls.Add(this.comboBox);
        }

        public override Individual GetProperty()
        {
            return (Individual)GetPersistentObjectFromComboBox(this.comboBox);
        }
    }
}
