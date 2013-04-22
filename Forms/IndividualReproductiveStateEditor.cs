using System;
using System.Collections.Generic;

using TBPDatabase.Domain;
using TBPDatabase.Controls;

namespace TBPDatabase.Forms;
/*{
    class IndividualReproductiveStateEditor :PersistentObjectEditor<IndividualReproductiveState>
    {
        IndividualSelector individualSelector;


        public IndividualReproductiveStateEditor(IndividualReproductiveState reproductiveState)
            : base(reproductiveState)
        {
            this.individualSelector = new IndividualSelector(this.persistentObject.Individual);

            this.propertyPanel.Controls.Add(individualSelector);
        }

        public override void UpdatePersistentObject()
        {
            this.persistentObject.Individual = individualSelector.GetProperty();
        }
    }
  * /
}
