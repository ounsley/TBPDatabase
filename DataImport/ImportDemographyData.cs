using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.SessionForms;

namespace TBPDatabase.DataImport
{
    public partial class ImportDemographyDataForm : SessionForm
    {
        delegate void AddTextCallback(string text);
        delegate void StopCallback();
        private State state;
        private StreamReader fileStream;

        public enum State
        {
            Stopped,
            Running,
            Paused,
        }

        public ImportDemographyDataForm()
        {
            InitializeComponent();

            // Set up main processing thread
            this.state = ImportDemographyDataForm.State.Stopped;
            //this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void RunLoop()
        {
            // TO DO make the following not hard coded?
            // Variables for csv reading;
            bool header = true;
            int lineNo = 1;

            int columnIndividual = 1;
            int columnDate = 3;
            int columnEvent = 6;
            int columnComment = 7;

            List<IndividualReproductiveState> statesToInsert = new List<IndividualReproductiveState>();
            List<ReproductiveState> validReproductiveStates = new List<ReproductiveState>(Session
                    .CreateQuery("select s from ReproductiveState as s")
                    .List<ReproductiveState>());

            while (this.state != State.Stopped
                && this.fileStream != null
                && !this.fileStream.EndOfStream)
            {
                if (header)
                {
                    this.fileStream.ReadLine();
                    header = false;
                }

                // Do processing

                // Get the csv row
                string[] row = this.fileStream.ReadLine().Split(new char[] { ',' });
                lineNo++;

                // Find the event from the event column
                string demographyEvent = row[columnEvent];

                // Check to see if the event is in the list of reproductive states;
                // is so select it
                bool validEvent = false;
                ReproductiveState state = null;
                foreach (ReproductiveState rs in validReproductiveStates)
                {
                    if (rs.State == demographyEvent)
                    {
                        validEvent = true;
                        state = rs;
                        break;
                    }
                }

                if (validEvent)
                {
                    IndividualReproductiveState reproductiveState = new IndividualReproductiveState();

                    // Set the state
                    reproductiveState.State = state;

                    // Find the individual from the id column
                    reproductiveState.Individual = Session.Get<Individual>(row[columnIndividual]);

                    if (reproductiveState.Individual != null)
                    {

                        // Find the troop visit from the date column and the individual
                        DateTime date = DateTime.Parse(row[columnDate]);
                        Troop troop = reproductiveState.Individual.CurrentTroop(date);
                        if (troop != null)
                        {
                            string query = "Select tv from TroopVisit as tv where Troop = :troop and Date = :date";
                            reproductiveState.TroopVisit = Session
                                .CreateQuery(query)
                                .SetParameter<DateTime>("date", date)
                                .SetParameter<Troop>("troop", troop)
                                .UniqueResult<TroopVisit>();

                            // Find the comment from the comment column
                            reproductiveState.Comments = row[columnComment];

                            // INTEGRITY CHECK
                            // Quick check to make sure it is valid
                            if (reproductiveState.TroopVisit != null)
                            {
                                // Print some text and add the state to those to be inserted.
                                AddText("Found entry: " + reproductiveState.Individual.ToString() + " " +
                                    reproductiveState.ToString() + " " +
                                    reproductiveState.TroopVisit.ToString());
                                statesToInsert.Add(reproductiveState);

                                
                            }
                            else
                            {
                                this.AddText("Could not find TroopVisit for " + troop
                                + " on date " + date.ToShortDateString()
                                + " at line " + lineNo);
                            }
                        }
                        else
                        {
                            this.AddText("Could not find Troop for '" + reproductiveState.Individual.Name
                                + "(" + reproductiveState.ID + ") on date " + date.ToShortDateString() 
                                + " at line " + lineNo);
                        }

                    }
                    else
                    {
                        this.AddText("Could not find individual with ID '"+row[columnIndividual]+"' at line "+lineNo);
                    }


                }

                // Don't hog cpu
                Thread.Sleep(100);

                // Wait on paused
                while (this.state == State.Paused)
                    Thread.Sleep(50);
            }

            // Ask to begin insertion
            if (DialogResult.OK == MessageBox.Show("Found " + statesToInsert.Count
                + " valid entries from selected file. Click Ok to begin insert."
                , "Finished reading file", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
                , MessageBoxDefaultButton.Button2))
            {
                InsertEntries(statesToInsert);
            }
            StopCallback d = new StopCallback(Stop);
            Invoke(d);
        }

        private void InsertEntries(List<IndividualReproductiveState> statesToInsert)
        {
            this.AddText("Saving " + statesToInsert.Count + " entries");
            foreach(IndividualReproductiveState rs in statesToInsert)
            {
                try
                {
                    Session.SaveOrUpdate(rs);
                }
                catch (Exception e)
                {
                    this.AddText(e.Message);
                }
            }
        }

        private void AddText(string text)
        {
            // Was this call made on the thread that created the listview?
            if (this.listView1.InvokeRequired)
            {
                // If not we need to invoke a delegate on the creating thread
                // note the recursive call to this method.
                AddTextCallback d = new AddTextCallback(AddText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // The call was made on the creating thread (through invocation
                // of a delegate
                this.listView1.Items.Add(text);
                // Scroll to latest
                this.listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (this.state == State.Stopped)
            {
                this.Start();
            }
            else if (this.state == State.Running)
            {
                this.Pause();
            }
            else if (this.state == State.Paused)
            {
                this.Resume();
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.fileStream = new StreamReader(this.openFileDialog1.OpenFile());
                    this.buttonRun.Enabled = true;

                }
                catch (Exception exception)
                {
                    this.AddText(exception.Message);
                }

            }
        }

        private void Stop()
        {
            this.state = State.Stopped;
            this.buttonStop.Enabled = false;
            this.buttonRun.Text = "Run";
        }

        private void Start()
        {
            this.listView1.Items.Clear();
            Thread runLoop = new Thread(new ThreadStart(this.RunLoop));
            if (runLoop.ThreadState == ThreadState.Unstarted)
                runLoop.Start();

            this.Resume();
        }

        private void Pause()
        {
            this.state = State.Paused;
            this.buttonRun.Text = "Resume";
        }

        private void Resume()
        {
            this.state = State.Running;
            this.buttonRun.Text = "Pause";
            this.buttonStop.Enabled = true;
        }

    }
}
