using System;
using System.Windows.Forms;

namespace TBPDatabase.DailyInput
{
    class WizardTabControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }

        protected override void OnKeyDown(KeyEventArgs ke)
        {
            // Block Ctrl+Tab and Ctrl+Shift+Tab hotkeys
            if (ke.Control && ke.KeyCode == Keys.Tab)
                return;
            base.OnKeyDown(ke);
        }

        public bool NextPage()
        {
            if (this.SelectedIndex < this.TabCount - 1)
            {
                this.SelectedIndex++;
                return true;
            }

            return false;
        }

        public void PreviousPage()
        {
            if (this.SelectedIndex > 0)
                this.SelectedIndex--;
        }
    }
}
