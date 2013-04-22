using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TBPDatabase.Controls
{
    class TBPLabel: Label
    {
        public TBPLabel(string text):base()
        {
            this.Text = text;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Size = new System.Drawing.Size(60, 30);
        }
    }
}
