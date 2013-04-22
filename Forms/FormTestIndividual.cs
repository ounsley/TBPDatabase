using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using TBPDatabase.Controls;
using TBPDatabase.MainInterface;

namespace TBPDatabase.Forms
{
    public partial class FormTestIndividual : Form
    {
        public FormTestIndividual()
        {
            
            InitializeComponent();

            this.individualBindingSource.DataSource = NHibernateHelper.GetCurrentSession()
                .CreateQuery("Select i from Individual as i").List<Individual>();
            this.troopCompositionDataGridView.SetDataSource((Individual)individualBindingSource.Current);
            //this.troopCompositionDataGridView.SetBindingSource(this.individualBindingSource);
            this.individualBindingSource.CurrentChanged += new EventHandler(individualBindingSource_CurrentChanged);
        }

        void individualBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.troopCompositionDataGridView.SetDataSource((Individual)individualBindingSource.Current);
        }

    }
}
