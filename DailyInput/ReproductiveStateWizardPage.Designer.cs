﻿namespace TBPDatabase.DailyInput
{
    partial class ReproductiveStateWizardPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDescriptionUpdate = new System.Windows.Forms.Label();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.labelReproductiveState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelIndividual = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxFemales = new System.Windows.Forms.ComboBox();
            this.labelDescriptionNew = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCommentsNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxStateNew = new System.Windows.Forms.ComboBox();
            this.individualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualReproductiveStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualReproductiveStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.individualDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.troopVisitDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.individualReproductiveStateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(594, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDescriptionUpdate);
            this.groupBox1.Controls.Add(this.buttonRevert);
            this.groupBox1.Controls.Add(this.labelReproductiveState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxComments);
            this.groupBox1.Controls.Add(this.labelIndividual);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.comboBoxState);
            this.groupBox1.Location = new System.Drawing.Point(4, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // labelDescriptionUpdate
            // 
            this.labelDescriptionUpdate.AutoSize = true;
            this.labelDescriptionUpdate.Location = new System.Drawing.Point(142, 41);
            this.labelDescriptionUpdate.Name = "labelDescriptionUpdate";
            this.labelDescriptionUpdate.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptionUpdate.TabIndex = 7;
            this.labelDescriptionUpdate.Text = "Description";
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(104, 117);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(98, 23);
            this.buttonRevert.TabIndex = 6;
            this.buttonRevert.Text = "Revert/Remove";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // labelReproductiveState
            // 
            this.labelReproductiveState.AutoSize = true;
            this.labelReproductiveState.Location = new System.Drawing.Point(142, 22);
            this.labelReproductiveState.Name = "labelReproductiveState";
            this.labelReproductiveState.Size = new System.Drawing.Size(35, 13);
            this.labelReproductiveState.TabIndex = 5;
            this.labelReproductiveState.Text = "State:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comments:";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(9, 80);
            this.textBoxComments.MaxLength = 200;
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(276, 31);
            this.textBoxComments.TabIndex = 3;
            // 
            // labelIndividual
            // 
            this.labelIndividual.AutoSize = true;
            this.labelIndividual.Location = new System.Drawing.Point(6, 22);
            this.labelIndividual.Name = "labelIndividual";
            this.labelIndividual.Size = new System.Drawing.Size(10, 13);
            this.labelIndividual.TabIndex = 2;
            this.labelIndividual.Text = "-";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(210, 117);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(183, 19);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(50, 21);
            this.comboBoxState.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxFemales);
            this.groupBox2.Controls.Add(this.labelDescriptionNew);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxCommentsNew);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.comboBoxStateNew);
            this.groupBox2.Location = new System.Drawing.Point(301, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 146);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Female";
            // 
            // comboBoxFemales
            // 
            this.comboBoxFemales.FormattingEnabled = true;
            this.comboBoxFemales.Location = new System.Drawing.Point(13, 38);
            this.comboBoxFemales.Name = "comboBoxFemales";
            this.comboBoxFemales.Size = new System.Drawing.Size(124, 21);
            this.comboBoxFemales.TabIndex = 8;
            // 
            // labelDescriptionNew
            // 
            this.labelDescriptionNew.AutoSize = true;
            this.labelDescriptionNew.Location = new System.Drawing.Point(143, 41);
            this.labelDescriptionNew.Name = "labelDescriptionNew";
            this.labelDescriptionNew.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptionNew.TabIndex = 7;
            this.labelDescriptionNew.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comments:";
            // 
            // textBoxCommentsNew
            // 
            this.textBoxCommentsNew.Location = new System.Drawing.Point(13, 80);
            this.textBoxCommentsNew.MaxLength = 200;
            this.textBoxCommentsNew.Multiline = true;
            this.textBoxCommentsNew.Name = "textBoxCommentsNew";
            this.textBoxCommentsNew.Size = new System.Drawing.Size(277, 31);
            this.textBoxCommentsNew.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Individual:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(215, 117);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxStateNew
            // 
            this.comboBoxStateNew.FormattingEnabled = true;
            this.comboBoxStateNew.Location = new System.Drawing.Point(184, 17);
            this.comboBoxStateNew.Name = "comboBoxStateNew";
            this.comboBoxStateNew.Size = new System.Drawing.Size(50, 21);
            this.comboBoxStateNew.TabIndex = 0;
            // 
            // individualDataGridViewTextBoxColumn
            // 
            this.individualDataGridViewTextBoxColumn.DataPropertyName = "Individual";
            this.individualDataGridViewTextBoxColumn.HeaderText = "Individual";
            this.individualDataGridViewTextBoxColumn.Name = "individualDataGridViewTextBoxColumn";
            this.individualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // troopVisitDataGridViewTextBoxColumn
            // 
            this.troopVisitDataGridViewTextBoxColumn.DataPropertyName = "TroopVisit";
            this.troopVisitDataGridViewTextBoxColumn.HeaderText = "TroopVisit";
            this.troopVisitDataGridViewTextBoxColumn.Name = "troopVisitDataGridViewTextBoxColumn";
            this.troopVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.FillWeight = 200F;
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualReproductiveStateBindingSource
            // 
            this.individualReproductiveStateBindingSource.DataSource = typeof(TBPDatabase.Domain.IndividualReproductiveState);
            // 
            // ReproductiveStateWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReproductiveStateWizardPage";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualReproductiveStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource individualReproductiveStateBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescriptionUpdate;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.Label labelReproductiveState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelIndividual;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxFemales;
        private System.Windows.Forms.Label labelDescriptionNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCommentsNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxStateNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;

    }
}
