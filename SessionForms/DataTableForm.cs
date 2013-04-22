using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Utilities;

namespace TBPDatabase.SessionForms
{
    public abstract partial class DataTableForm : SessionForm
    {
        private DataGridView dataGridView1;
        protected DataGridView DataGridView { get { return this.dataGridView1; } }

        public DataTableForm()
        {
            InitializeComponent();

            this.ShowIcon = false;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.MaximumSize = new System.Drawing.Size(600,480);

            this.dataGridView1 = new DataGridView();
            this.dataGridView1.AutoSize = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.MaximumSize = new System.Drawing.Size(600, 400);
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DoubleClick += new System.EventHandler(dataGridView1_DoubleClick);
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridView1_MouseDown);
            //this.dataGridView1.Dock = DockStyle.Top;

            Button ok = new Button();
            ok.Text = "Ok";
            ok.Click += new System.EventHandler(ok_Click);
            this.AcceptButton = ok;
            //ok.Dock = DockStyle.Bottom;

            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.Click += new System.EventHandler(cancel_Click);
            this.CancelButton = cancel;
            //cancel.Dock = DockStyle.Bottom;

            FlowLayoutPanel buttonLayout = new FlowLayoutPanel();
            buttonLayout.FlowDirection = FlowDirection.RightToLeft;
            buttonLayout.Padding = new System.Windows.Forms.Padding(3);
            buttonLayout.Controls.AddRange(new Control[] { cancel, ok });
            buttonLayout.AutoSize = true;
            buttonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonLayout.Dock = DockStyle.Right;

            FlowLayoutPanel layout = new FlowLayoutPanel();
            layout.FlowDirection = FlowDirection.TopDown;
            layout.Controls.Add(dataGridView1);
            layout.Controls.Add(buttonLayout);
            layout.AutoSize = true;
            layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            layout.Dock = DockStyle.Fill;
            this.Controls.Add(layout);

            ToolStripButton individualButton = new ToolStripButton();
            individualButton.Text = "Edit indvidual";
            individualButton.Click +=new System.EventHandler(individualButton_Click);
            this.dataGridView1.ContextMenuStrip = new ContextMenuStrip();
            this.dataGridView1.ContextMenuStrip.Items.Add(individualButton);
            this.dataGridView1.ContextMenuStrip.Items.Add(new ToolStripSeparator());

        }

        void individualButton_Click(object sender, System.EventArgs e)
        {
            if (this.dataGridView1.Columns.Contains("Individual"))
            {
                Individual individual = (Individual)this.dataGridView1.CurrentRow.Cells["Individual"].Value;
                new IndiviualForm(individual).ShowDialog();
                Session.Refresh(individual);
                this.RefreshRow(dataGridView1.CurrentRow);
            }
        }

        void cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        void ok_Click(object sender, System.EventArgs e)
        {
            OkAction();
            this.DialogResult = System.Windows.Forms.DialogResult.OK; 
            this.Close();
        }

        void dataGridView1_MouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            }
        }

        void dataGridView1_Click(object sender, System.EventArgs e)
        {
            // if(((DataGridViewCell)e).RowIndex >= 0)
            //dataGridView1.CurrentRow = e.RowIndex;
        }

        void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            // Perform the action required by the derived class.
            this.RowAction(dataGridView1.SelectedRows[0]);

            // Reload the data
            //this.LoadData();
        }

        public abstract void LoadData();
        protected abstract void RowAction(DataGridViewRow row);
        protected abstract void OkAction();
        protected abstract void RefreshRow(DataGridViewRow row);
    }
}
