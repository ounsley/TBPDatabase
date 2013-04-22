using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NHibernate;
using TBPDatabase.Domain;
using TBPDatabase.SessionForms;
using NHibernate.Transform;
using TBPDatabase.Utilities;

namespace TBPDatabase.Editors
{
    public partial class IndividualEditor : SessionForm
    {
        TroopVisit troopVisitFirstObserved;
        Individual individual;
        List<Individual> individuals;
        bool isNew;

        public Individual Individual
        {
            get { return individual; }
        }

        public IndividualEditor(TroopVisit troopVisitFirstObserved, Individual individual = null)
        {
            InitializeComponent();
            this.troopVisitFirstObserved = troopVisitFirstObserved;

            // Fill combo boxes
            this.comboBoxSex.Items.Add(Individual.SexEnum.M);
            this.comboBoxSex.Items.Add(Individual.SexEnum.F);

            this.comboBoxAgeClass.DataSource = Session
                .CreateQuery("select a from AgeClass as a")
                .List<AgeClass>();

            this.comboBoxSighting.DataSource = Session
                .CreateQuery("select t from Sighting as t " +
                "where Observed = 1")
                .List<Sighting>();

            this.individuals = Individual.LoadAll(Session);

            // Just want the females
            this.comboBoxMother.DataSource = individuals
                .FindAll(new Predicate<Individual>(x => x.Sex == Domain.Individual.SexEnum.F));

            if (individual != null)
            {
                isNew = false;
                // set values for the control from the individual
                this.individual = Session.Get<Individual>(individual.ID);
                this.bindingSourceIndividual.DataSource = Individual;
                this.comboBoxSex.SelectedItem = Individual.Sex;
                if (Individual.FirstAgeClass() != null)
                    this.comboBoxAgeClass.SelectedItem = Individual
                        .FirstAgeClass().AgeClass;
                this.comboBoxSighting.SelectedItem = Individual
                    .FirstSighting().Sighting;
                this.comboBoxMother.SelectedItem = Individual
                    .Mother;

                // Set the descriptions
                this.labelSightingDescription.Text =
                    ((Sighting)comboBoxSighting.SelectedValue).Description;
                this.labelAgeClassDescription.Text =
                    ((AgeClass)comboBoxAgeClass.SelectedValue).Description;
            }
            else
            {
                isNew = true;
                // create a new individual
                this.individual = new Individual();
                this.bindingSourceIndividual.DataSource = individual;

                // Clear the combo boxes
                this.comboBoxMother.SelectedIndex = -1;
                this.comboBoxSighting.SelectedIndex = -1;
                this.comboBoxAgeClass.SelectedIndex = -1;

            }


            this.comboBoxSighting.SelectedValueChanged += new EventHandler(comboBoxSighting_SelectedValueChanged);
            this.comboBoxAgeClass.SelectedValueChanged += new EventHandler(comboBoxAgeClass_SelectedValueChanged);

            this.textBoxName.TextChanged += new EventHandler(ValidityCheck);
            this.comboBoxSex.SelectedValueChanged += new EventHandler(ValidityCheck);
            this.comboBoxAgeClass.SelectedValueChanged += new EventHandler(ValidityCheck);
            this.comboBoxSighting.SelectedValueChanged += new EventHandler(ValidityCheck);
            this.textBoxTrappingID.TextChanged +=new EventHandler(ValidityCheck);
        }

        void ValidityCheck(object sender, EventArgs e)
        {
            // Check that the minimum information is entered
            // amongst other things
            bool valid = true;

            // Minimum data
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
                this.buttonOk.Enabled = true;
            else
                this.buttonOk.Enabled = false;


        }

        void comboBoxAgeClass_SelectedValueChanged(object sender, EventArgs e)
        {
            this.labelAgeClassDescription.Text =
                ((AgeClass)comboBoxAgeClass.SelectedValue).Description;
        }

        bool checkIDValidity(List<Individual> individuals, TroopVisit troopVisit, Individual.SexEnum sex, string ID)
        {
            bool valid = true;
            int dummy = 0;
            // Valid if of form troopid + sex + number, length 4 and not already in use
            valid &= ID.StartsWith(troopVisit.Troop.TroopID + sex.ToString()) || ID.StartsWith(troopVisit.Troop.TroopID + sex.ToString());
            valid &= int.TryParse(ID.Substring(2, 2), out dummy);
            valid &= ID.Length == 4;

            //foreach (Individual i in individuals)
            //{
            //    if (i.ID == ID)
            //        valid = false;
            //}
            return valid;
        }

        void comboBoxSighting_SelectedValueChanged(object sender, EventArgs e)
        {
            this.labelSightingDescription.Text =
                ((Sighting)comboBoxSighting.SelectedValue).Description;

            // If the individual has had their birth observed,
            // they must be an infant, and Actual dob must be the troop visit value
            if (((Sighting)comboBoxSighting.SelectedValue).ID == "B")
            {
                this.comboBoxAgeClass.SelectedIndex = comboBoxAgeClass.FindString("INF");
                this.dateTimePickerActualDOB.Value = troopVisitFirstObserved.Date;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBoxSex.SelectedItem != null)
            {
                this.textBoxTrappingID.Text = Individual.GenerateNewTrappingId(individuals, troopVisitFirstObserved,
                    (Individual.SexEnum)comboBoxSex.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a sex for the new individual in order to generate an ID"
                    , "Insufficient data"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // We need to do some final checks here, namely the free form
            // text fields.

            // Check that the ID is valid
            //if (!this.checkIDValidity(individuals, this.troopVisitFirstObserved,
              //  (Individual.SexEnum)this.comboBoxSex.SelectedItem,
                //this.textBoxTrappingID.Text))
            //{
              //  MessageBox.Show("The trapping ID that has been enter is not valid. It must a 4 digit code of the form:\r" +
                //    "Troop ID of first observation + Sex + Digit + Digit"
                  //  , "Invalid Trapping ID"
                  //  , MessageBoxButtons.OK
                  //  , MessageBoxIcon.Error);
                //return;
            //}

            // Check that the name is valid
            if (this.textBoxName.Text.Length < 1 || this.textBoxName.Text.Length > 45)
            {
                MessageBox.Show("The Name that has been enter is too long. It must be less than 44 digits long"
                    , "Invalid Name"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            // Check the IDNote is valid
            if (this.textBoxIDNotes.Text.Length > 200)
            {
                MessageBox.Show("The ID Note that has been enter is too long. It must be less than 200 digits long"
                    , "Invalid ID Note"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            // Check the Comment is valid
            if (this.textBoxIDNotes.Text.Length > 200)
            {
                MessageBox.Show("The Comment that has been enter is too long. It must be less than 200 digits long"
                    , "Invalid Comment"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            // Assign the values that were not bound
            individual.Sex = (Individual.SexEnum)this.comboBoxSex.SelectedItem;
            individual.TrappingID = this.textBoxTrappingID.Text;
            individual.Name = textBoxName.Text;
            //Session.SaveOrUpdate();

            if (isNew)
            {
                // We need to create initial individual sighting and ageclass entries
                IndividualSighting s = new IndividualSighting();
                s.Individual = this.individual;
                s.Comments = this.textBoxComments.Text;
                s.Sighting = (Sighting)this.comboBoxSighting.SelectedValue;
                s.TroopVisit = this.troopVisitFirstObserved;
                this.individual.SightingHistory.Add(s);

                IndividualAgeClass a = new IndividualAgeClass();
                a.AgeClass = (AgeClass)this.comboBoxAgeClass.SelectedValue;
                a.TroopVisit = this.troopVisitFirstObserved;
                a.Individual = this.individual;
                a.Comments = textBoxComments.Text;
                this.individual.AgeClassHistory.Add(a);
            }
            Session.SaveOrUpdate(individual);


            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void IndividualEditor_Load(object sender, EventArgs e)
        {

        }

    }
}
