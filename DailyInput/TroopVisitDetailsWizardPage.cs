using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.Utilities;
using NHibernate;
using TBPDatabase.Editors;

namespace TBPDatabase.DailyInput
{
    public partial class TroopVisitDetailsWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;

        ITransaction tx;
        ISession session;

        bool currentlyValid = false;

        YesNoSelector FullDayFollow;
        YesNoSelector Water;
        YesNoSelector GPS;

        SortableBindingList<TroopVisitObserver> observers;

        BindingList<Location> locationsAM;
        BindingList<Location> locationsPM;

        public bool CurrentlyValid
        {
            get { return this.currentlyValid; }
        }

        public string Heading
        {
            get { return "Enter the details of todays troop visit."; }
        }

        public TroopVisitDetailsWizardPage()
        {
            InitializeComponent();

            this.FullDayFollow = new YesNoSelector(radioButtonFullDayFollowYes, radioButtonFullDayFollowNo);
            this.Water = new YesNoSelector(radioButtonWaterYes, radioButtonWaterNo);
            this.GPS = new YesNoSelector(radioButtonGPSYes, radioButtonGPSNo);

            // Hook up input events to verification method
            FullDayFollow.YesNoChanged += new EventHandler(Verify);
            Water.YesNoChanged += new EventHandler(Verify);
            GPS.YesNoChanged += new EventHandler(Verify);
            //this.dateDateTimePicker.ValueChanged += new EventHandler(Verify);
            //this.troopComboBox.SelectedValueChanged += new EventHandler(Verify);
            this.aMSleepingCliffComboBox.SelectedValueChanged += new EventHandler(Verify);
            this.aMSleepingCliffComboBox.SelectedValueChanged += new EventHandler(UpdateCommonName);
            this.pMSleepingCliffComboBox.SelectedValueChanged += new EventHandler(Verify);
            this.pMSleepingCliffComboBox.SelectedValueChanged += new EventHandler(UpdateCommonName);

            this.distanceTextBox.TextChanged += new EventHandler(Verify);


        }

        public void LoadData()
        {
            session = NHibernateHelper.GetCurrentSession();
            tx = session.BeginTransaction();

            // Fill comboboxes
            locationsAM = new BindingList<Location>(session
                .CreateQuery("select l from Location as l")
                .List<Location>());

            // We nee d a seperate copy of the lcoations for to have different datasources, so...
            locationsPM = new BindingList<Location>(locationsAM);

            aMSleepingCliffComboBox.DataSource = locationsAM;
            pMSleepingCliffComboBox.DataSource = locationsPM;

            this.comboBoxObservers.DataSource = session
                .CreateQuery("select o from Observer as o")
                .List<Observer>();

            observers = new SortableBindingList<TroopVisitObserver>();

            try
            {
                tx.Commit();
            }
            catch
            {
                MessageBox.Show("Failed to load data from database");
            }

            // Lets check if the data has already been retrieved and fill in values accordingly
            if (DailyData.Current.RetrievedData == true)
            {
                this.Water.SetValue(DailyData.Current.TroopVisit.Water);
                this.GPS.SetValue(DailyData.Current.TroopVisit.GPSRoute);
                this.FullDayFollow.SetValue(DailyData.Current.TroopVisit.FullDayFollow);
                this.distanceTextBox.Text = DailyData.Current.TroopVisit.Distance.ToString();
                this.commentsTextBox.Text = DailyData.Current.TroopVisit.Comments;
                this.aMSleepingCliffComboBox.SelectedItem = DailyData.Current.TroopVisit.AMSleepingCliff;
                this.pMSleepingCliffComboBox.SelectedItem = DailyData.Current.TroopVisit.PMSleepingCliff;
                this.observers = new SortableBindingList<TroopVisitObserver>(DailyData.Current.TroopVisit.Observers);
                // Lets check that all is good
                Verify(this, null);
            }

            this.dataGridViewObservers.DataSource = observers;
            this.FinishedLoading(this, null);

        }

        private void UpdateCommonName(object sender, EventArgs e)
        {
            if (aMSleepingCliffComboBox.SelectedItem != null)
                this.labelAMCommonName.Text = ((Location)aMSleepingCliffComboBox.SelectedItem).CommonName;
            if (pMSleepingCliffComboBox.SelectedItem != null)
                this.labelPMCommonName.Text = ((Location)pMSleepingCliffComboBox.SelectedItem).CommonName;
        }

        private void Verify(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= Water.ReceivedInput && GPS.ReceivedInput && FullDayFollow.ReceivedInput;
            float dummy = 0;
            valid &= float.TryParse(this.distanceTextBox.Text, out dummy);

            if (valid != currentlyValid)
            {
                this.currentlyValid = valid;
                if (ValidityChanged != null)
                    this.ValidityChanged(this, null);
            }
        }

        public bool Finish()
        {
            // Update the details of the DailyData TroopVisit

            DailyData.Current.TroopVisit.AMSleepingCliff = (Location)this.aMSleepingCliffComboBox.SelectedItem;
            DailyData.Current.TroopVisit.Comments = this.commentsTextBox.Text;
            DailyData.Current.TroopVisit.Distance = float.Parse(this.distanceTextBox.Text);
            DailyData.Current.TroopVisit.FullDayFollow = this.FullDayFollow.Yes;
            DailyData.Current.TroopVisit.GPSRoute = this.GPS.Yes;
            DailyData.Current.TroopVisit.PMSleepingCliff = (Location)this.pMSleepingCliffComboBox.SelectedItem;
            DailyData.Current.TroopVisit.Water = this.Water.Yes;
            DailyData.Current.TroopVisit.Observers = this.observers;

            DailyData.Current.NewTroopVisitObservers.AddRange(this.observers);



            return true;
        }

        private void buttonObserverAdd_Click(object sender, EventArgs e)
        {
            TroopVisitObserver tvo = new TroopVisitObserver();
            tvo.TroopVisit = DailyData.Current.TroopVisit;
            tvo.Observer = (Observer)this.comboBoxObservers.SelectedItem;
            this.observers.Add(tvo);
        }

        private void buttonObserverDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewObservers.CurrentRow.Index >= 0)
                this.observers.RemoveAt(dataGridViewObservers.CurrentRow.Index);
        }

        public void Selected()
        {
        }

        private void buttonAddNewLocation_Click(object sender, EventArgs e)
        {
            LocationEditor le = new LocationEditor();

            if (le.ShowDialog() == DialogResult.OK)
            {
                // Created a valid location so 
                //DailyData.Current.NewLocations.Add(le.TBPLocation);
                //this.locationsAM.Add(le.TBPLocation);
                this.locationsPM.Add(le.TBPLocation);
            }

        }

    }
}
