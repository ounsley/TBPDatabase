using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBPDatabase.Domain;

namespace TBPDatabase.SessionForms
{
    [System.ComponentModel.ComplexBindingProperties("DataSource", "DataMember")]
    public partial class TroopCompositionDataGridView : UserControl
    {
        BindingSource bindingSource;

        public object DataSource
        {
            get { return this.dataGridView1.DataSource; }
            set { this.dataGridView1.DataSource = value; }
        }

        public string DataMember
        {
            get { return this.dataGridView1.DataMember; }
            set { this.dataGridView1.DataMember = value; }
        }

        public TroopCompositionDataGridView()
        {
            InitializeComponent();
            this.bindingSource = new BindingSource();
        }

        public void SetBindingSource(Individual bindingSource)
        {
            this.bindingSource.DataSource = bindingSource.TroopCompositions; ;
            this.DataSource = bindingSource;
            this.DataMember = "";
        }

        public void SetDataSource(Individual dataSource)
        {
            this.bindingSource.DataSource = dataSource.TroopCompositions.ToList<TroopComposition>();
            this.DataSource = bindingSource;
        }
    }
}
