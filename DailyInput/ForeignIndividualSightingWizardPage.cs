using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TBPDatabase.DailyInput
{
    public partial class ForeignIndividualSightingWizardPage : MissingIndividualsWizardPage
    {
        public ForeignIndividualSightingWizardPage()
        {
            // We want seen
            this.sightingTypeId = "S";
            this.heading = "Update the status of foreign individuals that have" +
            " recently been seen with this troop, and add foreign individuals seen today.";
            this.listIndividualsFromTroop = false;

            InitializeComponent();
        }
    }
}
