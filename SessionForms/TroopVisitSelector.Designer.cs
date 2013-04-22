namespace TBPDatabase.SessionForms
{
    partial class TroopVisitSelector
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.troopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMSleepingCliffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMSleepingCliffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fullDayFollowDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gPSRouteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troopVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopVisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.troopDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.aMSleepingCliffDataGridViewTextBoxColumn,
            this.pMSleepingCliffDataGridViewTextBoxColumn,
            this.waterDataGridViewCheckBoxColumn,
            this.fullDayFollowDataGridViewCheckBoxColumn,
            this.gPSRouteDataGridViewCheckBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.troopVisitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(494, 236);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(78, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(578, 236);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(413, 236);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // troopDataGridViewTextBoxColumn
            // 
            this.troopDataGridViewTextBoxColumn.DataPropertyName = "Troop";
            this.troopDataGridViewTextBoxColumn.HeaderText = "Troop";
            this.troopDataGridViewTextBoxColumn.Name = "troopDataGridViewTextBoxColumn";
            this.troopDataGridViewTextBoxColumn.ReadOnly = true;
            this.troopDataGridViewTextBoxColumn.Width = 60;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // aMSleepingCliffDataGridViewTextBoxColumn
            // 
            this.aMSleepingCliffDataGridViewTextBoxColumn.DataPropertyName = "AMSleepingCliff";
            this.aMSleepingCliffDataGridViewTextBoxColumn.HeaderText = "AMSleepingCliff";
            this.aMSleepingCliffDataGridViewTextBoxColumn.Name = "aMSleepingCliffDataGridViewTextBoxColumn";
            this.aMSleepingCliffDataGridViewTextBoxColumn.ReadOnly = true;
            this.aMSleepingCliffDataGridViewTextBoxColumn.Width = 106;
            // 
            // pMSleepingCliffDataGridViewTextBoxColumn
            // 
            this.pMSleepingCliffDataGridViewTextBoxColumn.DataPropertyName = "PMSleepingCliff";
            this.pMSleepingCliffDataGridViewTextBoxColumn.HeaderText = "PMSleepingCliff";
            this.pMSleepingCliffDataGridViewTextBoxColumn.Name = "pMSleepingCliffDataGridViewTextBoxColumn";
            this.pMSleepingCliffDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMSleepingCliffDataGridViewTextBoxColumn.Width = 106;
            // 
            // waterDataGridViewCheckBoxColumn
            // 
            this.waterDataGridViewCheckBoxColumn.DataPropertyName = "Water";
            this.waterDataGridViewCheckBoxColumn.HeaderText = "Water";
            this.waterDataGridViewCheckBoxColumn.Name = "waterDataGridViewCheckBoxColumn";
            this.waterDataGridViewCheckBoxColumn.ReadOnly = true;
            this.waterDataGridViewCheckBoxColumn.Width = 42;
            // 
            // fullDayFollowDataGridViewCheckBoxColumn
            // 
            this.fullDayFollowDataGridViewCheckBoxColumn.DataPropertyName = "FullDayFollow";
            this.fullDayFollowDataGridViewCheckBoxColumn.HeaderText = "FullDayFollow";
            this.fullDayFollowDataGridViewCheckBoxColumn.Name = "fullDayFollowDataGridViewCheckBoxColumn";
            this.fullDayFollowDataGridViewCheckBoxColumn.ReadOnly = true;
            this.fullDayFollowDataGridViewCheckBoxColumn.Width = 78;
            // 
            // gPSRouteDataGridViewCheckBoxColumn
            // 
            this.gPSRouteDataGridViewCheckBoxColumn.DataPropertyName = "GPSRoute";
            this.gPSRouteDataGridViewCheckBoxColumn.HeaderText = "GPSRoute";
            this.gPSRouteDataGridViewCheckBoxColumn.Name = "gPSRouteDataGridViewCheckBoxColumn";
            this.gPSRouteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gPSRouteDataGridViewCheckBoxColumn.Width = 64;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.distanceDataGridViewTextBoxColumn.Width = 74;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Width = 81;
            // 
            // troopVisitBindingSource
            // 
            this.troopVisitBindingSource.DataSource = typeof(TBPDatabase.Domain.TroopVisit);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Location = new System.Drawing.Point(332, 236);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // TroopVisitSelector
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(669, 271);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TroopVisitSelector";
            this.Text = "TroopVisitSelector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopVisitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource troopVisitBindingSource;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn troopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMSleepingCliffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMSleepingCliffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fullDayFollowDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gPSRouteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
    }
}