using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Collections.Generic;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using NHibernate;
using TBPDatabase.Utilities;

namespace TBPDatabase.SessionForms
{
    public partial class FormIndividualSearch : SessionForm
    {
        Individual individual;

        public Individual Individual
        {
            get { return this.individual; }
        }


        public FormIndividualSearch()
        {
            InitializeComponent();

            // Set auto resize options
            this.ResizeRedraw = true;
            this.buttonOk.Enabled = false;
            this.AcceptButton = buttonFind;
            this.dataGridViewSearchResults.SelectionChanged += new EventHandler(dataGridViewSearchResults_SelectionChanged);
        }

        void dataGridViewSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            this.buttonOk.Enabled = true;
            this.AcceptButton = buttonOk;
        }

        void FindIndividual()
        {
            this.dataGridViewSearchResults.Rows.Clear();
            
            /// TO DO
            /// Use a sortabale binding list here

            IQuery query = Session
                .CreateQuery("select ind.ID, ind.Name from Individual as ind where name like :name")
                .SetParameter("name", this.textBoxName.Text+"%");

            foreach (object[] results in query.Enumerable())
            {
                this.dataGridViewSearchResults.Rows.Add(results);
            }

            if (this.dataGridViewSearchResults.Rows.Count == 0)
                this.buttonOk.Enabled = false;
        }

        void LoadIndividual(string ID)
        {
            this.individual = Session.Get<Individual>(ID);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindIndividual();
        }

        private void dataGridViewSearchResults_DoubleClick(object sender, EventArgs e)
        {
            buttonOk_Click(sender, e);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            LoadIndividual(this.dataGridViewSearchResults.SelectedRows[0].Cells["ColumnID"].Value.ToString());
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        

    }
}
