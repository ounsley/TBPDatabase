using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TBPDatabase.Utilities;
using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using NHibernate;

namespace TBPDatabase.DailyInput
{
    public partial class NewIndividualsWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;

        SortableBindingList<Individual> newIndividuals;

        List<Individual> todaysIndividuals = new List<Individual>();
        List<Individual> individualList;

        public bool CurrentlyValid
        {
            get { return true; }
        }

        public string Heading
        {
            get { return "Specify the details of any entirely new individuals seen on todays troop visit."; }
        }

        public NewIndividualsWizardPage()
        {
            InitializeComponent();
            if (this.ValidityChanged != null)
                this.ValidityChanged(this, null);

            SortableBindingList<Individual> newIndividuals = new SortableBindingList<Individual>();
            this.dataGridViewNewIndividuals.DataSource = newIndividuals;

            this.comboBoxSighting.SelectedValueChanged += new EventHandler(comboBoxSighting_SelectedValueChanged);
            //this.comboBoxAgeClass.SelectedValueChanged += new EventHandler(comboBoxAgeClass_SelectedValueChanged);

            this.textBoxName.TextChanged += new EventHandler(ValidityCheck);
            this.comboBoxSex.SelectedValueChanged += new EventHandler(ValidityCheck);
            this.comboBoxAgeClass.SelectedValueChanged += new EventHandler(ValidityCheck);
            this.comboBoxSighting.SelectedValueChanged += new EventHandler(ValidityCheck);

            this.dateTimePickerActualDOB.Checked = false;
            this.dateTimePickerFieldDOB.Checked = false;

            this.checkBoxMotherUnknown.CheckedChanged += new EventHandler(checkBoxMotherUnknown_CheckedChanged);

        }

        void checkBoxMotherUnknown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMotherUnknown.Checked)
                this.comboBoxMother.Enabled = false;
            else
                this.comboBoxMother.Enabled = true;
        }

        public void LoadData()
        {
            // Copy any new individuals already listed for addition,
            // then set data grid view binding source
            this.newIndividuals = new SortableBindingList<Individual>(DailyData.Current.NewIndividuals);
            this.dataGridViewNewIndividuals.DataSource = newIndividuals;

            ISession session = NHibernateHelper.GetCurrentSession();
            ITransaction tx = session.BeginTransaction();

            // Get a list of individuals
            this.individualList = Individual.LoadAll(session);

            // Just want the adult females
            this.comboBoxMother.DataSource = individualList
                .FindAll(new Predicate<Individual>(x =>
                    x.Sex == Domain.Individual.SexEnum.F));

            // Get any new individuals for today
            if (DailyData.Current.RetrievedData)
            {
                todaysIndividuals = (List<Individual>)session
                    .CreateQuery("select i from IndividualSighting as s " +
                    "left join s.Individual as i " +
                    "where s.TroopVisit = :troopVisit " +
                    "and (s.Sighting.ID = 'B' or s.Sighting.ID = 'S')")
                    .SetParameter<TroopVisit>("troopVisit", DailyData.Current.TroopVisit)
                    .List<Individual>();
            }

            // Fill combo boxes
            BindingList<Individual.SexEnum> sexEnumList = new BindingList<Individual.SexEnum>();
            sexEnumList.Add(Individual.SexEnum.M);
            sexEnumList.Add(Individual.SexEnum.F);

            this.comboBoxSex.DataSource = sexEnumList;

            this.comboBoxAgeClass.DataSource = session
                .CreateQuery("select a from AgeClass as a")
                .List<AgeClass>();

            // What are the options here?
            // Day to day this should only really be B or S
            // should we allow IN ?
            this.comboBoxSighting.DataSource = session
                .CreateQuery("select t from Sighting as t " +
                "where ID = 'B' or ID = 'S'")
                .List<Sighting>();

            tx.Commit();

            foreach (Individual i in todaysIndividuals)
            {
                if (i.FirstSighting().TroopVisit.ID == DailyData.Current.TroopVisit.ID)
                    this.newIndividuals.Add(i);
            }

            this.FinishedLoading(this, null);

        }

        void ValidityCheck(object sender, EventArgs e)
        {
            // Check that the minimum information is entered
            // amongst other things
            bool valid = true;

            // Minimum data
            // An ID is entered
            //valid &= this.textBoxTrappingID.Text.Length > 0;
            // A name of at least length 1
            valid &= this.textBoxName.Text.Length > 0;
            // A sex is selected
            valid &= this.comboBoxSex.SelectedItem != null;
            // An Age class is selected
            valid &= this.comboBoxAgeClass.SelectedValue != null;
            // An initial sighting is entered
            valid &= this.comboBoxSighting.SelectedValue != null;

            if (valid)
                this.buttonAdd.Enabled = true;
            else
                this.buttonAdd.Enabled = false;


        }

        void comboBoxSighting_SelectedValueChanged(object sender, EventArgs e)
        {
            //this.labelSightingDescription.Text =
            //  ((Sighting)comboBoxSighting.SelectedValue).Description;

            // If the individual has had their birth observed,
            // they must be an infant, and Actual dob must be the troop visit value
            if (((Sighting)comboBoxSighting.SelectedValue).ID == "B")
            {
                this.comboBoxAgeClass.SelectedIndex = comboBoxAgeClass.FindString("INF");
                this.dateTimePickerActualDOB.Value = DailyData.Current.TroopVisit.Date;
                this.dateTimePickerActualDOB.Checked = true;
            }
            else
            {
                // Otherwise lets uncheck the date, just incase
                this.dateTimePickerActualDOB.Checked = false;
            }
        }

        public bool Finish()
        {
            // Add the individuals
            foreach (Individual i in newIndividuals)
                DailyData.Current.NewIndividuals.Add(i);
            return true;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            // Do some final checks and create a new individual and 
            // add it to the list.
            Individual newIndividual = new Individual();
            newIndividual.Name = textBoxName.Text;
            newIndividual.Sex = (Individual.SexEnum)comboBoxSex.SelectedItem;
            if (dateTimePickerActualDOB.Checked)
                newIndividual.ActualDOB = dateTimePickerActualDOB.Value.Date;
            if (dateTimePickerFieldDOB.Checked)
                newIndividual.FieldEstimatedDOB = dateTimePickerFieldDOB.Value.Date;
            newIndividual.Comment = textBoxComments.Text;
            newIndividual.IDNote = textBoxIDNotes.Text;
            if (!checkBoxMotherUnknown.Checked)
                newIndividual.Mother = (Individual)comboBoxMother.SelectedItem;

            // We need to check the IDs of both the current and new individuals
            // to generate and id so create a new list with all the indiviudals
            List<Individual> newAndCurrent = new List<Individual>(individualList);
            newAndCurrent.AddRange(this.newIndividuals);
            newIndividual.ID = Individual.GenerateNewId(newAndCurrent,
                DailyData.Current.TroopVisit, newIndividual.Sex);

            // We need to create initial individual sighting and ageclass entries
            IndividualSighting s = new IndividualSighting();
            s.Individual = newIndividual;
            s.Comments = this.textBoxComments.Text;
            s.Sighting = (Sighting)this.comboBoxSighting.SelectedValue;
            s.TroopVisit = DailyData.Current.TroopVisit;
            newIndividual.SightingHistory.Add(s);

            IndividualAgeClass a = new IndividualAgeClass();
            a.AgeClass = (AgeClass)this.comboBoxAgeClass.SelectedValue;
            a.TroopVisit = DailyData.Current.TroopVisit;
            a.Individual = newIndividual;
            a.Comments = textBoxComments.Text;
            newIndividual.AgeClassHistory.Add(a);

            // Add to binding list
            this.newIndividuals.Add(newIndividual);

            // Also add to list of Individuals for 
            // id code updating
            this.individualList.Add(newIndividual);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewNewIndividuals.SelectedRows.Count > 0)
            {
                int index = dataGridViewNewIndividuals.SelectedRows[0].Index;

                // Remove from the list of individuals and the list of new individuals
                // to add and if persistent add to delete list
                string id = this.newIndividuals[index].ID;

                // Id contained in todaysIndividuals then it is persistent
                // so add to delete list and remove from todays individuals list?
                if (todaysIndividuals.Exists(x => x.ID == id))
                {
                    int index3 = todaysIndividuals.FindIndex(x => x.ID == id);
                    DailyData.Current.IndividualsToDelete.Add(todaysIndividuals[index3]);
                    todaysIndividuals.RemoveAt(index3);
                }

                int index2 = individualList.FindIndex(x => x.ID == id);
                this.individualList.RemoveAt(index2);
                this.newIndividuals.RemoveAt(index);

            }
        }

        public void Selected()
        {
        }

    }
}
