namespace TBPDatabase.Editors
{
    partial class IndividualEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualEditor));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceIndividual = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDateNothced = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTrappingID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxRT = new System.Windows.Forms.CheckBox();
            this.checkBoxRM = new System.Windows.Forms.CheckBox();
            this.checkBoxLB = new System.Windows.Forms.CheckBox();
            this.checkBoxRB = new System.Windows.Forms.CheckBox();
            this.checkBoxLM = new System.Windows.Forms.CheckBox();
            this.checkBoxLT = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerActualDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxMother = new System.Windows.Forms.ComboBox();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIDNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFieldDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSighting = new System.Windows.Forms.ComboBox();
            this.labelAgeClassDescription = new System.Windows.Forms.Label();
            this.labelSightingDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAgeClass = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIndividual)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(412, 401);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(493, 401);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dateTimePickerDateNothced);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxTrappingID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 119);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trapping Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Generate New ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "TrappingEstimatedDOB", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "null"));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceIndividual, "TrappingEstimatedDOB", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(136, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // bindingSourceIndividual
            // 
            this.bindingSourceIndividual.DataSource = typeof(TBPDatabase.Domain.Individual);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Trapping DOB:";
            // 
            // dateTimePickerDateNothced
            // 
            this.dateTimePickerDateNothced.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "DateNotched", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "null"));
            this.dateTimePickerDateNothced.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceIndividual, "DateNotched", true));
            this.dateTimePickerDateNothced.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateNothced.Location = new System.Drawing.Point(136, 46);
            this.dateTimePickerDateNothced.Name = "dateTimePickerDateNothced";
            this.dateTimePickerDateNothced.ShowCheckBox = true;
            this.dateTimePickerDateNothced.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDateNothced.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Date Notched:";
            // 
            // textBoxTrappingID
            // 
            this.textBoxTrappingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceIndividual, "TrappingID", true));
            this.textBoxTrappingID.Location = new System.Drawing.Point(136, 20);
            this.textBoxTrappingID.MaxLength = 4;
            this.textBoxTrappingID.Name = "textBoxTrappingID";
            this.textBoxTrappingID.Size = new System.Drawing.Size(121, 20);
            this.textBoxTrappingID.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Trapping ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.checkBoxRT);
            this.groupBox3.Controls.Add(this.checkBoxRM);
            this.groupBox3.Controls.Add(this.checkBoxLB);
            this.groupBox3.Controls.Add(this.checkBoxRB);
            this.groupBox3.Controls.Add(this.checkBoxLM);
            this.groupBox3.Controls.Add(this.checkBoxLT);
            this.groupBox3.Location = new System.Drawing.Point(401, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 89);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notches";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "R L";
            // 
            // checkBoxRT
            // 
            this.checkBoxRT.AutoSize = true;
            this.checkBoxRT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "RightTop", true));
            this.checkBoxRT.Location = new System.Drawing.Point(17, 19);
            this.checkBoxRT.Name = "checkBoxRT";
            this.checkBoxRT.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRT.TabIndex = 0;
            this.checkBoxRT.UseVisualStyleBackColor = true;
            // 
            // checkBoxRM
            // 
            this.checkBoxRM.AutoSize = true;
            this.checkBoxRM.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "RightMiddle", true));
            this.checkBoxRM.Location = new System.Drawing.Point(17, 39);
            this.checkBoxRM.Name = "checkBoxRM";
            this.checkBoxRM.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRM.TabIndex = 5;
            this.checkBoxRM.UseVisualStyleBackColor = true;
            // 
            // checkBoxLB
            // 
            this.checkBoxLB.AutoSize = true;
            this.checkBoxLB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "LeftBottom", true));
            this.checkBoxLB.Location = new System.Drawing.Point(116, 59);
            this.checkBoxLB.Name = "checkBoxLB";
            this.checkBoxLB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLB.TabIndex = 1;
            this.checkBoxLB.UseVisualStyleBackColor = true;
            // 
            // checkBoxRB
            // 
            this.checkBoxRB.AutoSize = true;
            this.checkBoxRB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "RightBottom", true));
            this.checkBoxRB.Location = new System.Drawing.Point(17, 59);
            this.checkBoxRB.Name = "checkBoxRB";
            this.checkBoxRB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRB.TabIndex = 4;
            this.checkBoxRB.UseVisualStyleBackColor = true;
            // 
            // checkBoxLM
            // 
            this.checkBoxLM.AutoSize = true;
            this.checkBoxLM.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "LeftMiddle", true));
            this.checkBoxLM.Location = new System.Drawing.Point(116, 39);
            this.checkBoxLM.Name = "checkBoxLM";
            this.checkBoxLM.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLM.TabIndex = 2;
            this.checkBoxLM.UseVisualStyleBackColor = true;
            // 
            // checkBoxLT
            // 
            this.checkBoxLT.AutoSize = true;
            this.checkBoxLT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "LeftTop", true));
            this.checkBoxLT.Location = new System.Drawing.Point(116, 19);
            this.checkBoxLT.Name = "checkBoxLT";
            this.checkBoxLT.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLT.TabIndex = 3;
            this.checkBoxLT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePickerActualDOB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxMother);
            this.groupBox1.Controls.Add(this.textBoxComments);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxIDNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePickerFieldDOB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxSighting);
            this.groupBox1.Controls.Add(this.labelAgeClassDescription);
            this.groupBox1.Controls.Add(this.labelSightingDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.comboBoxAgeClass);
            this.groupBox1.Controls.Add(this.comboBoxSex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 258);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Actual DOB:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerActualDOB
            // 
            this.dateTimePickerActualDOB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "ActualDOB", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "null"));
            this.dateTimePickerActualDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceIndividual, "ActualDOB", true));
            this.dateTimePickerActualDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerActualDOB.Location = new System.Drawing.Point(165, 120);
            this.dateTimePickerActualDOB.Name = "dateTimePickerActualDOB";
            this.dateTimePickerActualDOB.ShowCheckBox = true;
            this.dateTimePickerActualDOB.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerActualDOB.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mother:";
            // 
            // comboBoxMother
            // 
            this.comboBoxMother.FormattingEnabled = true;
            this.comboBoxMother.Location = new System.Drawing.Point(165, 172);
            this.comboBoxMother.Name = "comboBoxMother";
            this.comboBoxMother.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMother.TabIndex = 16;
            // 
            // textBoxComments
            // 
            this.textBoxComments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceIndividual, "Comment", true));
            this.textBoxComments.Location = new System.Drawing.Point(165, 226);
            this.textBoxComments.MaxLength = 200;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(388, 20);
            this.textBoxComments.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comments:";
            // 
            // textBoxIDNotes
            // 
            this.textBoxIDNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceIndividual, "IDNote", true));
            this.textBoxIDNotes.Location = new System.Drawing.Point(165, 200);
            this.textBoxIDNotes.MaxLength = 200;
            this.textBoxIDNotes.Name = "textBoxIDNotes";
            this.textBoxIDNotes.Size = new System.Drawing.Size(388, 20);
            this.textBoxIDNotes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Field Estimated DOB:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerFieldDOB
            // 
            this.dateTimePickerFieldDOB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceIndividual, "FieldEstimatedDOB", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "null"));
            this.dateTimePickerFieldDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceIndividual, "FieldEstimatedDOB", true));
            this.dateTimePickerFieldDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFieldDOB.Location = new System.Drawing.Point(165, 146);
            this.dateTimePickerFieldDOB.Name = "dateTimePickerFieldDOB";
            this.dateTimePickerFieldDOB.ShowCheckBox = true;
            this.dateTimePickerFieldDOB.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerFieldDOB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Observed Context:";
            // 
            // comboBoxSighting
            // 
            this.comboBoxSighting.FormattingEnabled = true;
            this.comboBoxSighting.Location = new System.Drawing.Point(165, 66);
            this.comboBoxSighting.Name = "comboBoxSighting";
            this.comboBoxSighting.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSighting.TabIndex = 1;
            // 
            // labelAgeClassDescription
            // 
            this.labelAgeClassDescription.AutoSize = true;
            this.labelAgeClassDescription.Location = new System.Drawing.Point(292, 96);
            this.labelAgeClassDescription.Name = "labelAgeClassDescription";
            this.labelAgeClassDescription.Size = new System.Drawing.Size(0, 13);
            this.labelAgeClassDescription.TabIndex = 9;
            // 
            // labelSightingDescription
            // 
            this.labelSightingDescription.AutoSize = true;
            this.labelSightingDescription.Location = new System.Drawing.Point(292, 69);
            this.labelSightingDescription.Name = "labelSightingDescription";
            this.labelSightingDescription.Size = new System.Drawing.Size(0, 13);
            this.labelSightingDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Observed Age Class:";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceIndividual, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(165, 13);
            this.textBoxName.MaxLength = 45;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // comboBoxAgeClass
            // 
            this.comboBoxAgeClass.FormattingEnabled = true;
            this.comboBoxAgeClass.Location = new System.Drawing.Point(165, 93);
            this.comboBoxAgeClass.Name = "comboBoxAgeClass";
            this.comboBoxAgeClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgeClass.TabIndex = 7;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(165, 39);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex:";
            // 
            // IndividualEditor
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(583, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndividualEditor";
            this.Text = "IndividualEditor";
            this.Load += new System.EventHandler(this.IndividualEditor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIndividual)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSighting;
        private System.Windows.Forms.Label labelSightingDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAgeClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAgeClassDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxMother;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIDNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFieldDOB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxRT;
        private System.Windows.Forms.CheckBox checkBoxRM;
        private System.Windows.Forms.CheckBox checkBoxLB;
        private System.Windows.Forms.CheckBox checkBoxRB;
        private System.Windows.Forms.CheckBox checkBoxLM;
        private System.Windows.Forms.CheckBox checkBoxLT;
        private System.Windows.Forms.BindingSource bindingSourceIndividual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerActualDOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateNothced;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTrappingID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;

    }
}