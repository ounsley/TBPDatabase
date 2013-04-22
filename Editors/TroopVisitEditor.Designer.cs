namespace TBPDatabase.Editors
{
    partial class TroopVisitEditor
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label troopLabel;
            System.Windows.Forms.Label aMSleepingCliffLabel;
            System.Windows.Forms.Label pMSleepingCliffLabel;
            System.Windows.Forms.Label fullDayFollowLabel;
            System.Windows.Forms.Label gPSRouteLabel;
            System.Windows.Forms.Label waterLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label distanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TroopVisitEditor));
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.troopVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.troopComboBox = new System.Windows.Forms.ComboBox();
            this.aMSleepingCliffComboBox = new System.Windows.Forms.ComboBox();
            this.pMSleepingCliffComboBox = new System.Windows.Forms.ComboBox();
            this.fullDayFollowCheckBox = new System.Windows.Forms.CheckBox();
            this.gPSRouteCheckBox = new System.Windows.Forms.CheckBox();
            this.waterCheckBox = new System.Windows.Forms.CheckBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            troopLabel = new System.Windows.Forms.Label();
            aMSleepingCliffLabel = new System.Windows.Forms.Label();
            pMSleepingCliffLabel = new System.Windows.Forms.Label();
            fullDayFollowLabel = new System.Windows.Forms.Label();
            gPSRouteLabel = new System.Windows.Forms.Label();
            waterLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.troopVisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 16);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // troopLabel
            // 
            troopLabel.AutoSize = true;
            troopLabel.Location = new System.Drawing.Point(12, 41);
            troopLabel.Name = "troopLabel";
            troopLabel.Size = new System.Drawing.Size(38, 13);
            troopLabel.TabIndex = 2;
            troopLabel.Text = "Troop:";
            // 
            // aMSleepingCliffLabel
            // 
            aMSleepingCliffLabel.AutoSize = true;
            aMSleepingCliffLabel.Location = new System.Drawing.Point(12, 68);
            aMSleepingCliffLabel.Name = "aMSleepingCliffLabel";
            aMSleepingCliffLabel.Size = new System.Drawing.Size(87, 13);
            aMSleepingCliffLabel.TabIndex = 4;
            aMSleepingCliffLabel.Text = "AMSleeping Cliff:";
            // 
            // pMSleepingCliffLabel
            // 
            pMSleepingCliffLabel.AutoSize = true;
            pMSleepingCliffLabel.Location = new System.Drawing.Point(12, 95);
            pMSleepingCliffLabel.Name = "pMSleepingCliffLabel";
            pMSleepingCliffLabel.Size = new System.Drawing.Size(87, 13);
            pMSleepingCliffLabel.TabIndex = 6;
            pMSleepingCliffLabel.Text = "PMSleeping Cliff:";
            // 
            // fullDayFollowLabel
            // 
            fullDayFollowLabel.AutoSize = true;
            fullDayFollowLabel.Location = new System.Drawing.Point(12, 129);
            fullDayFollowLabel.Name = "fullDayFollowLabel";
            fullDayFollowLabel.Size = new System.Drawing.Size(81, 13);
            fullDayFollowLabel.TabIndex = 8;
            fullDayFollowLabel.Text = "Full Day Follow:";
            // 
            // gPSRouteLabel
            // 
            gPSRouteLabel.AutoSize = true;
            gPSRouteLabel.Location = new System.Drawing.Point(12, 159);
            gPSRouteLabel.Name = "gPSRouteLabel";
            gPSRouteLabel.Size = new System.Drawing.Size(61, 13);
            gPSRouteLabel.TabIndex = 10;
            gPSRouteLabel.Text = "GPSRoute:";
            // 
            // waterLabel
            // 
            waterLabel.AutoSize = true;
            waterLabel.Location = new System.Drawing.Point(12, 189);
            waterLabel.Name = "waterLabel";
            waterLabel.Size = new System.Drawing.Size(39, 13);
            waterLabel.TabIndex = 12;
            waterLabel.Text = "Water:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(12, 217);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 14;
            commentsLabel.Text = "Comments:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(133, 129);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(52, 13);
            distanceLabel.TabIndex = 16;
            distanceLabel.Text = "Distance:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.troopVisitBindingSource, "Date", true));
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.troopVisitBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "null"));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(56, 12);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.ShowCheckBox = true;
            this.dateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // troopVisitBindingSource
            // 
            this.troopVisitBindingSource.DataSource = typeof(TBPDatabase.Domain.TroopVisit);
            // 
            // troopComboBox
            // 
            this.troopComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.troopVisitBindingSource, "Troop", true));
            this.troopComboBox.FormattingEnabled = true;
            this.troopComboBox.Location = new System.Drawing.Point(56, 38);
            this.troopComboBox.Name = "troopComboBox";
            this.troopComboBox.Size = new System.Drawing.Size(63, 21);
            this.troopComboBox.TabIndex = 3;
            // 
            // aMSleepingCliffComboBox
            // 
            this.aMSleepingCliffComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.troopVisitBindingSource, "AMSleepingCliff", true));
            this.aMSleepingCliffComboBox.FormattingEnabled = true;
            this.aMSleepingCliffComboBox.Location = new System.Drawing.Point(105, 65);
            this.aMSleepingCliffComboBox.Name = "aMSleepingCliffComboBox";
            this.aMSleepingCliffComboBox.Size = new System.Drawing.Size(145, 21);
            this.aMSleepingCliffComboBox.TabIndex = 5;
            // 
            // pMSleepingCliffComboBox
            // 
            this.pMSleepingCliffComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.troopVisitBindingSource, "PMSleepingCliff", true));
            this.pMSleepingCliffComboBox.FormattingEnabled = true;
            this.pMSleepingCliffComboBox.Location = new System.Drawing.Point(105, 92);
            this.pMSleepingCliffComboBox.Name = "pMSleepingCliffComboBox";
            this.pMSleepingCliffComboBox.Size = new System.Drawing.Size(145, 21);
            this.pMSleepingCliffComboBox.TabIndex = 7;
            // 
            // fullDayFollowCheckBox
            // 
            this.fullDayFollowCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.troopVisitBindingSource, "FullDayFollow", true));
            this.fullDayFollowCheckBox.Location = new System.Drawing.Point(99, 124);
            this.fullDayFollowCheckBox.Name = "fullDayFollowCheckBox";
            this.fullDayFollowCheckBox.Size = new System.Drawing.Size(20, 24);
            this.fullDayFollowCheckBox.TabIndex = 9;
            this.fullDayFollowCheckBox.UseVisualStyleBackColor = true;
            // 
            // gPSRouteCheckBox
            // 
            this.gPSRouteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.troopVisitBindingSource, "GPSRoute", true));
            this.gPSRouteCheckBox.Location = new System.Drawing.Point(99, 154);
            this.gPSRouteCheckBox.Name = "gPSRouteCheckBox";
            this.gPSRouteCheckBox.Size = new System.Drawing.Size(20, 24);
            this.gPSRouteCheckBox.TabIndex = 11;
            this.gPSRouteCheckBox.UseVisualStyleBackColor = true;
            // 
            // waterCheckBox
            // 
            this.waterCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.troopVisitBindingSource, "Water", true));
            this.waterCheckBox.Location = new System.Drawing.Point(99, 184);
            this.waterCheckBox.Name = "waterCheckBox";
            this.waterCheckBox.Size = new System.Drawing.Size(20, 24);
            this.waterCheckBox.TabIndex = 13;
            this.waterCheckBox.UseVisualStyleBackColor = true;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.troopVisitBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(77, 217);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(173, 83);
            this.commentsTextBox.TabIndex = 15;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.troopVisitBindingSource, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(191, 126);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(35, 20);
            this.distanceTextBox.TabIndex = 17;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(94, 316);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 18;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(175, 316);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // TroopVisitEditor
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(262, 351);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(waterLabel);
            this.Controls.Add(this.waterCheckBox);
            this.Controls.Add(gPSRouteLabel);
            this.Controls.Add(this.gPSRouteCheckBox);
            this.Controls.Add(fullDayFollowLabel);
            this.Controls.Add(this.fullDayFollowCheckBox);
            this.Controls.Add(pMSleepingCliffLabel);
            this.Controls.Add(this.pMSleepingCliffComboBox);
            this.Controls.Add(aMSleepingCliffLabel);
            this.Controls.Add(this.aMSleepingCliffComboBox);
            this.Controls.Add(troopLabel);
            this.Controls.Add(this.troopComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TroopVisitEditor";
            this.ShowIcon = false;
            this.Text = "TroopVisitEditor";
            ((System.ComponentModel.ISupportInitialize)(this.troopVisitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource troopVisitBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox troopComboBox;
        private System.Windows.Forms.ComboBox aMSleepingCliffComboBox;
        private System.Windows.Forms.ComboBox pMSleepingCliffComboBox;
        private System.Windows.Forms.CheckBox fullDayFollowCheckBox;
        private System.Windows.Forms.CheckBox gPSRouteCheckBox;
        private System.Windows.Forms.CheckBox waterCheckBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}