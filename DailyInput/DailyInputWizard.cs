using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Domain;
using NHibernate;
using TBPDatabase.Repositories;

namespace TBPDatabase.DailyInput
{

    public partial class DailyInputWizard : Form
    {
        IWizardPage currentPage;

        Dictionary<Step, IWizardPage> pages;
        System.Diagnostics.Stopwatch t;
        bool initialLoad = true;

        public enum Step
        {
            TroopVisitSelection,
            TroopVisitDetails,
            MissingIndividuals,
            ForeignIndividualSightings,
            NewIndividuals,
            ReproductiveStates,
            Summary,
        }

        public DailyInputWizard()
        {
            InitializeComponent();

            NHibernateHelper.OpenNewSession();

            this.pages = new Dictionary<Step, IWizardPage>();
            this.pages.Add(Step.TroopVisitSelection, this.troopVisitSelectionWizardPage1);
            this.pages.Add(Step.TroopVisitDetails, this.troopVisitWizardPage);
            this.pages.Add(Step.MissingIndividuals, this.uncertainIndividualsWizardPage1);
            this.pages.Add(Step.ForeignIndividualSightings, this.foreignIndividualSightingWizardPage1);
            this.pages.Add(Step.NewIndividuals, this.newIndividualsWizardPage1);
            this.pages.Add(Step.ReproductiveStates, this.reproductiveStateWizardPage1);
            this.pages.Add(Step.Summary, this.summaryWizardPage);

            foreach (IWizardPage page in pages.Values)
            {
                page.ValidityChanged += new EventHandler(currentPage_ValidityChanged);
                page.FinishedLoading += new EventHandler(page_FinishedLoading);
            }

            this.currentPage = GetCurrentPage();
            this.labelHeading.Text = currentPage.Heading;
            this.FormClosing += new FormClosingEventHandler(DailyInputWizard_FormClosing);

            // Initialy we want start, once the troop visit is selected
            // we should not allow return to the selection
            this.buttonBack.Visible = false;
            this.buttonNext.Text = "Start";

            t = new System.Diagnostics.Stopwatch();
            t.Start();
            this.currentPage.LoadData();

        }

        void page_FinishedLoading(object sender, EventArgs e)
        {
            t.Stop();
            // Update load time
            labelLoadTime.Text = t.Elapsed.Seconds.ToString() + "." + t.Elapsed.Milliseconds.ToString() + " s";

            // Make the cursor work
            Cursor.Current = Cursors.Default;

            // Enable next button if valid
            if (currentPage.CurrentlyValid)
                this.buttonNext.Enabled = true;
            else
                this.buttonNext.Enabled = false;

            // Set the heading for this page
            this.labelHeading.Text = currentPage.Heading;

            // Finished loading so display next page if we are not loading
            // the start
            if (!initialLoad)
            {
                this.wizardTabControl.NextPage();
                this.currentPage.Selected();

                //REMOVE BACK BUTTON FOR NOW

                // Make the back button visible but ...
                //if (!buttonBack.Visible)
                    //this.buttonBack.Visible = true;

                // ... do not allow going back to the troop selection page
                if (this.GetCurrentStep() == Step.TroopVisitDetails)
                    this.buttonBack.Enabled = false;
                else
                    this.buttonBack.Enabled = true;

                // Are we on the summary page?
                if (this.GetCurrentStep() == Step.Summary)
                    this.buttonNext.Text = "Finish";
                else
                    this.buttonNext.Text = "Next";

                // Set the troop visit label now that it is selected
                if (DailyData.Current != null && DailyData.Current.TroopVisit != null)
                    this.labelCurrentTroopVisit.Text = DailyData.Current.TroopVisit.ToString();
            }

            // Highlight the progress heading
            HighlightCurrentStep();

            // We have loaded start page so ...
            initialLoad = false;
        }

        private void HighlightCurrentStep()
        {
            string labelName = "labelStep" + (int)GetCurrentStep();

            foreach (Control c in flowLayoutPanelSteps.Controls)
            {
                if (c.Name == labelName)
                    c.Font = new System.Drawing.Font("Microsoft Sans Serif",9.75f,System.Drawing.FontStyle.Bold);
                else
                    c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            }
        }

        void DailyInputWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // A bit of tidying up
            Cursor.Current = Cursors.Default;
            DailyData.Current.Dispose();
            NHibernateHelper.DisposeCurrentSession();

        }

        void currentPage_ValidityChanged(object sender, EventArgs e)
        {
            if (currentPage.CurrentlyValid)
                this.buttonNext.Enabled = true;
            else
                this.buttonNext.Enabled = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.currentPage.Finish();

            // Have we finished the summary?
            if (this.GetCurrentStep() == Step.Summary)
            {
                // If we are on the summary we should close
                this.Close();
            }

            //Application.UseWaitCursor = true;
            Cursor.Current = Cursors.WaitCursor;
            t = new System.Diagnostics.Stopwatch();
            //this.Enabled = false;

            // If next page exists, load the data
            if (GetNextPage() != null)
            {
                this.currentPage = GetNextPage();
                t.Start();
                this.currentPage.LoadData();
            }
            else // Cloase ( should be end of wizard)
                this.Close();
        }

        private IWizardPage GetCurrentPage()
        {
            return pages[(Step)this.wizardTabControl.SelectedIndex];
        }

        private IWizardPage GetNextPage()
        {
            int currentIndex = this.wizardTabControl.SelectedIndex;
            int nextIndex = currentIndex + 1;
            if (this.wizardTabControl.TabCount >= nextIndex + 1)
            {
                return pages[(Step)nextIndex];
            }

            return null;
        }


        private Step GetCurrentStep()
        {
            return (Step)this.wizardTabControl.SelectedIndex;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.wizardTabControl.PreviousPage();
            this.buttonNext.Text = "Next";
            this.currentPage = GetCurrentPage();
            // Do not allow going back to the troop selection page
            if (this.GetCurrentStep() == Step.TroopVisitDetails)
                this.buttonBack.Enabled = false;
            else
                this.buttonBack.Enabled = true;
        }
    }
}
