using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using TBPDatabase.DataImport;
using TBPDatabase.Domain;
using TBPDatabase.Editors;
using TBPDatabase.Repositories;
using TBPDatabase.Utilities;
using TBPDatabase.DailyInput;

namespace TBPDatabase.SessionForms
{
    public partial class FormMain : SessionForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFindIndividual_Click(object sender, EventArgs e)
        {
            FormIndividualSearch indSearch = new FormIndividualSearch();
            DialogResult result = indSearch.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                new IndiviualForm(indSearch.Individual).ShowDialog();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            new TroopVisitSelector().ShowDialog();
        }


        private void buttonImport_Click(object sender, EventArgs e)
        {
            new ImportDemographyDataForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new DailyEntry().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Troop t = Session.Get<Troop>("J");
            IList<TroopVisit> tvs = Session
            .CreateQuery("from TroopVisit as tv " +
            "where tv.Troop = :troop " +
            "and Date = :date ")
            .SetParameter<Troop>("troop", t)
            .SetParameter<DateTime>("date", new DateTime(2009,11,07))
            .List<TroopVisit>();

            /// INTEGRITY CHECK
            /// The above query should only return a single instance
            if (tvs.Count != 1 )
            {
                //ERROR
            }

            SightingChanges tcc = new SightingChanges(tvs[0]);
            tcc.LoadData();
            tcc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Troop t = Session.Get<Troop>("J");
            IList<TroopVisit> tvs = Session
            .CreateQuery("from TroopVisit as tv " +
            "where tv.Troop = :troop " +
            "and Date = :date ")
            .SetParameter<Troop>("troop", t)
            .SetParameter<DateTime>("date", new DateTime(2009, 11, 07))
            .List<TroopVisit>();
            ReproductiveStateChanges rsc = new ReproductiveStateChanges(tvs[0]);
            rsc.LoadData();
            rsc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Individual i = Session.Get<Individual>("HF12");
            new AgeClassEditor(Session,i).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Individual i = Session.Get<Individual>("HF12");
            new IndividualEditor(i.TroopVisitFirstObserved(), i).ShowDialog();
        }

        private void buttonDailyInputWizard_Click(object sender, EventArgs e)
        {
            new DailyInputWizard().ShowDialog();
        }
    }
}
