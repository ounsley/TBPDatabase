using System;
using System.Windows.Forms;

using TBPDatabase.Repositories;
using TBPDatabase.Domain;
using TBPDatabase.SessionForms;
using NHibernate;

namespace TBPDatabase.Editors
{ 
    public class ReproductiveStateEditor : StateEditor<IndividualReproductiveState,ReproductiveState>
    {
        DateTimePicker timePicker;

        public ReproductiveStateEditor(ISession session,
            Individual individual,
            IndividualReproductiveState _individualReproductiveState = null)
            : base(session, individual, _individualReproductiveState,
            "select s from ReproductiveState as s")
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
            if(timePicker.Checked)
                this.State.Time = State.TroopVisit.Date + timePicker.Value.TimeOfDay;
        }

    }
}
