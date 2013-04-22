using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TBPDatabase.Controls
{
    public abstract class PropertyControl<T>:FlowLayoutPanel
    {
        public PropertyControl()
        {
            this.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
        }
        public abstract T GetProperty();
    }
}
