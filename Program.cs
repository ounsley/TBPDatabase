using System;
using System.Windows.Forms;

using TBPDatabase.SessionForms;
using System.IO;

namespace TBPDatabase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string logFileName = "ErrorLog"+DateTime.Today.Date.ToString("yyyyMMdd")+".txt";
            string logFilePath = "./Logs/Errors/";

            if (!Directory.Exists(logFilePath))
                Directory.CreateDirectory(logFilePath);

            StreamWriter logFile = new StreamWriter(logFilePath + logFileName,true);

            //try
            //{
                Application.Run(new TBPDatabaseForm());
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Whoops, something has gone wrong and the application needs to close. " +
            //        "The details have been written to " + logFilePath + logFileName + 
            //    ". If you are not Alex Lee, then please let him know that there is a problem with the database application." +
            //    " He may know what went wrong (though I doubt it)."
            //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    logFile.WriteLine(DateTime.Now.TimeOfDay + "\r\n" + e.ToString());
            //    logFile.Close();
            //}
        }
    }
}
