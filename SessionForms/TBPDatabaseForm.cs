using System;
using System.Windows.Forms;

namespace TBPDatabase.SessionForms
{
    public partial class TBPDatabaseForm : Form
    {
        public TBPDatabaseForm()
        {
            InitializeComponent();
            this.Text = this.Text + " - Version" + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DailyInput.DailyInputWizard().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormIndividualSearch f = new FormIndividualSearch();
            f.ShowDialog();
            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                new IndiviualForm(f.Individual).ShowDialog();
            }
            
        }
    }
}
