using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Domain;

namespace TBPDatabase.Controls
{
    class TroopCompositionStatusSelector:PersistentObjectSelector<TroopCompositionStatus>
    {
        ComboBox comboBox;

        public TroopCompositionStatusSelector(TroopCompositionStatus status = null)
        {
            this.comboBox = CreateComboBoxSelector("TroopCompositionStatus", "ID", "ID", status.ID);

            this.Controls.AddRange(new Control[] { new TBPLabel("Status"), this.comboBox });
        }

        public override TroopCompositionStatus GetProperty()
        {
            return (TroopCompositionStatus)GetPersistentObjectFromComboBox(this.comboBox);
        }
    }
}
