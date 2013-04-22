using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace TBPDatabase
{
    public partial class FormTroopMembershipUpdate : Form
    {
        string individualId;
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dataReader;
        DateTime currentStartDate;

        public FormTroopMembershipUpdate(string individualId, DateTime startDate, MySqlConnection connection)
        {
            InitializeComponent();

            this.individualId = individualId;
            this.connection = connection;
            this.dateTimePickerStartDate.Value = startDate.AddDays(1);


            this.Text = "Troop Membership Update - " + individualId;
            FillComboBox();
        }

        private void FillComboBox()
        {

            this.command = new MySqlCommand("SELECT troopId FROM troop", connection);
            this.dataReader = this.command.ExecuteReader();

            while (dataReader.Read())
            {
                int troopIdOrdinal = dataReader.GetOrdinal("troopid");
                this.comboBoxTroopId.Items.Add(dataReader.GetString(troopIdOrdinal));
            }
            dataReader.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string cmdStr = "INSERT INTO troop_membership (TroopId,IndividualId,StartDate,EndDate,Comments) "+
                "VALUES ('"+this.comboBoxTroopId.Text+"','"+this.individualId+"','"+
                this.dateTimePickerStartDate.Value.ToString("yyyy-MM-dd")+"',NULL,'"+this.textBoxComments.Text+"') " +
                "ON DUPLICATE KEY UPDATE TroopId = '"+this.comboBoxTroopId.Text+"', Comments = '"+this.textBoxComments.Text+"'";
            command = new MySqlCommand(cmdStr,this.connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error updating details " + exception.ToString());
            }
            this.Close();
        }
    }
}
