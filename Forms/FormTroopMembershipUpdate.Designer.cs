namespace TBPDatabase
{
    partial class FormTroopMembershipUpdate
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
            this.comboBoxTroopId = new System.Windows.Forms.ComboBox();
            this.labelTroopText = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDateText = new System.Windows.Forms.Label();
            this.labelCommentsText = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTroopId
            // 
            this.comboBoxTroopId.FormattingEnabled = true;
            this.comboBoxTroopId.Location = new System.Drawing.Point(78, 9);
            this.comboBoxTroopId.Name = "comboBoxTroopId";
            this.comboBoxTroopId.Size = new System.Drawing.Size(69, 21);
            this.comboBoxTroopId.TabIndex = 0;
            // 
            // labelTroopText
            // 
            this.labelTroopText.AutoSize = true;
            this.labelTroopText.Location = new System.Drawing.Point(13, 12);
            this.labelTroopText.Name = "labelTroopText";
            this.labelTroopText.Size = new System.Drawing.Size(38, 13);
            this.labelTroopText.TabIndex = 1;
            this.labelTroopText.Text = "Troop:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(78, 36);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // labelStartDateText
            // 
            this.labelStartDateText.AutoSize = true;
            this.labelStartDateText.Location = new System.Drawing.Point(13, 39);
            this.labelStartDateText.Name = "labelStartDateText";
            this.labelStartDateText.Size = new System.Drawing.Size(58, 13);
            this.labelStartDateText.TabIndex = 3;
            this.labelStartDateText.Text = "Start Date:";
            // 
            // labelCommentsText
            // 
            this.labelCommentsText.AutoSize = true;
            this.labelCommentsText.Location = new System.Drawing.Point(13, 71);
            this.labelCommentsText.Name = "labelCommentsText";
            this.labelCommentsText.Size = new System.Drawing.Size(59, 13);
            this.labelCommentsText.TabIndex = 4;
            this.labelCommentsText.Text = "Comments:";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(78, 71);
            this.textBoxComments.MaxLength = 200;
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(177, 113);
            this.textBoxComments.TabIndex = 5;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(99, 190);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 6;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(180, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTroopMembershipUpdate
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(267, 222);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelCommentsText);
            this.Controls.Add(this.labelStartDateText);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelTroopText);
            this.Controls.Add(this.comboBoxTroopId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTroopMembershipUpdate";
            this.Text = "FormTroopMembershipUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTroopId;
        private System.Windows.Forms.Label labelTroopText;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDateText;
        private System.Windows.Forms.Label labelCommentsText;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}