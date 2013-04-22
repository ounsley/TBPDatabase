using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using TBPDatabase.Controls;
using NHibernate;
using System.Collections.ObjectModel;

namespace TBPDatabase.Forms
{
    public partial class FormIndividual : Form
    {
        Individual individual;

        public FormIndividual(Individual individual)
        {
            this.individual = individual;
            Troop currentTroop = this.individual.CurrentTroop();

            InitializeComponent();


            this.Text = "Individual information - " + individual.ID;

            this.labelName.Text = individual.Name;
            this.labelCurrentTroop.Text = currentTroop.TroopID.ToString();
            if (individual.Sex == Individual.SexEnum.M)
                this.labelSex.Text = "Male";
            else
                this.labelSex.Text = "Female";
            this.labelIndividualId.Text = individual.ID;

            //this.tabControl1.TabPages.Add(new RelationalSetTab(individual.TroopCompositions));
            //this.tabControl1.TabPages.Add(new RelationalSetTab((Collection<PersistentObject>)individual.ReproductiveStates));

            this.SetNotches();
        }

        public FormIndividual(string ID)
            : this(NHibernateHelper.GetCurrentSession().Get<Individual>(ID))
        {
        }
        
        private void buttonTroopMembershipUpdate_Click(object sender, EventArgs e)
        {
            //new FormTroopMembershipUpdate(individualId,this.troopMembershipStartDate,this.connection).ShowDialog();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SaveAndClose();
        }

        public void SaveAndClose()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            session.SaveOrUpdate(this.individual);
            this.Close();

        }

        void SetNotches()
        {
            if (!individual.RightTop)
                this.labelRightTop.Hide();
            if (!individual.RightMiddle)
                this.labelRightMiddle.Hide();
            if (!individual.RightBottom)
                this.labelRightBottom.Hide();
            if (!individual.LeftTop)
                this.labelLeftTop.Hide();
            if (!individual.LeftMiddle)
                this.labelLeftMiddle.Hide();
            if (!individual.LeftBottom)
                this.labelLeftBottom.Hide();
        }


    }
}
