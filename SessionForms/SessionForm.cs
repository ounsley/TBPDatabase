using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using NHibernate;

namespace TBPDatabase.SessionForms
{
    /// <summary>
    /// A class to wrap transaction handling
    /// One session and transaction per form
    /// </summary>
    public class SessionForm : Form
    {
        ITransaction tx;
        private ISession session;
        protected ISession Session { get { return session; } }

        public SessionForm()
        {
            this.session = NHibernateHelper.OpenNewSession();
            this.tx = session.BeginTransaction();
            this.FormClosing += new FormClosingEventHandler(SessionForm_FormClosing);
        }

        void SessionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Only save on a OK dialog result
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.tx.Commit();
                    //this.session.Close();
                    NHibernateHelper.DisposeCurrentSession();
                    this.session = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Failed to update database", MessageBoxButtons.OK);
                }
            }
            else
            {
                // Don't save
                NHibernateHelper.DisposeCurrentSession();
                this.session = null;
            }
        }
    }
}
