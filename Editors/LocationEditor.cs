using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.SessionForms;
using NHibernate;
using TBPDatabase.Repositories;

namespace TBPDatabase.Editors
{
    public partial class LocationEditor : Form
    {
        private Location location;
        public Domain.Location TBPLocation
        {
            get { return location; }
        }
        
        public LocationEditor()
        {
            InitializeComponent();

            BindingList<Location.Type> locationTypes = new BindingList<Location.Type>();
            locationTypes.Add(Domain.Location.Type.O);
            locationTypes.Add(Domain.Location.Type.S);
            locationTypes.Add(Domain.Location.Type.W);

            //this.comboBoxLocationType.DataSource = locationTypes;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            if(id.Length < 2)
            {
                MessageBox.Show("The ID '" + id + "' is invalid (too short).");
                return;
            }
            if (id.Length > 8)
            {
                MessageBox.Show("The ID '" + id + "' is invalid (too long).");
                return;
            }

            // Check the database for a conflict
            ISession s = NHibernateHelper.OpenNewSession();
            ITransaction tx = s.BeginTransaction();
            Location current = s.Get<Location>(id);
            

            if (current != null)
            {
                MessageBox.Show("The ID '" + id + "' is invalid (already exists).");
                tx.Commit();
                NHibernateHelper.DisposeCurrentSession();
                return;
            }

            location = new Domain.Location();
            location.ID = textBoxId.Text;
            location.CommonName = textBoxCommonName.Text;
            location.LocationTypeEnum = Domain.Location.Type.S;
            location.Comments = textBoxComments.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            s.SaveOrUpdate(location);

            tx.Commit();
            NHibernateHelper.DisposeCurrentSession();
            this.Close();

        }




    }
}
