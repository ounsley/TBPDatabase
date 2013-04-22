using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace TBPDatabase.DailyInput
{

    interface IWizardPage
    {
        event EventHandler ValidityChanged;
        event EventHandler FinishedLoading;
        //event EventHandler MessageUpdate;

        bool CurrentlyValid { get; }
        string Heading { get; }
        void LoadData();
        bool Finish();

        void Selected();
    }
}
