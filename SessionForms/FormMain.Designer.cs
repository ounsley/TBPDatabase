namespace TBPDatabase.SessionForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonFindIndividual = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonDailyInputWizard = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFindIndividual
            // 
            this.buttonFindIndividual.Location = new System.Drawing.Point(13, 13);
            this.buttonFindIndividual.Name = "buttonFindIndividual";
            this.buttonFindIndividual.Size = new System.Drawing.Size(131, 23);
            this.buttonFindIndividual.TabIndex = 0;
            this.buttonFindIndividual.Text = "Find Individual";
            this.buttonFindIndividual.UseVisualStyleBackColor = true;
            this.buttonFindIndividual.Click += new System.EventHandler(this.buttonFindIndividual_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(150, 13);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(131, 23);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Troop Visit Selector";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(13, 42);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(131, 23);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Import Data";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Daily Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sighting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reproductive State";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Generic Editor Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Individual Editor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonDailyInputWizard
            // 
            this.buttonDailyInputWizard.Location = new System.Drawing.Point(13, 131);
            this.buttonDailyInputWizard.Name = "buttonDailyInputWizard";
            this.buttonDailyInputWizard.Size = new System.Drawing.Size(131, 23);
            this.buttonDailyInputWizard.TabIndex = 8;
            this.buttonDailyInputWizard.Text = "Daily Input Wizard";
            this.buttonDailyInputWizard.UseVisualStyleBackColor = true;
            this.buttonDailyInputWizard.Click += new System.EventHandler(this.buttonDailyInputWizard_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(151, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "TEST";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 178);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonDailyInputWizard);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonFindIndividual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "TBP Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindIndividual;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonDailyInputWizard;
        private System.Windows.Forms.Button button6;

    }
}