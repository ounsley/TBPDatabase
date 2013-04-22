using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Controls;

namespace TBPDatabase.Forms
{
    abstract class PersistentObjectEditor<T>:Form where T : PersistentObject
    {
        Button okButton;
        Button cancelButton;
        // Holds buttons
        FlowLayoutPanel buttonPanel;
        // Holds button and property panels
        FlowLayoutPanel layoutPanel;

        // Holds property controls
        protected FlowLayoutPanel propertyPanel;
        protected T persistentObject;

        public PersistentObjectEditor(T persistentObject)
        {
            this.persistentObject = persistentObject;

            this.okButton = new Button();
            this.okButton.Text = "Ok";
            this.AcceptButton = okButton;
            this.okButton.Click += new EventHandler(okButton_Click);

            this.cancelButton = new Button();
            this.cancelButton.Text = "Cancel";
            this.CancelButton = cancelButton;
            this.cancelButton.Click += new EventHandler(cancelButton_Click);

            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            
            this.propertyPanel = new FlowLayoutPanel();
            this.propertyPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.propertyPanel.AutoSize = true;
            this.propertyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.layoutPanel = new FlowLayoutPanel();
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.buttonPanel = new FlowLayoutPanel();
            this.buttonPanel.FlowDirection = FlowDirection.RightToLeft;
            this.buttonPanel.AutoSize = true;
            this.buttonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPanel.Dock = DockStyle.Right;

            this.buttonPanel.Controls.AddRange(new Control[] { cancelButton,okButton });
            this.layoutPanel.Controls.AddRange(new Control[] { propertyPanel, buttonPanel });
            this.Controls.Add(layoutPanel);
        }

        void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void okButton_Click(object sender, EventArgs e)
        {
            UpdatePersistentObject();
            Close();
        }

        public abstract void UpdatePersistentObject();
        
    }
}
