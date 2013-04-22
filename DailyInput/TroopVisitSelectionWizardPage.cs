using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.Utilities;
using NHibernate;
using NHibernate.Transform;

namespace TBPDatabase.DailyInput
{
    public partial class TroopVisitSelectionWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;

        ITransaction tx;
        ISession session;

        SortableBindingList<TroopVisit> troopVisits;

        bool currentlyValid = false;

        public bool CurrentlyValid
        {
            get { return this.currentlyValid; }
        }

        public string Heading
        {
            get { return "Select the troop visited and date of visit, or select a previous troop visit."; }
        }

        public TroopVisitSelectionWizardPage()
        {
            InitializeComponent();
            this.currentlyValid = false;


            this.dateDateTimePicker.ValueChanged += new EventHandler(Verify);
            this.troopComboBox.SelectedValueChanged += new EventHandler(Verify);
            this.radioButtonNew.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            this.dataGridViewRecentTroopVisits.Click += new EventHandler(dataGridViewRecentTroopVisits_Click);
            this.radioButtonNew.Checked = true;
            this.dataGridViewRecentTroopVisits.ClearSelection();

        }

        void dataGridViewRecentTroopVisits_Click(object sender, EventArgs e)
        {
            radioButtonExisting.Checked = true;
        }


        void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNew.Checked)
            {
                this.troopComboBox.Enabled = true;
                this.dateDateTimePicker.Enabled = true;
                //this.dataGridViewRecentTroopVisits.Enabled = false;
            }
            else
            {
                this.troopComboBox.Enabled = false;
                this.dateDateTimePicker.Enabled = false;
                //this.dataGridViewRecentTroopVisits.Enabled = true;
            }
        }

        public void LoadData()
        {
            DailyData.Current.Dispose();
            session = NHibernateHelper.OpenNewSession();
            tx = session.BeginTransaction();

            this.troopComboBox.DataSource = session
                .CreateQuery("select t from Troop as t")
                .List<Troop>();

            this.troopVisits = new SortableBindingList<TroopVisit>(session.
                CreateQuery("select tv from TroopVisit as tv " +
                "left join fetch tv.Observers " +
                "left join fetch tv.Troop " + 
                "left join fetch tv.AMSleepingCliff " +
                "left join fetch tv.PMSleepingCliff " +
                "order by tv.Date DESC")
                //.SetMaxResults(10)
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .List<TroopVisit>());


            this.dataGridViewRecentTroopVisits.DataSource = troopVisits;

            if (DailyData.Current.RetrievedData)
            {
                //this.troopComboBox.SelectedValue = DailyData.Current.TroopVisit.Troop;
            }

            try
            {
                tx.Commit();
            }
            catch
            {
                MessageBox.Show("Failed to load data from database");
            }
            this.dataGridViewRecentTroopVisits.ClearSelection();
            this.FinishedLoading(this, null);
        }

        private void Verify(object sender, EventArgs e)
        {
            bool valid = true;

            if (valid != currentlyValid)
            {
                this.currentlyValid = valid;
                if(ValidityChanged != null)
                    this.ValidityChanged(this,null);
            }
        }

        public bool Finish()
        {
            if (radioButtonNew.Checked)
            {
                // Check to see if this already exists
                tx = session.BeginTransaction();
                TroopVisit existingTroopVisit = session.CreateQuery("select tv from TroopVisit as tv "
                    + "where tv.Date = :date and tv.Troop = :troop")
                    .SetParameter<DateTime>("date", this.dateDateTimePicker.Value.Date)
                    .SetParameter<Troop>("troop", (Troop)this.troopComboBox.SelectedValue)
                    .UniqueResult<TroopVisit>();
                tx.Commit();

                if (existingTroopVisit != null) // i.e data already exists for today
                {
                    if (MessageBox.Show("There is a current troop visit already entered for this date and troop." +
                        "Press OK to edit the existing data for this troop visit.",
                        "Data already entered", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        DailyData.Current.Load(existingTroopVisit);
                    }
                    else
                        return false;
                }
                else
                {
                    DailyData.Current.TroopVisit.Troop = (Troop)this.troopComboBox.SelectedValue;
                    DailyData.Current.TroopVisit.Date = this.dateDateTimePicker.Value.Date;
                }
            }
            else
            {
                DailyData.Current.Load(troopVisits[dataGridViewRecentTroopVisits.CurrentRow.Index]);

            }

            return true;
        }

        public void Selected()
        {
        }

       
    }
}
