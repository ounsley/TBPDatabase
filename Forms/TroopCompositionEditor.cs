using System;
using System.Collections.Generic;

using TBPDatabase.Controls;
using TBPDatabase.Domain;
using System.Windows.Forms;


namespace TBPDatabase.Forms
{
    class TroopCompositionEditor : PersistentObjectEditor<TroopComposition>
    {
        IndividualSelector individualSelector;
        TroopVisitSelector troopVisitSelector;
        TroopCompositionStatusSelector troopCompositionStatusSelector;
        TimeControl timeControl;
        CommentControl commentControl;

        public TroopCompositionEditor(TroopComposition troopComposition)
            : base(troopComposition)
        {
            this.Text = "Troop Composition Editor";
            this.individualSelector = new IndividualSelector(this.persistentObject.Individual);
            this.troopVisitSelector = new TroopVisitSelector(troopComposition.TroopVisit);
            this.troopCompositionStatusSelector = new TroopCompositionStatusSelector(troopComposition.Status);
            this.timeControl = new TimeControl(troopComposition.Time);
            this.commentControl = new CommentControl(troopComposition.Comments);

            this.propertyPanel.Controls.Add(individualSelector);
            this.propertyPanel.Controls.Add(troopVisitSelector);
            this.propertyPanel.Controls.Add(troopCompositionStatusSelector);
            this.propertyPanel.Controls.Add(timeControl);
            this.propertyPanel.Controls.Add(commentControl);

        }

        public override void UpdatePersistentObject()
        {
            this.persistentObject.Individual = this.individualSelector.GetProperty();
            this.persistentObject.TroopVisit = this.troopVisitSelector.GetProperty();
            this.persistentObject.Status = this.troopCompositionStatusSelector.GetProperty();
            this.persistentObject.Time = this.timeControl.GetProperty();
            this.persistentObject.Comments = this.commentControl.GetProperty();
        }
    }
}
