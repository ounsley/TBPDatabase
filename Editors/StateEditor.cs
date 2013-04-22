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

namespace TBPDatabase.Editors
{
    public partial class StateEditor<T, S> : Form
        where T : IIndividualState<S>, new()
        where S : IReference
    {
        TroopVisitSelector tvs;
        T state;
        Individual individual;
        TroopVisit troopVisit;

        protected Padding labelMargin = new Padding(3, 6, 3, 0);

        protected TableLayoutPanel TableLayoutPanel
        {
            get { return this.tableLayoutPanel2; }
        }
        protected int InsertRowIndex = 2;

        public T State
        {
            get { return state; }
        }

        public StateEditor(ISession session, Individual individual, T _state, string stateSelectQuery, bool currentTroopVisitsOnly = true)
        {
            InitializeComponent();

            this.individual = individual;
            if (currentTroopVisitsOnly)
                this.tvs = new TroopVisitSelector(individual.CurrentTroop());
            else
                this.tvs = new TroopVisitSelector();

            // Get the list of states
            this.comboBoxState.DataSource = session
                .CreateQuery(stateSelectQuery)
                .List<S>();

            if (_state != null)
            {
                this.state = _state;
                //this.individualReproductiveStateBindingSource.DataSource = state;
                this.troopVisit = state.TroopVisit;
                this.labelTroopVisit.Text = state.TroopVisit.ToString();
                this.comboBoxState.SelectedItem = state.State;

                this.textBoxComments.Text = state.Comments;
            }
            else
            {
                // Set some defaults values
                this.state = new T();
                this.state.Individual = individual;
                //this.timeDateTimePicker.Value = DateTime.Today;

                // We cannot set all the values so do not let
                // user hit ok for now
                this.buttonOk.Enabled = false;
            }
            this.labelStateDescription.Text = ((S)comboBoxState.SelectedValue).Description;

            // hook up cotrol validation
            this.comboBoxState.SelectedValueChanged += new EventHandler(StateChangedEventHandler);

            ValidEntry();

        }

        void StateChangedEventHandler(object sender, EventArgs e)
        {
            this.labelStateDescription.Text = ((S)comboBoxState.SelectedValue).Description;
            ValidEntry();
        }

        private bool ValidEntry()
        {
            bool valid = this.troopVisit != null &&
                this.individual != null &&
                this.comboBoxState.SelectedItem != null;

            if (valid)
                this.buttonOk.Enabled = true;
            else
                this.buttonOk.Enabled = false;
            return valid;
        }

        private void buttonTroopVisistSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = tvs.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.labelTroopVisit.Text = tvs.TroopVisit.ToString();
                this.troopVisit = tvs.TroopVisit;
            }
            ValidEntry();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.state.TroopVisit = troopVisit;
            //this.state.Time = timeDateTimePicker.Value;
            this.state.State = (S)comboBoxState.SelectedItem;
            this.state.Comments = textBoxComments.Text;
            this.state.Individual = individual;
            this.SetAdditionalValues();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }

        protected virtual void SetAdditionalValues()
        {
        }
    }
}
