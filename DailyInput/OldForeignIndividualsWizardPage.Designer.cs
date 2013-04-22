namespace TBPDatabase.DailyInput
{
    partial class OldForeignIndividualsWizardPage
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
            this.individualSightingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxIndividuals = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewComments = new System.Windows.Forms.TextBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.labelIndividual = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonSeen = new System.Windows.Forms.RadioButton();
            this.radioButtonNotSeen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewNotSeen = new System.Windows.Forms.DataGridView();
            this.sightedCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.individualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sighting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.individualSightingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSeen)).BeginInit();
            this.SuspendLayout();
            // 
            // individualSightingBindingSource
            // 
            this.individualSightingBindingSource.DataSource = typeof(TBPDatabase.Domain.IndividualSighting);
            // 
            // individualBindingSource1
            // 
            this.individualBindingSource1.DataSource = typeof(TBPDatabase.Domain.Individual);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxIndividuals);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNewComments);
            this.groupBox1.Location = new System.Drawing.Point(307, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 192);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Newly Sighted";
            // 
            // comboBoxIndividuals
            // 
            this.comboBoxIndividuals.FormattingEnabled = true;
            this.comboBoxIndividuals.Location = new System.Drawing.Point(9, 36);
            this.comboBoxIndividuals.Name = "comboBoxIndividuals";
            this.comboBoxIndividuals.Size = new System.Drawing.Size(153, 21);
            this.comboBoxIndividuals.TabIndex = 63;
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
            this.buttonAdd.Location = new System.Drawing.Point(193, 163);
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
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Comments:";
            // 
            // textBoxNewComments
            // 
            this.textBoxNewComments.Location = new System.Drawing.Point(6, 86);
            this.textBoxNewComments.MaxLength = 199;
            this.textBoxNewComments.Multiline = true;
            this.textBoxNewComments.Name = "textBoxNewComments";
            this.textBoxNewComments.Size = new System.Drawing.Size(262, 71);
            this.textBoxNewComments.TabIndex = 61;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonRevert);
            this.groupBoxEdit.Controls.Add(this.labelIndividual);
            this.groupBoxEdit.Controls.Add(this.textBoxComments);
            this.groupBoxEdit.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxEdit.Controls.Add(this.label1);
            this.groupBoxEdit.Controls.Add(this.buttonUpdate);
            this.groupBoxEdit.Location = new System.Drawing.Point(19, 173);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(282, 192);
            this.groupBoxEdit.TabIndex = 64;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Update";
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(120, 163);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(75, 23);
            this.buttonRevert.TabIndex = 61;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
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
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(9, 86);
            this.textBoxComments.MaxLength = 199;
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(267, 71);
            this.textBoxComments.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonSeen);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNotSeen);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(174, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 61);
            this.flowLayoutPanel1.TabIndex = 56;
            // 
            // radioButtonSeen
            // 
            this.radioButtonSeen.AutoSize = true;
            this.radioButtonSeen.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSeen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.radioButtonSeen.Name = "radioButtonSeen";
            this.radioButtonSeen.Size = new System.Drawing.Size(99, 17);
            this.radioButtonSeen.TabIndex = 0;
            this.radioButtonSeen.TabStop = true;
            this.radioButtonSeen.Text = "Seen with troop";
            this.radioButtonSeen.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotSeen
            // 
            this.radioButtonNotSeen.AutoSize = true;
            this.radioButtonNotSeen.Location = new System.Drawing.Point(3, 33);
            this.radioButtonNotSeen.Name = "radioButtonNotSeen";
            this.radioButtonNotSeen.Size = new System.Drawing.Size(70, 17);
            this.radioButtonNotSeen.TabIndex = 1;
            this.radioButtonNotSeen.TabStop = true;
            this.radioButtonNotSeen.Text = "Not Seen";
            this.radioButtonNotSeen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Comments:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(201, 163);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 59;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonDone_Click);
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
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridViewNotSeen.DataSource = this.individualSightingBindingSource;
            this.dataGridViewNotSeen.Location = new System.Drawing.Point(19, 35);
            this.dataGridViewNotSeen.MultiSelect = false;
            this.dataGridViewNotSeen.Name = "dataGridViewNotSeen";
            this.dataGridViewNotSeen.RowHeadersVisible = false;
            this.dataGridViewNotSeen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotSeen.Size = new System.Drawing.Size(562, 132);
            this.dataGridViewNotSeen.TabIndex = 63;
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
            // ForeignIndividualsWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.dataGridViewNotSeen);
            this.Name = "ForeignIndividualsWizardPage";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.individualSightingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotSeen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource individualSightingBindingSource;
        private System.Windows.Forms.BindingSource individualBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxIndividuals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewComments;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.Label labelIndividual;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonSeen;
        private System.Windows.Forms.RadioButton radioButtonNotSeen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewNotSeen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sightedCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sighting;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}
