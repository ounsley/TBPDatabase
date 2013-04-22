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
    public partial class FormReproductiveState : Form
    {
        string individualId;
        string state;
        MySqlConnection connection;
        List<string> stateLookup;

        public FormReproductiveState(string individualId, MySqlConnection connection)
        {
            InitializeComponent();

            this.individualId = individualId;
            this.connection = connection;
            this.stateLookup = new List<string>();

            FillComboBox();
        }

        private void FillComboBox()
        {
            string cmdText = "SELECT * FROM reproductive_states";
            MySqlCommand command = new MySqlCommand(cmdText, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int descriptionOrdinal = reader.GetOrdinal("description");
                int stateOrdinal = reader.GetOrdinal("state");
                
                this.comboBoxReproductiveState.Items.Add(reader.GetString(descriptionOrdinal));
                stateLookup.Add(reader.GetString(stateOrdinal));
            }
            reader.Close();
        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string cmdText = "INSERT INTO reproductive_state (individualId,state,startdate,comment) VALUES " +
                " ('"
                +this.individualId+"','"
                +this.state+"','"
                +this.dateTimePickerStartDate.Value.ToString("yyyy-MM-dd")+"','"
                +this.textBoxComments.Text+"')";
            MySqlCommand cmd = new MySqlCommand(cmdText, this.connection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error updating details " + exception.ToString());
            }
            this.Close();

            Close();
        }

        private void comboBoxReproductiveState_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.state = stateLookup[comboBoxReproductiveState.SelectedIndex];
        }
    }
}
