namespace TBPDatabase.DailyInput
{
    partial class TroopVisitSelectionWizardPage
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
            System.Windows.Forms.Label troopLabel;
            System.Windows.Forms.Label dateLabel;
            this.troopComboBox = new System.Windows.Forms.ComboBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewRecentTroopVisits = new System.Windows.Forms.DataGridView();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.radioButtonExisting = new System.Windows.Forms.RadioButton();
            this.troopVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.troopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMSleepingCliffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMSleepingCliffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fullDayFollowDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gPSRouteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            troopLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentTroopVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopVisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // troopLabel
            // 
            troopLabel.AutoSize = true;
            troopLabel.Location = new System.Drawing.Point(32, 69);
            troopLabel.Name = "troopLabel";
            troopLabel.Size = new System.Drawing.Size(38, 13);
            troopLabel.TabIndex = 61;
            troopLabel.Text = "Troop:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(32, 43);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 60;
            dateLabel.Text = "Date:";
            // 
            // troopComboBox
            // 
            this.troopComboBox.FormattingEnabled = true;
            this.troopComboBox.Location = new System.Drawing.Point(76, 66);
            this.troopComboBox.Name = "troopComboBox";
            this.troopComboBox.Size = new System.Drawing.Size(53, 21);
            this.troopComboBox.TabIndex = 63;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(76, 40);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.ShowCheckBox = true;
            this.dateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateDateTimePicker.TabIndex = 62;
            // 
            // dataGridViewRecentTroopVisits
            // 
            this.dataGridViewRecentTroopVisits.AllowUserToAddRows = false;
            this.dataGridViewRecentTroopVisits.AllowUserToDeleteRows = false;
            this.dataGridViewRecentTroopVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecentTroopVisits.AutoGenerateColumns = false;
            this.dataGridViewRecentTroopVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentTroopVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecentTroopVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.troopDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.aMSleepingCliffDataGridViewTextBoxColumn,
            this.pMSleepingCliffDataGridViewTextBoxColumn,
            this.waterDataGridViewCheckBoxColumn,
            this.fullDayFollowDataGridViewCheckBoxColumn,
            this.gPSRouteDataGridViewCheckBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridViewRecentTroopVisits.DataSource = this.troopVisitBindingSource;
            this.dataGridViewRecentTroopVisits.Location = new System.Drawing.Point(3, 145);
            this.dataGridViewRecentTroopVisits.MultiSelect = false;
            this.dataGridViewRecentTroopVisits.Name = "dataGridViewRecentTroopVisits";
            this.dataGridViewRecentTroopVisits.ReadOnly = true;
            this.dataGridViewRecentTroopVisits.RowHeadersVisible = false;
            this.dataGridViewRecentTroopVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecentTroopVisits.Size = new System.Drawing.Size(634, 217);
            this.dataGridViewRecentTroopVisits.TabIndex = 65;
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Location = new System.Drawing.Point(3, 17);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(81, 17);
            this.radioButtonNew.TabIndex = 67;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.Text = "Create New";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            // 
            // radioButtonExisting
            // 
            this.radioButtonExisting.AutoSize = true;
            this.radioButtonExisting.Location = new System.Drawing.Point(3, 122);
            this.radioButtonExisting.Name = "radioButtonExisting";
            this.radioButtonExisting.Size = new System.Drawing.Size(81, 17);
            this.radioButtonExisting.TabIndex = 68;
            this.radioButtonExisting.TabStop = true;
            this.radioButtonExisting.Text = "Edit existing";
            this.radioButtonExisting.UseVisualStyleBackColor = true;
            // 
            // troopVisitBindingSource
            // 
            this.troopVisitBindingSource.DataSource = typeof(TBPDatabase.Domain.TroopVisit);
            // 
            // troopDataGridViewTextBoxColumn
            // 
            this.troopDataGridViewTextBoxColumn.DataPropertyName = "Troop";
            this.troopDataGridViewTextBoxColumn.FillWeight = 50F;
            this.troopDataGridViewTextBoxColumn.HeaderText = "Troop";
            this.troopDataGridViewTextBoxColumn.Name = "troopDataGridViewTextBoxColumn";
            this.troopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aMSleepingCliffDataGridViewTextBoxColumn
            // 
            this.aMSleepingCliffDataGridViewTextBoxColumn.DataPropertyName = "AMSleepingCliff";
            this.aMSleepingCliffDataGridViewTextBoxColumn.HeaderText = "AMSleepingCliff";
            this.aMSleepingCliffDataGridViewTextBoxColumn.Name = "aMSleepingCliffDataGridViewTextBoxColumn";
            this.aMSleepingCliffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pMSleepingCliffDataGridViewTextBoxColumn
            // 
            this.pMSleepingCliffDataGridViewTextBoxColumn.DataPropertyName = "PMSleepingCliff";
            this.pMSleepingCliffDataGridViewTextBoxColumn.HeaderText = "PMSleepingCliff";
            this.pMSleepingCliffDataGridViewTextBoxColumn.Name = "pMSleepingCliffDataGridViewTextBoxColumn";
            this.pMSleepingCliffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waterDataGridViewCheckBoxColumn
            // 
            this.waterDataGridViewCheckBoxColumn.DataPropertyName = "Water";
            this.waterDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.waterDataGridViewCheckBoxColumn.HeaderText = "Water";
            this.waterDataGridViewCheckBoxColumn.Name = "waterDataGridViewCheckBoxColumn";
            this.waterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fullDayFollowDataGridViewCheckBoxColumn
            // 
            this.fullDayFollowDataGridViewCheckBoxColumn.DataPropertyName = "FullDayFollow";
            this.fullDayFollowDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.fullDayFollowDataGridViewCheckBoxColumn.HeaderText = "FullDayFollow";
            this.fullDayFollowDataGridViewCheckBoxColumn.Name = "fullDayFollowDataGridViewCheckBoxColumn";
            this.fullDayFollowDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // gPSRouteDataGridViewCheckBoxColumn
            // 
            this.gPSRouteDataGridViewCheckBoxColumn.DataPropertyName = "GPSRoute";
            this.gPSRouteDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.gPSRouteDataGridViewCheckBoxColumn.HeaderText = "GPSRoute";
            this.gPSRouteDataGridViewCheckBoxColumn.Name = "gPSRouteDataGridViewCheckBoxColumn";
            this.gPSRouteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.FillWeight = 50F;
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.FillWeight = 200F;
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TroopVisitSelectionWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.radioButtonExisting);
            this.Controls.Add(this.radioButtonNew);
            this.Controls.Add(this.dataGridViewRecentTroopVisits);
            this.Controls.Add(troopLabel);
            this.Controls.Add(this.troopComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Name = "TroopVisitSelectionWizardPage";
            this.Size = new System.Drawing.Size(640, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentTroopVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopVisitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox troopComboBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewRecentTroopVisits;
        private System.Windows.Forms.BindingSource troopVisitBindingSource;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.RadioButton radioButtonExisting;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMSleepingCliffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMSleepingCliffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fullDayFollowDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gPSRouteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;

    }
}
