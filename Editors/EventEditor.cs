using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NHibernate;
using TBPDatabase.Domain;

namespace TBPDatabase.Editors
{
    class EventEditor : StateEditor<IndividualEvent,Event>
    {
        DateTimePicker timePicker;

        public EventEditor(ISession session, Individual individual, IndividualEvent individualEvent = null)
            :base(session,individual,individualEvent,"Select e from Event as e")
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
