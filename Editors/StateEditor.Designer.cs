using TBPDatabase.Domain;

namespace TBPDatabase.Editors
{
    partial class StateEditor<T, S>
        where T : IIndividualState<S>, new()
        where S : IReference
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
            this.buttonTroopVisistSelect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelTroopVisitLabel = new System.Windows.Forms.Label();
            this.labelStateLabel = new System.Windows.Forms.Label();
            this.labelTroopVisit = new System.Windows.Forms.Label();
            this.labelCommentsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStateDescription = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTroopVisistSelect
            // 
            this.buttonTroopVisistSelect.Location = new System.Drawing.Point(265, 30);
            this.buttonTroopVisistSelect.Name = "buttonTroopVisistSelect";
            this.buttonTroopVisistSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonTroopVisistSelect.TabIndex = 0;
            this.buttonTroopVisistSelect.Text = "Select";
            this.buttonTroopVisistSelect.UseVisualStyleBackColor = true;
            this.buttonTroopVisistSelect.Click += new System.EventHandler(this.buttonTroopVisistSelect_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(90, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxState
            // 
            this.comboBoxState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(90, 3);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(83, 21);
            this.comboBoxState.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(9, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelTroopVisitLabel
            // 
            this.labelTroopVisitLabel.AutoSize = true;
            this.labelTroopVisitLabel.Location = new System.Drawing.Point(3, 33);
            this.labelTroopVisitLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelTroopVisitLabel.Name = "labelTroopVisitLabel";
            this.labelTroopVisitLabel.Size = new System.Drawing.Size(60, 13);
            this.labelTroopVisitLabel.TabIndex = 4;
            this.labelTroopVisitLabel.Text = "Troop Visit:";
            // 
            // labelStateLabel
            // 
            this.labelStateLabel.AutoSize = true;
            this.labelStateLabel.Location = new System.Drawing.Point(3, 6);
            this.labelStateLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.labelStateLabel.Name = "labelStateLabel";
            this.labelStateLabel.Size = new System.Drawing.Size(35, 13);
            this.labelStateLabel.TabIndex = 5;
            this.labelStateLabel.Text = "State:";
            // 
            // labelTroopVisit
            // 
            this.labelTroopVisit.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelTroopVisit, 2);
            this.labelTroopVisit.Location = new System.Drawing.Point(90, 33);
            this.labelTroopVisit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelTroopVisit.Name = "labelTroopVisit";
            this.labelTroopVisit.Size = new System.Drawing.Size(72, 13);
            this.labelTroopVisit.TabIndex = 6;
            this.labelTroopVisit.Text = "Please Select";
            // 
            // labelCommentsLabel
            // 
            this.labelCommentsLabel.AutoSize = true;
            this.labelCommentsLabel.Location = new System.Drawing.Point(3, 62);
            this.labelCommentsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelCommentsLabel.Name = "labelCommentsLabel";
            this.labelCommentsLabel.Size = new System.Drawing.Size(59, 13);
            this.labelCommentsLabel.TabIndex = 8;
            this.labelCommentsLabel.Text = "Comments:";
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel3.Controls.Add(this.buttonOk);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(179, 174);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(168, 29);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // textBoxComments
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxComments, 3);
            this.textBoxComments.Location = new System.Drawing.Point(90, 59);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(254, 67);
            this.textBoxComments.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91089F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.58416F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
            this.tableLayoutPanel2.Controls.Add(this.labelCommentsLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxState, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTroopVisit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelStateLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelStateDescription, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxComments, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonTroopVisistSelect, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelTroopVisitLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 206);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // labelStateDescription
            // 
            this.labelStateDescription.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelStateDescription, 2);
            this.labelStateDescription.Location = new System.Drawing.Point(179, 6);
            this.labelStateDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelStateDescription.Name = "labelStateDescription";
            this.labelStateDescription.Size = new System.Drawing.Size(60, 13);
            this.labelStateDescription.TabIndex = 6;
            this.labelStateDescription.Text = "Description";
            // 
            // StateEditor
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(350, 206);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StateEditor";
            this.ShowIcon = false;
            this.Text = "StateEditor";
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTroopVisistSelect;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelTroopVisitLabel;
        private System.Windows.Forms.Label labelStateLabel;
        private System.Windows.Forms.Label labelTroopVisit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelCommentsLabel;
        private System.Windows.Forms.Label labelStateDescription;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}