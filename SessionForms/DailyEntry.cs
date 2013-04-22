using System;
using System.Windows.Forms;

using TBPDatabase.Editors;
using TBPDatabase.Domain;
using TBPDatabase.Utilities;

namespace TBPDatabase.SessionForms
{
    public partial class DailyEntry : SessionForm
    {
        enum Stage
        {
            TroopVisit, NewIndividuals, IndividualTroopSighting, ReproductiveState, Finished
        }

        TroopVisit troopVisit;

        public DailyEntry()
        {
            InitializeComponent();
            ChangeStage(Stage.TroopVisit);
        }

        // Controls what the user can do at each stage
        // of the data entry process.
        private void ChangeStage(Stage stage)
        {
            switch (stage)
            {
                case Stage.TroopVisit:
                    this.panelTroopVisit.Enabled = true;
                    this.panelNewIndividuals.Enabled = false;
                    this.panelIndividualSighting.Enabled = false;
                    this.panelReproductiveState.Enabled = false;
                    this.buttonDone.Enabled = false;
                    break;
                case Stage.NewIndividuals:
                    this.panelNewIndividuals.Enabled = true;
                    this.panelTroopVisit.Enabled = false;
                    this.panelIndividualSighting.Enabled = false;
                    this.panelReproductiveState.Enabled = false;
                    this.buttonDone.Enabled = false;
                    break;
                case Stage.IndividualTroopSighting:
                    this.panelTroopVisit.Enabled = false;
                    this.panelIndividualSighting.Enabled = true;
                    this.panelReproductiveState.Enabled = false;
                    this.buttonDone.Enabled = false;
                    break;
                case Stage.ReproductiveState:
                    this.panelTroopVisit.Enabled = false;
                    this.panelIndividualSighting.Enabled = false;
                    this.panelReproductiveState.Enabled = true;
                    this.buttonDone.Enabled = false;
                    break;
                case Stage.Finished:
                    this.buttonDone.Enabled = true;
                    break;
            }
        }

        private void buttonTroopVisit_Click(object sender, EventArgs e)
        {
            TroopVisitEditor tve = new TroopVisitEditor(Session);
            if (tve.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.troopVisit = tve.TroopVisit;
                Session.SaveOrUpdate(troopVisit);
                // Go to the next stage
                this.ChangeStage(Stage.NewIndividuals);
            }
        }

        private void buttonTroopVisitSelect_Click(object sender, EventArgs e)
        {
            TroopVisitSelector tvs = new TroopVisitSelector();
            if (tvs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.troopVisit = tvs.TroopVisit;
                ChangeStage(Stage.NewIndividuals);
            }
        }

        private void buttonIndividualSightingNew_Click(object sender, EventArgs e)
        {

            SightingChanges tcc = new SightingChanges(troopVisit);
            tcc.LoadData();
            if (tcc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeStage(Stage.ReproductiveState);
            }
        }

        private void buttonReproductiveStates_Click(object sender, EventArgs e)
        {
            ReproductiveStateChanges rsc = new ReproductiveStateChanges(troopVisit);
            rsc.LoadData();
            if (rsc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeStage(Stage.Finished);
            }
        }

        private void buttonIndividualSightingNone_Click(object sender, EventArgs e)
        {
            ChangeStage(Stage.ReproductiveState);
        }

        private void buttonReproductivestateNone_Click(object sender, EventArgs e)
        {
            ChangeStage(Stage.Finished);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndividualEditor ie = new IndividualEditor(troopVisit);
            if (ie.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Session.SaveOrUpdate(ie.Individual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeStage(Stage.IndividualTroopSighting);
        }


    }
}
