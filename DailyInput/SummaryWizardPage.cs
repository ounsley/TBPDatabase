using System;
using System.Text;
using System.Windows.Forms;

using TBPDatabase.Domain;
using System.IO;

namespace TBPDatabase.DailyInput
{
    public partial class SummaryWizardPage : UserControl, IWizardPage
    {
        public event EventHandler ValidityChanged;
        public event EventHandler FinishedLoading;


        public bool CurrentlyValid
        {
            get { return true; }
        }

        public string Heading
        {
            get { return "Summary of all changes to be made to the database."; }
        }

        public SummaryWizardPage()
        {
            InitializeComponent();
            if (this.ValidityChanged != null)
                this.ValidityChanged(this, null);
        }

        public void LoadData()
        {

            textBox1.AppendText("Troop Visit Details" + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            textBox1.AppendText("Troop: " + DailyData.Current.TroopVisit.Troop.TroopID);
            textBox1.AppendText("\r\n");
            textBox1.AppendText("Date: " + DailyData.Current.TroopVisit.Date.ToShortDateString());
            textBox1.AppendText("\r\n");

            string p = "\r\nNew Individuals";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            StringBuilder sb = new StringBuilder();
            foreach (Individual i in DailyData.Current.NewIndividuals)
            {
                sb.Append("The new individual " + i.Name + " ");
                sb.Append(i.FirstSighting().Sighting.Description.ToLower() + " ");
                sb.AppendLine();
            }
            this.textBox1.AppendText(sb.ToString());

            p = "\r\n\r\nRemoved Individuals";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            sb = new StringBuilder();
            foreach (Individual i in DailyData.Current.IndividualsToDelete)
            {
                sb.Append("The new individual " + i.Name + " ");
                sb.Append(i.FirstSighting().Sighting.Description.ToLower() + " ");
                sb.AppendLine();
            }
            this.textBox1.AppendText(sb.ToString());

            p = "\r\n\r\nNew Sightings";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            foreach (IndividualSighting s in DailyData.Current.NewSightings)
                textBox1.AppendText(s.Individual.Name + " " + s.State.Description + " on " +
                s.TroopVisit.ToString() + "\r\n");

            p = "\r\n\r\nRemoved Sightings";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            foreach (IndividualSighting s in DailyData.Current.SightingsToDelete)
                textBox1.AppendText(s.Individual.Name + " " + s.State.Description + " on " +
                s.TroopVisit.ToString() + "\r\n");

            p = "\r\n\r\nNew Reproductive States";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            foreach (IndividualReproductiveState s in DailyData.Current.NewReproductiveStates)
                textBox1.AppendText(s.Individual.Name + " " + s.State.Description + " on " +
                s.TroopVisit.ToString() + "\r\n");
            
            p = "\r\n\r\nRemoved Reproductive States";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            foreach (IndividualReproductiveState s in DailyData.Current.ReproductiveStatesToDelete)
                textBox1.AppendText(s.Individual.Name + " " + s.State.Description + " on " +
                s.TroopVisit.ToString() + "\r\n");

            p = "\r\n\r\nNew Age Class";
            textBox1.AppendText(p + "\r\n");
            textBox1.AppendText("".PadRight(50, '-') + "\r\n");
            foreach (IndividualAgeClass s in DailyData.Current.NewAgeClass)
                textBox1.AppendText(s.Individual.Name + " " + s.State.Description + " on " +
                s.TroopVisit.ToString() + "\r\n");

            this.FinishedLoading(this, null);

        }

        public bool Finish()
        {
            textBox1.AppendText("\r\n\r\nSaving Changes...");

            try
            {
                DailyData.Current.Save();
            }
            catch (Exception e)
            {
                // Append to the summary log
                textBox1.AppendText("Failed!\r\n" + e.ToString());
                throw e; // Bubble up to the logging message
            }
            finally
            {
                // Always write the changes log file
                string logFileName = "ChangesLog" + DateTime.Today.Date.ToString("yyyyMMdd") + ".txt";
                string logFilePath = "./Logs/DailyChanges/";

                if (!Directory.Exists(logFilePath))
                    Directory.CreateDirectory(logFilePath);

                StreamWriter logFile = new StreamWriter(logFilePath + logFileName, true);
                logFile.WriteLine(textBox1.Text);
                logFile.Close();
            }

            return true;
        }

        public void Selected()
        {
        }
    }
}
