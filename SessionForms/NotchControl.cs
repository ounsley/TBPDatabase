using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using TBPDatabase.Domain;

namespace TBPDatabase.SessionForms
{
    [DefaultBindingProperty("Individual")]
    public partial class NotchControl : UserControl
    {
        public NotchControl()
        {
            InitializeComponent();
        }

        public void SetIndividual(Individual individual)
        {
            this.labelRightTop.Visible = individual.RightTop;
            this.labelRightMiddle.Visible = individual.RightMiddle;
            this.labelRightBottom.Visible = individual.RightBottom;
            this.labelLeftTop.Visible = individual.LeftTop;
            this.labelLeftMiddle.Visible = individual.LeftMiddle;
            this.labelLeftBottom.Visible = individual.LeftBottom;
        }


        
    }
}
