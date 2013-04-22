namespace TBPDatabase.Forms
{
    partial class FormIndividual
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelIndividualId = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.labelRightTop = new System.Windows.Forms.Label();
            this.labelRightMiddle = new System.Windows.Forms.Label();
            this.labelRightBottom = new System.Windows.Forms.Label();
            this.labelLeftTop = new System.Windows.Forms.Label();
            this.labelLeftMiddle = new System.Windows.Forms.Label();
            this.labelLeftBottom = new System.Windows.Forms.Label();
            this.groupBoxNotches = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentTroop = new System.Windows.Forms.Label();
            this.groupBoxNotches.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOk.Location = new System.Drawing.Point(526, 409);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelIndividualId
            // 
            this.labelIndividualId.AutoSize = true;
            this.labelIndividualId.Location = new System.Drawing.Point(12, 65);
            this.labelIndividualId.Name = "labelIndividualId";
            this.labelIndividualId.Size = new System.Drawing.Size(35, 13);
            this.labelIndividualId.TabIndex = 4;
            this.labelIndividualId.Text = "label1";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(12, 89);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(35, 13);
            this.labelSex.TabIndex = 5;
            this.labelSex.Text = "label2";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(111, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 390);
            this.tabControl1.TabIndex = 6;
            // 
            // labelRightTop
            // 
            this.labelRightTop.AutoSize = true;
            this.labelRightTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightTop.Location = new System.Drawing.Point(6, 16);
            this.labelRightTop.Name = "labelRightTop";
            this.labelRightTop.Size = new System.Drawing.Size(18, 25);
            this.labelRightTop.TabIndex = 7;
            this.labelRightTop.Text = "\\";
            // 
            // labelRightMiddle
            // 
            this.labelRightMiddle.AutoSize = true;
            this.labelRightMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightMiddle.Location = new System.Drawing.Point(6, 34);
            this.labelRightMiddle.Name = "labelRightMiddle";
            this.labelRightMiddle.Size = new System.Drawing.Size(19, 25);
            this.labelRightMiddle.TabIndex = 8;
            this.labelRightMiddle.Text = "-";
            // 
            // labelRightBottom
            // 
            this.labelRightBottom.AutoSize = true;
            this.labelRightBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightBottom.Location = new System.Drawing.Point(6, 54);
            this.labelRightBottom.Name = "labelRightBottom";
            this.labelRightBottom.Size = new System.Drawing.Size(18, 25);
            this.labelRightBottom.TabIndex = 9;
            this.labelRightBottom.Text = "/";
            // 
            // labelLeftTop
            // 
            this.labelLeftTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftTop.AutoSize = true;
            this.labelLeftTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftTop.Location = new System.Drawing.Point(57, 16);
            this.labelLeftTop.Name = "labelLeftTop";
            this.labelLeftTop.Size = new System.Drawing.Size(18, 25);
            this.labelLeftTop.TabIndex = 10;
            this.labelLeftTop.Text = "/";
            // 
            // labelLeftMiddle
            // 
            this.labelLeftMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftMiddle.AutoSize = true;
            this.labelLeftMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftMiddle.Location = new System.Drawing.Point(56, 34);
            this.labelLeftMiddle.Name = "labelLeftMiddle";
            this.labelLeftMiddle.Size = new System.Drawing.Size(19, 25);
            this.labelLeftMiddle.TabIndex = 11;
            this.labelLeftMiddle.Text = "-";
            // 
            // labelLeftBottom
            // 
            this.labelLeftBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftBottom.AutoSize = true;
            this.labelLeftBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftBottom.Location = new System.Drawing.Point(57, 54);
            this.labelLeftBottom.Name = "labelLeftBottom";
            this.labelLeftBottom.Size = new System.Drawing.Size(18, 25);
            this.labelLeftBottom.TabIndex = 12;
            this.labelLeftBottom.Text = "\\";
            // 
            // groupBoxNotches
            // 
            this.groupBoxNotches.Controls.Add(this.label1);
            this.groupBoxNotches.Controls.Add(this.labelLeftBottom);
            this.groupBoxNotches.Controls.Add(this.labelRightBottom);
            this.groupBoxNotches.Controls.Add(this.labelLeftMiddle);
            this.groupBoxNotches.Controls.Add(this.labelLeftTop);
            this.groupBoxNotches.Controls.Add(this.labelRightMiddle);
            this.groupBoxNotches.Controls.Add(this.labelRightTop);
            this.groupBoxNotches.Location = new System.Drawing.Point(12, 127);
            this.groupBoxNotches.Name = "groupBoxNotches";
            this.groupBoxNotches.Size = new System.Drawing.Size(82, 83);
            this.groupBoxNotches.TabIndex = 13;
            this.groupBoxNotches.TabStop = false;
            this.groupBoxNotches.Text = "Notches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "RL";
            // 
            // labelCurrentTroop
            // 
            this.labelCurrentTroop.AutoSize = true;
            this.labelCurrentTroop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTroop.Location = new System.Drawing.Point(8, 33);
            this.labelCurrentTroop.Name = "labelCurrentTroop";
            this.labelCurrentTroop.Size = new System.Drawing.Size(46, 20);
            this.labelCurrentTroop.TabIndex = 14;
            this.labelCurrentTroop.Text = "troop";
            // 
            // FormIndividual
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonOk;
            this.ClientSize = new System.Drawing.Size(613, 444);
            this.Controls.Add(this.labelCurrentTroop);
            this.Controls.Add(this.groupBoxNotches);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelIndividualId);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIndividual";
            this.Text = " ";
            this.groupBoxNotches.ResumeLayout(false);
            this.groupBoxNotches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelIndividualId;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label labelRightTop;
        private System.Windows.Forms.Label labelRightMiddle;
        private System.Windows.Forms.Label labelRightBottom;
        private System.Windows.Forms.Label labelLeftTop;
        private System.Windows.Forms.Label labelLeftMiddle;
        private System.Windows.Forms.Label labelLeftBottom;
        private System.Windows.Forms.GroupBox groupBoxNotches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentTroop;
    }
}