namespace TBPDatabase.DailyInput
{
    partial class MissingIndividualsWizardPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNotSeen = new System.Windows.Forms.DataGridView();
            this.sightedCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.individualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sighting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TroopVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualSightingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelIndividual = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonSeen = new System.Windows.Forms.RadioButton();
            this.radioButtonNotSeen = new System.Windows.Forms.RadioButton();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxIndividuals = new System.Windows.Forms.ComboBox();
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewComments = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSeen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualSightingBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotSeen
            // 
            this.dataGridViewNotSeen.AllowUserToAddRows = false;
            this.dataGridViewNotSeen.AllowUserToDeleteRows = false;
            this.dataGridViewNotSeen.AutoGenerateColumns = false;
            this.dataGridViewNotSeen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotSeen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotSeen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sightedCheckBoxColumn,
            this.individualDataGridViewTextBoxColumn,
            this.Sighting,
            this.TroopVisit,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridViewNotSeen.DataSource = this.individualSightingBindingSource;
            this.dataGridViewNotSeen.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewNotSeen.MultiSelect = false;
            this.dataGridViewNotSeen.Name = "dataGridViewNotSeen";
            this.dataGridViewNotSeen.RowHeadersVisible = false;
            this.dataGridViewNotSeen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotSeen.Size = new System.Drawing.Size(588, 231);
            this.dataGridViewNotSeen.TabIndex = 52;
            // 
            // sightedCheckBoxColumn
            // 
            this.sightedCheckBoxColumn.FalseValue = "0";
            this.sightedCheckBoxColumn.FillWeight = 30F;
            this.sightedCheckBoxColumn.HeaderText = "Done";
            this.sightedCheckBoxColumn.Name = "sightedCheckBoxColumn";
            this.sightedCheckBoxColumn.ReadOnly = true;
            this.sightedCheckBoxColumn.TrueValue = "1";
            // 
            // individualDataGridViewTextBoxColumn
            // 
            this.individualDataGridViewTextBoxColumn.DataPropertyName = "Individual";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.individualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.individualDataGridViewTextBoxColumn.HeaderText = "Individual";
            this.individualDataGridViewTextBoxColumn.Name = "individualDataGridViewTextBoxColumn";
            this.individualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sighting
            // 
            this.Sighting.DataPropertyName = "Sighting";
            this.Sighting.FillWeight = 40F;
            this.Sighting.HeaderText = "Sighting";
            this.Sighting.Name = "Sighting";
            this.Sighting.ReadOnly = true;
            // 
            // TroopVisit
            // 
            this.TroopVisit.DataPropertyName = "TroopVisit";
            this.TroopVisit.FillWeight = 50F;
            this.TroopVisit.HeaderText = "TroopVisit";
            this.TroopVisit.Name = "TroopVisit";
            this.TroopVisit.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            this.commentsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.commentsDataGridViewTextBoxColumn.FillWeight = 200F;
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualSightingBindingSource
            // 
            this.individualSightingBindingSource.DataSource = typeof(TBPDatabase.Domain.IndividualSighting);
            // 
            // labelIndividual
            // 
            this.labelIndividual.AutoSize = true;
            this.labelIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndividual.Location = new System.Drawing.Point(6, 24);
            this.labelIndividual.Name = "labelIndividual";
            this.labelIndividual.Size = new System.Drawing.Size(11, 13);
            this.labelIndividual.TabIndex = 60;
            this.labelIndividual.Text = "-";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(215, 121);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 59;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Comments:";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(9, 75);
            this.textBoxComments.MaxLength = 199;
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(281, 40);
            this.textBoxComments.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonSeen);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNotSeen);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(89, 53);
            this.flowLayoutPanel1.TabIndex = 56;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // radioButtonSeen
            // 
            this.radioButtonSeen.AutoSize = true;
            this.radioButtonSeen.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSeen.Name = "radioButtonSeen";
            this.radioButtonSeen.Size = new System.Drawing.Size(79, 17);
            this.radioButtonSeen.TabIndex = 0;
            this.radioButtonSeen.TabStop = true;
            this.radioButtonSeen.Text = "Seen today";
            this.radioButtonSeen.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotSeen
            // 
            this.radioButtonNotSeen.AutoSize = true;
            this.radioButtonNotSeen.Location = new System.Drawing.Point(3, 26);
            this.radioButtonNotSeen.Name = "radioButtonNotSeen";
            this.radioButtonNotSeen.Size = new System.Drawing.Size(70, 17);
            this.radioButtonNotSeen.TabIndex = 1;
            this.radioButtonNotSeen.TabStop = true;
            this.radioButtonNotSeen.Text = "Not Seen";
            this.radioButtonNotSeen.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.labelIndividual);
            this.groupBoxEdit.Controls.Add(this.textBoxComments);
            this.groupBoxEdit.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxEdit.Controls.Add(this.label1);
            this.groupBoxEdit.Controls.Add(this.buttonUpdate);
            this.groupBoxEdit.Location = new System.Drawing.Point(6, 243);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(296, 151);
            this.groupBoxEdit.TabIndex = 61;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Update Individual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxIndividuals);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNewComments);
            this.groupBox1.Location = new System.Drawing.Point(308, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 151);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Foreign Individual";
            // 
            // comboBoxIndividuals
            // 
            this.comboBoxIndividuals.DataSource = this.individualBindingSource;
            this.comboBoxIndividuals.FormattingEnabled = true;
            this.comboBoxIndividuals.Location = new System.Drawing.Point(9, 35);
            this.comboBoxIndividuals.Name = "comboBoxIndividuals";
            this.comboBoxIndividuals.Size = new System.Drawing.Size(153, 21);
            this.comboBoxIndividuals.TabIndex = 63;
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(TBPDatabase.Domain.Individual);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Individual:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(205, 121);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 61;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Comments:";
            // 
            // textBoxNewComments
            // 
            this.textBoxNewComments.Location = new System.Drawing.Point(6, 75);
            this.textBoxNewComments.MaxLength = 199;
            this.textBoxNewComments.Multiline = true;
            this.textBoxNewComments.Name = "textBoxNewComments";
            this.textBoxNewComments.Size = new System.Drawing.Size(274, 40);
            this.textBoxNewComments.TabIndex = 61;
            // 
            // MissingIndividualsWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.dataGridViewNotSeen);
            this.Name = "MissingIndividualsWizardPage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSeen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualSightingBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotSeen;
        private System.Windows.Forms.BindingSource individualSightingBindingSource;
        private System.Windows.Forms.Label labelIndividual;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonSeen;
        private System.Windows.Forms.RadioButton radioButtonNotSeen;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxIndividuals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewComments;
        private System.Windows.Forms.BindingSource individualBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sightedCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sighting;
        private System.Windows.Forms.DataGridViewTextBoxColumn TroopVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}
