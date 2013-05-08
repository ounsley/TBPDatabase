using System;
using System.Windows.Forms;
using System.Reflection;
using System.Deployment.Application;

namespace TBPDatabase.SessionForms
{
    public partial class TBPDatabaseForm : Form
    {
        public TBPDatabaseForm()
        {
            InitializeComponent();
            Version version = new Version();
            version = Assembly.GetExecutingAssembly().GetName().Version;
            if (ApplicationDeployment.IsNetworkDeployed)
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            this.Text = Application.ProductName + " - V" + version.ToString(4);
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
