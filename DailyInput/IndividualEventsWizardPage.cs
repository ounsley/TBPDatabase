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
    public partial class IndividualEventsWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;

        public IndividualEventsWizardPage()
        {
            InitializeComponent();
        }

        public bool CurrentlyValid
        {
            get { throw new NotImplementedException(); }
        }

        public string Heading
        {
            get { throw new NotImplementedException(); }
        }

        public void LoadData()
        {
            throw new NotImplementedException();
        }

        public bool Finish()
        {
            throw new NotImplementedException();
        }

        public void Selected()
        {
            throw new NotImplementedException();
        }
    }
}
