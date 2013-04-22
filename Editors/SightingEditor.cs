using System;
using System.Windows.Forms;

using TBPDatabase.Domain;
using TBPDatabase.Repositories;
using TBPDatabase.SessionForms;
using NHibernate;

namespace TBPDatabase.Editors
{
    /// <summary>
    /// A dialog to edit or create a new IndividualTroopSighting entry for an
    /// Individual
    /// </summary>
    public class SightingEditor : StateEditor<IndividualSighting,Sighting>
    {
        DateTimePicker timePicker;

        public SightingEditor(ISession session,
            Individual individual,
            IndividualSighting individualSighting = null)
            : base(session, individual, individualSighting,
            "select s from Sighting as s",false)
        {
            this.timePicker = new DateTimePicker();
            this.timePicker.Format = DateTimePickerFormat.Time;
            this.timePicker.ShowCheckBox = true;
            this.timePicker.Checked = false;

            Label timeLabel = new Label();
            timeLabel.Text = "Time:";
            timeLabel.Margin = this.labelMargin;

            this.TableLayoutPanel.Controls.Add(timeLabel);
            this.TableLayoutPanel.Controls.Add(timePicker);
            this.TableLayoutPanel.SetColumnSpan(timePicker, 3);

            if (State != null)
            {
                if (State.Time != null)
                {
                    timePicker.Checked = true;
                    timePicker.Value = State.TroopVisit.Date + ((DateTime)State.Time).TimeOfDay;
                }
                else
                    timePicker.Checked = false;
            }
        }

        protected override void SetAdditionalValues()
        {
            base.SetAdditionalValues();
            if (timePicker.Checked)
                this.State.Time = State.TroopVisit.Date + timePicker.Value.TimeOfDay;
        }

    }
}
