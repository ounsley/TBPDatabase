namespace TBPDatabase
{
    partial class FormReproductiveState
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelCommentsText = new System.Windows.Forms.Label();
            this.labelStartDateText = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelReproductiveStateText = new System.Windows.Forms.Label();
            this.comboBoxReproductiveState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(220, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(139, 187);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 14;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(120, 68);
            this.textBoxComments.MaxLength = 200;
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(175, 113);
            this.textBoxComments.TabIndex = 13;
            // 
            // labelCommentsText
            // 
            this.labelCommentsText.AutoSize = true;
            this.labelCommentsText.Location = new System.Drawing.Point(12, 68);
            this.labelCommentsText.Name = "labelCommentsText";
            this.labelCommentsText.Size = new System.Drawing.Size(59, 13);
            this.labelCommentsText.TabIndex = 12;
            this.labelCommentsText.Text = "Comments:";
            // 
            // labelStartDateText
            // 
            this.labelStartDateText.AutoSize = true;
            this.labelStartDateText.Location = new System.Drawing.Point(12, 36);
            this.labelStartDateText.Name = "labelStartDateText";
            this.labelStartDateText.Size = new System.Drawing.Size(58, 13);
            this.labelStartDateText.TabIndex = 11;
            this.labelStartDateText.Text = "Start Date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(120, 33);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerStartDate.TabIndex = 10;
            // 
            // labelReproductiveStateText
            // 
            this.labelReproductiveStateText.AutoSize = true;
            this.labelReproductiveStateText.Location = new System.Drawing.Point(12, 9);
            this.labelReproductiveStateText.Name = "labelReproductiveStateText";
            this.labelReproductiveStateText.Size = new System.Drawing.Size(102, 13);
            this.labelReproductiveStateText.TabIndex = 9;
            this.labelReproductiveStateText.Text = "Reproductive State:";
            // 
            // comboBoxReproductiveState
            // 
            this.comboBoxReproductiveState.FormattingEnabled = true;
            this.comboBoxReproductiveState.Location = new System.Drawing.Point(120, 6);
            this.comboBoxReproductiveState.Name = "comboBoxReproductiveState";
            this.comboBoxReproductiveState.Size = new System.Drawing.Size(175, 21);
            this.comboBoxReproductiveState.TabIndex = 8;
            this.comboBoxReproductiveState.SelectedIndexChanged += new System.EventHandler(this.comboBoxReproductiveState_SelectedIndexChanged);
            // 
            // FormReproductiveState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 219);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelCommentsText);
            this.Controls.Add(this.labelStartDateText);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelReproductiveStateText);
            this.Controls.Add(this.comboBoxReproductiveState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReproductiveState";
            this.Text = "FormReproductiveState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelCommentsText;
        private System.Windows.Forms.Label labelStartDateText;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelReproductiveStateText;
        private System.Windows.Forms.ComboBox comboBoxReproductiveState;
    }
}