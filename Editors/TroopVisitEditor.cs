using System;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.Utilities;
using NHibernate;

namespace TBPDatabase.Editors
{
    public partial class TroopVisitEditor : Form
    {
        private TroopVisit troopVisit;
        public TroopVisit TroopVisit
        {
            get { return this.troopVisit; }
        }

        public TroopVisitEditor(ISession session, TroopVisit troopVisit = null)
        {
            InitializeComponent();
            this.troopVisit = troopVisit;

            // Fill comboboxes
            System.Collections.Generic.IList<Location> locations = session
                .CreateQuery("select l from Location as l")
                .List<Location>();

            foreach (Location l in locations)
            {
                this.aMSleepingCliffComboBox.Items.Add(l);
                this.pMSleepingCliffComboBox.Items.Add(l);
            }

            this.troopComboBox.DataSource = session
                .CreateQuery("select t from Troop as t")
                .List<Troop>();

            // Are we editing or making a new entry?
            if (troopVisit != null)
            {
                // Read in values from troopvisit
                this.aMSleepingCliffComboBox.SelectedItem = troopVisit.AMSleepingCliff;
                this.pMSleepingCliffComboBox.SelectedItem = troopVisit.PMSleepingCliff;
                this.troopComboBox.SelectedItem = troopVisit.Troop;
                this.dateDateTimePicker.Value = troopVisit.Date;
                this.commentsTextBox.Text = troopVisit.Comments;
                this.waterCheckBox.Checked = troopVisit.Water;
                this.gPSRouteCheckBox.Checked = troopVisit.GPSRoute;
                this.fullDayFollowCheckBox.Checked = troopVisit.FullDayFollow;
                this.distanceTextBox.Text = troopVisit.Distance.ToString();
            }
            else 
            {
                this.troopVisit = new TroopVisit();
            }

            // Hook up the crucial controls to the validity check
            this.troopComboBox.SelectedValueChanged += new EventHandler(controlValueChanged);
            this.aMSleepingCliffComboBox.SelectedValueChanged += new EventHandler(controlValueChanged);
            this.pMSleepingCliffComboBox.SelectedValueChanged += new EventHandler(controlValueChanged);
            this.dateDateTimePicker.ValueChanged += new EventHandler(controlValueChanged);
            this.distanceTextBox.TextChanged += new EventHandler(controlValueChanged);

            ValidEntry();
        }

        /// <summary>
        /// Calls check on validity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void controlValueChanged(object sender, EventArgs e)
        {
            ValidEntry();
        }

        // Check to see if the troop visit is valid
        private bool ValidEntry()
        {
            // INTEGRITY CHECK
            bool valid = false;
            float dummy;

            valid = (this.troopComboBox.SelectedItem != null
                && this.dateDateTimePicker.Value != null
                && this.dateDateTimePicker.Checked == true
                && this.aMSleepingCliffComboBox.SelectedItem != null
                && this.pMSleepingCliffComboBox.SelectedItem  != null
                && float.TryParse(this.distanceTextBox.Text,out dummy));

            if (valid)
                this.buttonOk.Enabled = true;
            else
                this.buttonOk.Enabled = false;

            return valid;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Validity checked, so assign values;
            this.troopVisit.Date = dateDateTimePicker.Value;
            this.troopVisit.AMSleepingCliff = (Location)aMSleepingCliffComboBox.SelectedItem;
            this.troopVisit.PMSleepingCliff = (Location)pMSleepingCliffComboBox.SelectedItem;
            this.troopVisit.Troop = (Troop)troopComboBox.SelectedItem;
            this.troopVisit.Comments = commentsTextBox.Text;
            this.troopVisit.Distance = float.Parse(distanceTextBox.Text);
            this.troopVisit.Water = waterCheckBox.Checked;
            this.troopVisit.GPSRoute = gPSRouteCheckBox.Checked;
            this.troopVisit.FullDayFollow = fullDayFollowCheckBox.Checked;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
