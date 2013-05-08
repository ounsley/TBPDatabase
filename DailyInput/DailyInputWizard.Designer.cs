namespace TBPDatabase.DailyInput
{
    partial class DailyInputWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyInputWizard));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelLoadTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanelSteps = new System.Windows.Forms.FlowLayoutPanel();
            this.labelStep0 = new System.Windows.Forms.Label();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.labelStep2 = new System.Windows.Forms.Label();
            this.labelStep3 = new System.Windows.Forms.Label();
            this.labelStep4 = new System.Windows.Forms.Label();
            this.labelStep5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrentTroopVisit = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wizardTabControl = new TBPDatabase.DailyInput.WizardTabControl();
            this.tabPageTroopVisitSelection = new System.Windows.Forms.TabPage();
            this.troopVisitSelectionWizardPage1 = new TBPDatabase.DailyInput.TroopVisitSelectionWizardPage();
            this.tabPageTroopVisitDetails = new System.Windows.Forms.TabPage();
            this.troopVisitWizardPage = new TBPDatabase.DailyInput.TroopVisitDetailsWizardPage();
            this.tabPageMissingIndividuals = new System.Windows.Forms.TabPage();
            this.uncertainIndividualsWizardPage1 = new TBPDatabase.DailyInput.MissingIndividualsWizardPage();
            this.tabPageNewIndividuals = new System.Windows.Forms.TabPage();
            this.newIndividualsWizardPage1 = new TBPDatabase.DailyInput.NewIndividualsWizardPage();
            this.tabPageReproductiveStates = new System.Windows.Forms.TabPage();
            this.reproductiveStateWizardPage1 = new TBPDatabase.DailyInput.ReproductiveStateWizardPage();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.summaryWizardPage = new TBPDatabase.DailyInput.SummaryWizardPage();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanelSteps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.wizardTabControl.SuspendLayout();
            this.tabPageTroopVisitSelection.SuspendLayout();
            this.tabPageTroopVisitDetails.SuspendLayout();
            this.tabPageMissingIndividuals.SuspendLayout();
            this.tabPageNewIndividuals.SuspendLayout();
            this.tabPageReproductiveStates.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelLoadTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Load Time:";
            // 
            // labelLoadTime
            // 
            this.labelLoadTime.Name = "labelLoadTime";
            this.labelLoadTime.Size = new System.Drawing.Size(12, 17);
            this.labelLoadTime.Text = "-";
            // 
            // flowLayoutPanelSteps
            // 
            this.flowLayoutPanelSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelSteps.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelSteps.Controls.Add(this.labelStep0);
            this.flowLayoutPanelSteps.Controls.Add(this.labelStep1);
            this.flowLayoutPanelSteps.Controls.Add(this.labelStep2);
            this.flowLayoutPanelSteps.Controls.Add(this.labelStep3);
            this.flowLayoutPanelSteps.Controls.Add(this.labelStep4);
            this.flowLayoutPanelSteps.Controls.Add(this.labelStep5);
            this.flowLayoutPanelSteps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSteps.Location = new System.Drawing.Point(-5, 47);
            this.flowLayoutPanelSteps.Name = "flowLayoutPanelSteps";
            this.flowLayoutPanelSteps.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanelSteps.Size = new System.Drawing.Size(229, 446);
            this.flowLayoutPanelSteps.TabIndex = 5;
            // 
            // labelStep0
            // 
            this.labelStep0.AutoSize = true;
            this.labelStep0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep0.Location = new System.Drawing.Point(12, 30);
            this.labelStep0.Margin = new System.Windows.Forms.Padding(12, 30, 3, 15);
            this.labelStep0.Name = "labelStep0";
            this.labelStep0.Size = new System.Drawing.Size(132, 16);
            this.labelStep0.TabIndex = 1;
            this.labelStep0.Text = "Troop Visit Selection";
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep1.Location = new System.Drawing.Point(12, 61);
            this.labelStep1.Margin = new System.Windows.Forms.Padding(12, 0, 3, 15);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(118, 16);
            this.labelStep1.TabIndex = 2;
            this.labelStep1.Text = "Troop Visit Details";
            // 
            // labelStep2
            // 
            this.labelStep2.AutoSize = true;
            this.labelStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep2.Location = new System.Drawing.Point(12, 92);
            this.labelStep2.Margin = new System.Windows.Forms.Padding(12, 0, 3, 15);
            this.labelStep2.Name = "labelStep2";
            this.labelStep2.Size = new System.Drawing.Size(180, 16);
            this.labelStep2.TabIndex = 3;
            this.labelStep2.Text = "Troop Composition Changes";
            // 
            // labelStep3
            // 
            this.labelStep3.AutoSize = true;
            this.labelStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep3.Location = new System.Drawing.Point(12, 123);
            this.labelStep3.Margin = new System.Windows.Forms.Padding(12, 0, 3, 15);
            this.labelStep3.Name = "labelStep3";
            this.labelStep3.Size = new System.Drawing.Size(102, 16);
            this.labelStep3.TabIndex = 5;
            this.labelStep3.Text = "New Individuals";
            // 
            // labelStep4
            // 
            this.labelStep4.AutoSize = true;
            this.labelStep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep4.Location = new System.Drawing.Point(12, 154);
            this.labelStep4.Margin = new System.Windows.Forms.Padding(12, 0, 3, 15);
            this.labelStep4.Name = "labelStep4";
            this.labelStep4.Size = new System.Drawing.Size(180, 16);
            this.labelStep4.TabIndex = 6;
            this.labelStep4.Text = "Reproductive State Changes";
            // 
            // labelStep5
            // 
            this.labelStep5.AutoSize = true;
            this.labelStep5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep5.Location = new System.Drawing.Point(12, 185);
            this.labelStep5.Margin = new System.Windows.Forms.Padding(12, 0, 3, 15);
            this.labelStep5.Name = "labelStep5";
            this.labelStep5.Size = new System.Drawing.Size(65, 16);
            this.labelStep5.TabIndex = 7;
            this.labelStep5.Text = "Summary";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelCurrentTroopVisit);
            this.panel1.Controls.Add(this.labelHeading);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 60);
            this.panel1.TabIndex = 6;
            // 
            // labelCurrentTroopVisit
            // 
            this.labelCurrentTroopVisit.AutoSize = true;
            this.labelCurrentTroopVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTroopVisit.Location = new System.Drawing.Point(735, 5);
            this.labelCurrentTroopVisit.Name = "labelCurrentTroopVisit";
            this.labelCurrentTroopVisit.Size = new System.Drawing.Size(0, 24);
            this.labelCurrentTroopVisit.TabIndex = 3;
            this.labelCurrentTroopVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(25, 33);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(52, 16);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Daily Data Input";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(778, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(697, 7);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(616, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNext);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Location = new System.Drawing.Point(-9, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 44);
            this.panel2.TabIndex = 7;
            // 
            // wizardTabControl
            // 
            this.wizardTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.wizardTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardTabControl.Controls.Add(this.tabPageTroopVisitSelection);
            this.wizardTabControl.Controls.Add(this.tabPageTroopVisitDetails);
            this.wizardTabControl.Controls.Add(this.tabPageMissingIndividuals);
            this.wizardTabControl.Controls.Add(this.tabPageNewIndividuals);
            this.wizardTabControl.Controls.Add(this.tabPageReproductiveStates);
            this.wizardTabControl.Controls.Add(this.tabPageSummary);
            this.wizardTabControl.Location = new System.Drawing.Point(230, 61);
            this.wizardTabControl.Name = "wizardTabControl";
            this.wizardTabControl.Padding = new System.Drawing.Point(0, 0);
            this.wizardTabControl.SelectedIndex = 0;
            this.wizardTabControl.Size = new System.Drawing.Size(608, 423);
            this.wizardTabControl.TabIndex = 0;
            // 
            // tabPageTroopVisitSelection
            // 
            this.tabPageTroopVisitSelection.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTroopVisitSelection.Controls.Add(this.troopVisitSelectionWizardPage1);
            this.tabPageTroopVisitSelection.Location = new System.Drawing.Point(4, 4);
            this.tabPageTroopVisitSelection.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageTroopVisitSelection.Name = "tabPageTroopVisitSelection";
            this.tabPageTroopVisitSelection.Size = new System.Drawing.Size(600, 397);
            this.tabPageTroopVisitSelection.TabIndex = 6;
            this.tabPageTroopVisitSelection.Text = "tabPage0";
            // 
            // troopVisitSelectionWizardPage1
            // 
            this.troopVisitSelectionWizardPage1.AutoSize = true;
            this.troopVisitSelectionWizardPage1.BackColor = System.Drawing.SystemColors.Control;
            this.troopVisitSelectionWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.troopVisitSelectionWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.troopVisitSelectionWizardPage1.Margin = new System.Windows.Forms.Padding(0);
            this.troopVisitSelectionWizardPage1.Name = "troopVisitSelectionWizardPage1";
            this.troopVisitSelectionWizardPage1.Size = new System.Drawing.Size(600, 397);
            this.troopVisitSelectionWizardPage1.TabIndex = 0;
            // 
            // tabPageTroopVisitDetails
            // 
            this.tabPageTroopVisitDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTroopVisitDetails.Controls.Add(this.troopVisitWizardPage);
            this.tabPageTroopVisitDetails.Location = new System.Drawing.Point(4, 4);
            this.tabPageTroopVisitDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageTroopVisitDetails.Name = "tabPageTroopVisitDetails";
            this.tabPageTroopVisitDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTroopVisitDetails.Size = new System.Drawing.Size(600, 397);
            this.tabPageTroopVisitDetails.TabIndex = 0;
            this.tabPageTroopVisitDetails.Text = "tabPage1";
            // 
            // troopVisitWizardPage
            // 
            this.troopVisitWizardPage.BackColor = System.Drawing.SystemColors.Control;
            this.troopVisitWizardPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.troopVisitWizardPage.Location = new System.Drawing.Point(3, 3);
            this.troopVisitWizardPage.Name = "troopVisitWizardPage";
            this.troopVisitWizardPage.Size = new System.Drawing.Size(594, 391);
            this.troopVisitWizardPage.TabIndex = 0;
            // 
            // tabPageMissingIndividuals
            // 
            this.tabPageMissingIndividuals.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMissingIndividuals.Controls.Add(this.uncertainIndividualsWizardPage1);
            this.tabPageMissingIndividuals.Location = new System.Drawing.Point(4, 4);
            this.tabPageMissingIndividuals.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMissingIndividuals.Name = "tabPageMissingIndividuals";
            this.tabPageMissingIndividuals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMissingIndividuals.Size = new System.Drawing.Size(600, 397);
            this.tabPageMissingIndividuals.TabIndex = 2;
            this.tabPageMissingIndividuals.Text = "tabPage3";
            // 
            // uncertainIndividualsWizardPage1
            // 
            this.uncertainIndividualsWizardPage1.Location = new System.Drawing.Point(-3, -4);
            this.uncertainIndividualsWizardPage1.Name = "uncertainIndividualsWizardPage1";
            this.uncertainIndividualsWizardPage1.Padding = new System.Windows.Forms.Padding(3);
            this.uncertainIndividualsWizardPage1.Size = new System.Drawing.Size(600, 400);
            this.uncertainIndividualsWizardPage1.TabIndex = 0;
            // 
            // tabPageNewIndividuals
            // 
            this.tabPageNewIndividuals.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNewIndividuals.Controls.Add(this.newIndividualsWizardPage1);
            this.tabPageNewIndividuals.Location = new System.Drawing.Point(4, 4);
            this.tabPageNewIndividuals.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageNewIndividuals.Name = "tabPageNewIndividuals";
            this.tabPageNewIndividuals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewIndividuals.Size = new System.Drawing.Size(600, 397);
            this.tabPageNewIndividuals.TabIndex = 1;
            this.tabPageNewIndividuals.Text = "tabPage2";
            // 
            // newIndividualsWizardPage1
            // 
            this.newIndividualsWizardPage1.Location = new System.Drawing.Point(-3, -4);
            this.newIndividualsWizardPage1.Name = "newIndividualsWizardPage1";
            this.newIndividualsWizardPage1.Size = new System.Drawing.Size(600, 403);
            this.newIndividualsWizardPage1.TabIndex = 0;
            // 
            // tabPageReproductiveStates
            // 
            this.tabPageReproductiveStates.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageReproductiveStates.Controls.Add(this.reproductiveStateWizardPage1);
            this.tabPageReproductiveStates.Location = new System.Drawing.Point(4, 4);
            this.tabPageReproductiveStates.Name = "tabPageReproductiveStates";
            this.tabPageReproductiveStates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReproductiveStates.Size = new System.Drawing.Size(600, 397);
            this.tabPageReproductiveStates.TabIndex = 7;
            this.tabPageReproductiveStates.Text = "tabPage1";
            // 
            // reproductiveStateWizardPage1
            // 
            this.reproductiveStateWizardPage1.BackColor = System.Drawing.SystemColors.Control;
            this.reproductiveStateWizardPage1.Location = new System.Drawing.Point(0, -3);
            this.reproductiveStateWizardPage1.Name = "reproductiveStateWizardPage1";
            this.reproductiveStateWizardPage1.Size = new System.Drawing.Size(600, 400);
            this.reproductiveStateWizardPage1.TabIndex = 0;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSummary.Controls.Add(this.summaryWizardPage);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 4);
            this.tabPageSummary.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(600, 397);
            this.tabPageSummary.TabIndex = 5;
            this.tabPageSummary.Text = "tabPage6";
            // 
            // summaryWizardPage
            // 
            this.summaryWizardPage.Location = new System.Drawing.Point(-3, -3);
            this.summaryWizardPage.Name = "summaryWizardPage";
            this.summaryWizardPage.Size = new System.Drawing.Size(600, 400);
            this.summaryWizardPage.TabIndex = 0;
            // 
            // DailyInputWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(850, 552);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wizardTabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelSteps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyInputWizard";
            this.Text = "Daily Data Input";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanelSteps.ResumeLayout(false);
            this.flowLayoutPanelSteps.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.wizardTabControl.ResumeLayout(false);
            this.tabPageTroopVisitSelection.ResumeLayout(false);
            this.tabPageTroopVisitSelection.PerformLayout();
            this.tabPageTroopVisitDetails.ResumeLayout(false);
            this.tabPageMissingIndividuals.ResumeLayout(false);
            this.tabPageNewIndividuals.ResumeLayout(false);
            this.tabPageReproductiveStates.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelLoadTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSteps;
        private System.Windows.Forms.Label labelStep0;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.Label labelStep2;
        private System.Windows.Forms.Label labelStep3;
        private System.Windows.Forms.Label labelStep4;
        private System.Windows.Forms.Label labelStep5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCurrentTroopVisit;
        private System.Windows.Forms.TabPage tabPageSummary;
        private SummaryWizardPage summaryWizardPage;
        private System.Windows.Forms.TabPage tabPageReproductiveStates;
        private ReproductiveStateWizardPage reproductiveStateWizardPage1;
        private System.Windows.Forms.TabPage tabPageNewIndividuals;
        private NewIndividualsWizardPage newIndividualsWizardPage1;
        private System.Windows.Forms.TabPage tabPageMissingIndividuals;
        private MissingIndividualsWizardPage uncertainIndividualsWizardPage1;
        private System.Windows.Forms.TabPage tabPageTroopVisitDetails;
        private TroopVisitDetailsWizardPage troopVisitWizardPage;
        private System.Windows.Forms.TabPage tabPageTroopVisitSelection;
        private TroopVisitSelectionWizardPage troopVisitSelectionWizardPage1;
        private WizardTabControl wizardTabControl;
    }
}