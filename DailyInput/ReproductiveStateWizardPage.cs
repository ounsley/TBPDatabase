using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using NHibernate;
using TBPDatabase.Utilities;
using NHibernate.Transform;

namespace TBPDatabase.DailyInput
{
    public partial class ReproductiveStateWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;

        SortableBindingList<IndividualReproductiveState> boundReproductiveStates = new SortableBindingList<IndividualReproductiveState>();
        List<IndividualReproductiveState> initialReproductiveStates = new List<IndividualReproductiveState>();
        List<IndividualReproductiveState> todaysReproductiveStates = new List<IndividualReproductiveState>();
        List<Individual> females = new List<Individual>();

        // Cache this value
        AgeClass adult;
        ReproductiveState unknown = null;

        int currentIndex = -1;
        IndividualReproductiveState currentIrs = null;

        public bool CurrentlyValid
        {
            get { return true; }
        }

        public string Heading
        {
            get
            {
                return "Update the reproductive state of any of the females in this troop. "
                    + "Unchanged entries will be updated automaitcally.";
            }
        }

        public ReproductiveStateWizardPage()
        {
            InitializeComponent();
            if (this.ValidityChanged != null)
                this.ValidityChanged(this, null);

            this.dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            this.comboBoxState.SelectedIndexChanged += new EventHandler(comboBoxState_SelectedIndexChanged);
            this.comboBoxStateNew.SelectedIndexChanged += new EventHandler(comboBoxStateNew_SelectedIndexChanged);
        }

        void comboBoxStateNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDescriptionNew.Text = ((ReproductiveState)comboBoxStateNew.SelectedItem).Description;
        }

        void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDescriptionNew.Text = ((ReproductiveState)comboBoxState.SelectedItem).Description;
        }

        void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                currentIndex = dataGridView1.SelectedRows[0].Index;
                currentIrs = (IndividualReproductiveState)dataGridView1.Rows[currentIndex].DataBoundItem;
                this.labelIndividual.Text = currentIrs.Individual.Name;
            }
        }

        public void LoadData()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            ITransaction tx = session.BeginTransaction();

            females = Individual.LoadAllFemales(session);

            adult = session.Get<AgeClass>("A");
            unknown = session.Get<ReproductiveState>("U");

            BindingList<ReproductiveState> states = new BindingList<ReproductiveState>(session
                .CreateQuery("from ReproductiveState").List<ReproductiveState>());
            this.comboBoxState.DataSource = states;
            this.comboBoxStateNew.DataSource = new BindingList<ReproductiveState>(states);

            // Get troop visit before this date
            TroopVisit mostRecentTroopVisit = session
                    .CreateQuery("select tv from TroopVisit as tv " +
                    "left join fetch tv.Troop as t " +
                //"left join fetch tv.Observers " +
                    "where t.TroopID = :troopID and " +
                    "tv.Date < :date " +
                    "order by tv.Date desc")
                    .SetParameter<string>("troopID", DailyData.Current.TroopVisit.Troop.TroopID)
                    .SetParameter<DateTime>("date", DailyData.Current.TroopVisit.Date.Date)
                    .SetMaxResults(1)
                    .UniqueResult<TroopVisit>();

            // If we have a previous troop visit date, then lets get all the 
            // previous reproductive states
            if (mostRecentTroopVisit != null)
            {
                initialReproductiveStates = (List<IndividualReproductiveState>)session
                .CreateQuery("select r from IndividualReproductiveState as r " +
                "left join fetch r.TroopVisit as tv " +
                "left join fetch tv.Observers " +
                "where tv = :troopVisit ")
                .SetParameter<TroopVisit>("troopVisit", mostRecentTroopVisit)
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .List<IndividualReproductiveState>();
            }

            List<IndividualReproductiveState> tempReproductivestateList = new List<IndividualReproductiveState>(initialReproductiveStates);

            // Lets also get all the current ones for today, if they are already entered
            if (DailyData.Current.RetrievedData)
            {
                todaysReproductiveStates = (List<IndividualReproductiveState>)session
                    .CreateQuery("select r from IndividualReproductiveState as r " +
                    "left join fetch r.TroopVisit as tv " +
                    "left join fetch tv.Observers " +
                    "where tv = :troopVisit ")
                    .SetParameter<TroopVisit>("troopVisit", DailyData.Current.TroopVisit)
                    .SetResultTransformer(new DistinctRootEntityResultTransformer())
                    .List<IndividualReproductiveState>();

                // List todays entries if there are any
                foreach (IndividualReproductiveState s in todaysReproductiveStates)
                {
                    bool replacement = false;
                    for (int i = 0; i < todaysReproductiveStates.Count; i++)
                    {
                        if (tempReproductivestateList[i].Individual.ID == s.Individual.ID)
                        {
                            tempReproductivestateList[i] = s;
                            replacement = true;
                            break;
                        }
                    }
                    if (!replacement)
                    {
                        tempReproductivestateList.Add(s);
                    }
                }
            }

            tx.Commit();

            females = females.FindAll(new Predicate<Individual>(x =>
                    x.CurrentTroop(DailyData.Current.TroopVisit.Date) != null &&
                     x.CurrentTroop(DailyData.Current.TroopVisit.Date).TroopID == DailyData.Current.TroopVisit.Troop.TroopID));

            // Add any new individuals from previous page
            females.AddRange(DailyData.Current.NewIndividuals.FindAll(
                new Predicate<Individual>(x =>
                    x.Sex == Individual.SexEnum.F)));

            // Remove females who already have entries
            foreach (IndividualReproductiveState irs in tempReproductivestateList)
            {
                int index = females.FindIndex(new Predicate<Individual>(x =>
                    x.ID == irs.Individual.ID));
                if (index >= 0)
                    females.RemoveAt(index);
            }


            if (females.Count == 0)
            {
                this.comboBoxFemales.Enabled = false;
                this.buttonAdd.Enabled = false;
                this.comboBoxStateNew.Enabled = false;
            }
            else
                this.comboBoxFemales.DataSource = females;

            // Set missing individuals to unknown automatically
            // Check to see if the individual was not seen today, replace with unknown if so
            for (int i = 0; i < tempReproductivestateList.Count; i++)
            {
                IndividualReproductiveState current = tempReproductivestateList[i];

                // We do not need to replace exising unknow entries for today
                if (current.State != unknown &&
                    current.TroopVisit.Date.Date != DailyData.Current.TroopVisit.Date.Date &&
                    DailyData.Current.MissingToday.FindIndex(
                    x => x.ID == current.Individual.ID) > -1)
                {
                    IndividualReproductiveState irs = new IndividualReproductiveState();
                    irs.TroopVisit = DailyData.Current.TroopVisit;
                    irs.Individual = current.Individual;
                    irs.State = unknown;
                    irs.Comments = "AUTOMATICALLY GENERATED ENTRY :- Not seen on this troop visit.";
                    tempReproductivestateList[i] = irs;
                }
            }

            // Finally lets remove any individuals who have been listed as migrated
            // fropm the list
            foreach (Individual i in DailyData.Current.MigratedToday)
            {
                int index = tempReproductivestateList.FindIndex(x => x.Individual.ID == i.ID);
                if (index >= 0)
                {
                    tempReproductivestateList.RemoveAt(index);
                }
            }

            this.boundReproductiveStates = new SortableBindingList<IndividualReproductiveState>(tempReproductivestateList);
            this.dataGridView1.DataSource = boundReproductiveStates;

            FinishedLoading(this, null);
        }

        public bool Finish()
        {
            // We need to add a new entry foreach individual.
            foreach (IndividualReproductiveState s in boundReproductiveStates)
            {

                // If no change has been made, automatically generate an entry
                if (s.TroopVisit.ID != DailyData.Current.TroopVisit.ID)
                {
                    IndividualReproductiveState irs = new IndividualReproductiveState();
                    irs.TroopVisit = DailyData.Current.TroopVisit;
                    irs.Individual = s.Individual;


                    irs.State = s.State;
                    irs.Comments = "AUTOMATICALLY GENERATED ENTRY :- No Change.";
                    DailyData.Current.NewReproductiveStates.Add(irs);
                }
                else if (s.ID == 0) // Add the updated entry to the list if it is new
                {
                    DailyData.Current.NewReproductiveStates.Add(s);
                }
            }
            return true;
        }

        public void Selected()
        {
            dataGridView1_SelectionChanged(this, null);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IndividualReproductiveState irs = new IndividualReproductiveState();
            irs.Individual = (Individual)comboBoxFemales.SelectedItem;
            irs.TroopVisit = DailyData.Current.TroopVisit;
            irs.State = (ReproductiveState)comboBoxStateNew.SelectedItem;
            irs.Comments = textBoxCommentsNew.Text;

            foreach (IndividualReproductiveState x in boundReproductiveStates)
            {
                if (x.Individual.ID == irs.Individual.ID)
                {
                    MessageBox.Show("This " + irs.Individual.Name + " already has an entry in the list. " +
                "Update the individuals detail with the 'Update' control.");
                    return;
                }
            }

            // Is this female already listed as Adult?
            if (irs.Individual.CurrentAgeClass() == null ||
                irs.Individual.CurrentAgeClass(DailyData.Current.TroopVisit.Date).AgeClass.ID != adult.ID)
            {
                MessageBox.Show("This " + irs.Individual.Name + " is not current listed as adult. " +
                    "A an entry will be created to change her age class to 'A'");

                IndividualAgeClass iac = new IndividualAgeClass();
                iac.AgeClass = adult;
                iac.TroopVisit = DailyData.Current.TroopVisit;
                iac.Individual = irs.Individual;
                iac.Comments = "AUTOMATICALLY GENERATED ENTRY :- Age class changed to adult on observation of " +
                    " start of first reproductive cycle.";

                DailyData.Current.NewAgeClass.Add(iac);
            }

            DailyData.Current.NewReproductiveStates.Add(irs);
            boundReproductiveStates.Add(irs);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0)
            {
                // Overwrite the selected item with the
                // specified values in the control
                IndividualReproductiveState irs = new IndividualReproductiveState();
                irs.Individual = currentIrs.Individual;
                irs.State = (ReproductiveState)comboBoxState.SelectedItem;
                irs.TroopVisit = DailyData.Current.TroopVisit;
                irs.Comments = textBoxComments.Text;

                boundReproductiveStates[currentIndex] = irs;
            }
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0)
            {
                // Remove the selected value, replacing it with the old
                // value if there is one
                int index = initialReproductiveStates.FindIndex(
                    new Predicate<IndividualReproductiveState>(x =>
                        x.Individual.ID == currentIrs.Individual.ID));

                if (index >= 0)
                {
                    boundReproductiveStates[currentIndex] = initialReproductiveStates[index];
                }
                else
                {
                    boundReproductiveStates.RemoveAt(currentIndex);
                }
            }


        }

    }
}
