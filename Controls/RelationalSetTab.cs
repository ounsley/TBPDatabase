using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Domain;
using System.Collections.ObjectModel;

namespace TBPDatabase.Controls
{
    public partial class RelationalSetTab : TabPage
    {
        public RelationalSetTab(List<TroopComposition> persistentObjects)
            : base()
        {
            if (persistentObjects.Count > 0)
            {
                PersistentObjectSetView setView = new PersistentObjectSetView();
                PersistentObject first = new List<PersistentObject>(persistentObjects)[0];
                persistentObjects.GetEnumerator().MoveNext();
                setView.AddPersistentObjectColumns(first);
                //setView.AddPersistentObjectRows(persistentObjects);
                setView.Name = "persistentObjectSetView";
                setView.Dock = DockStyle.Fill;
                this.Controls.Add(setView);
                this.Text = first.GetType().Name;
            }
        }

    }
}
