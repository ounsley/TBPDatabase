namespace TBPDatabase.DailyInput
{
    partial class NewIndividualsWizardPage
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
            this.labelAgeClassDescription = new System.Windows.Forms.Label();
            this.checkBoxMotherUnknown = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerActualDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxMother = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAgeClass = new System.Windows.Forms.ComboBox();
            this.textBoxIDNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFieldDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSighting = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNewIndividuals = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.line1 = new TBPDatabase.Utilities.Line();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewIndividuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAgeClassDescription
            // 
            this.labelAgeClassDescription.AutoSize = true;
            this.labelAgeClassDescription.Location = new System.Drawing.Point(325, 196);
            this.labelAgeClassDescription.Name = "labelAgeClassDescription";
            this.labelAgeClassDescription.Size = new System.Drawing.Size(0, 13);
            this.labelAgeClassDescription.TabIndex = 9;
            // 
            // checkBoxMotherUnknown
            // 
            this.checkBoxMotherUnknown.AutoSize = true;
            this.checkBoxMotherUnknown.Location = new System.Drawing.Point(281, 297);
            this.checkBoxMotherUnknown.Name = "checkBoxMotherUnknown";
            this.checkBoxMotherUnknown.Size = new System.Drawing.Size(108, 17);
            this.checkBoxMotherUnknown.TabIndex = 77;
            this.checkBoxMotherUnknown.Text = "Mother Unknown";
            this.checkBoxMotherUnknown.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(516, 374);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 75;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Actual DOB:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerActualDOB
            // 
            this.dateTimePickerActualDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerActualDOB.Location = new System.Drawing.Point(143, 241);
            this.dateTimePickerActualDOB.Name = "dateTimePickerActualDOB";
            this.dateTimePickerActualDOB.ShowCheckBox = true;
            this.dateTimePickerActualDOB.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerActualDOB.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Mother:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 134);
            this.textBoxName.MaxLength = 45;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 20);
            this.textBoxName.TabIndex = 60;
            // 
            // comboBoxMother
            // 
            this.comboBoxMother.FormattingEnabled = true;
            this.comboBoxMother.Location = new System.Drawing.Point(143, 295);
            this.comboBoxMother.Name = "comboBoxMother";
            this.comboBoxMother.Size = new System.Drawing.Size(132, 21);
            this.comboBoxMother.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Sex*:";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(143, 348);
            this.textBoxComments.MaxLength = 198;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(448, 20);
            this.textBoxComments.TabIndex = 70;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(143, 160);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(47, 21);
            this.comboBoxSex.TabIndex = 61;
            this.comboBoxSex.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Comments:";
            // 
            // comboBoxAgeClass
            // 
            this.comboBoxAgeClass.FormattingEnabled = true;
            this.comboBoxAgeClass.Location = new System.Drawing.Point(143, 214);
            this.comboBoxAgeClass.Name = "comboBoxAgeClass";
            this.comboBoxAgeClass.Size = new System.Drawing.Size(47, 21);
            this.comboBoxAgeClass.TabIndex = 63;
            // 
            // textBoxIDNotes
            // 
            this.textBoxIDNotes.Location = new System.Drawing.Point(143, 322);
            this.textBoxIDNotes.MaxLength = 198;
            this.textBoxIDNotes.Name = "textBoxIDNotes";
            this.textBoxIDNotes.Size = new System.Drawing.Size(448, 20);
            this.textBoxIDNotes.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "First Observed Age Class*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "ID Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Field Estimated DOB:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerFieldDOB
            // 
            this.dateTimePickerFieldDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFieldDOB.Location = new System.Drawing.Point(143, 267);
            this.dateTimePickerFieldDOB.Name = "dateTimePickerFieldDOB";
            this.dateTimePickerFieldDOB.ShowCheckBox = true;
            this.dateTimePickerFieldDOB.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerFieldDOB.TabIndex = 65;
            // 
            // comboBoxSighting
            // 
            this.comboBoxSighting.FormattingEnabled = true;
            this.comboBoxSighting.Location = new System.Drawing.Point(143, 187);
            this.comboBoxSighting.Name = "comboBoxSighting";
            this.comboBoxSighting.Size = new System.Drawing.Size(47, 21);
            this.comboBoxSighting.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Name*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "First Observed Context*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "* Minimum Required";
            // 
            // dataGridViewNewIndividuals
            // 
            this.dataGridViewNewIndividuals.AllowUserToAddRows = false;
            this.dataGridViewNewIndividuals.AllowUserToDeleteRows = false;
            this.dataGridViewNewIndividuals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNewIndividuals.AutoGenerateColumns = false;
            this.dataGridViewNewIndividuals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNewIndividuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewIndividuals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.motherDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridViewNewIndividuals.DataSource = this.individualBindingSource;
            this.dataGridViewNewIndividuals.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewNewIndividuals.Name = "dataGridViewNewIndividuals";
            this.dataGridViewNewIndividuals.ReadOnly = true;
            this.dataGridViewNewIndividuals.RowHeadersVisible = false;
            this.dataGridViewNewIndividuals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNewIndividuals.Size = new System.Drawing.Size(583, 91);
            this.dataGridViewNewIndividuals.TabIndex = 79;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(516, 117);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 24);
            this.buttonDelete.TabIndex = 80;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "New Today:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Add New:";
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Location = new System.Drawing.Point(8, 115);
            this.line1.MaximumSize = new System.Drawing.Size(2147483647, 2);
            this.line1.MinimumSize = new System.Drawing.Size(1, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1, 2);
            this.line1.TabIndex = 83;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motherDataGridViewTextBoxColumn
            // 
            this.motherDataGridViewTextBoxColumn.DataPropertyName = "Mother";
            this.motherDataGridViewTextBoxColumn.HeaderText = "Mother";
            this.motherDataGridViewTextBoxColumn.Name = "motherDataGridViewTextBoxColumn";
            this.motherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(TBPDatabase.Domain.Individual);
            // 
            // NewIndividualsWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewNewIndividuals);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMotherUnknown);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerActualDOB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxMother);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxAgeClass);
            this.Controls.Add(this.textBoxIDNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFieldDOB);
            this.Controls.Add(this.comboBoxSighting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAgeClassDescription);
            this.Name = "NewIndividualsWizardPage";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewIndividuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgeClassDescription;
        private System.Windows.Forms.BindingSource individualBindingSource;
        private System.Windows.Forms.CheckBox checkBoxMotherUnknown;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerActualDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxMother;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAgeClass;
        private System.Windows.Forms.TextBox textBoxIDNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFieldDOB;
        private System.Windows.Forms.ComboBox comboBoxSighting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNewIndividuals;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Utilities.Line line1;
    }
}
