using System;
using System.Windows.Forms;

namespace TBPDatabase.Utilities
{
    public class YesNoSelector
    {
        public event EventHandler YesNoChanged;

        bool receivedInput = false;
        RadioButton yesButton;
        RadioButton noButton;

        public bool ReceivedInput { get { return receivedInput; } }
        public bool Yes { get { return yesButton.Checked; } }

        public YesNoSelector(RadioButton yesButton, RadioButton noButton)
        {
            this.yesButton = yesButton;
            this.noButton = noButton;

            this.yesButton.Checked = false;
            this.noButton.Checked = false;

            this.yesButton.Click += new EventHandler(yesButton_Click);
            this.noButton.Click += new EventHandler(noButton_Click);
        }

        void noButton_Click(object sender, EventArgs e)
        {
            this.receivedInput = true;
            this.yesButton.Checked = false;
            if (this.YesNoChanged != null)
                this.YesNoChanged(this, null);
        }

        void yesButton_Click(object sender, EventArgs e)
        {
            this.receivedInput = true;
            this.noButton.Checked = false;
            if (this.YesNoChanged != null)
                this.YesNoChanged(this, null);
        }

        internal void SetValue(bool p)
        {
            this.receivedInput = true;
            this.yesButton.Checked = p;
            this.noButton.Checked = !p;
        }
    }
}
