using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TBPDatabase.Domain;
using NHibernate;
using System.Windows.Forms;

namespace TBPDatabase.Editors
{
    class InteractionEditor : StateEditor<IndividualInteraction, Interaction> 
    {
        DateTimePicker timePicker;
        ComboBox individualComboBox;

        public InteractionEditor(ISession session, Individual individual, IndividualInteraction individualInteraction = null)
            :base(session,individual,individualInteraction,"Select e from Interaction as e")
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

            this.individualComboBox = new ComboBox();
            this.individualComboBox.DataSource = Individual.LoadAll(session).FindAll(new Predicate<Individual>
                (x => x.ID != individual.ID));

            Label individualLabel = new Label();
            individualLabel.Text = "Individual";
            individualLabel.Margin = this.labelMargin;

            this.TableLayoutPanel.Controls.Add(individualLabel,0,InsertRowIndex);
            this.TableLayoutPanel.Controls.Add(individualComboBox,1,InsertRowIndex);
            this.TableLayoutPanel.SetColumnSpan(individualComboBox, 3);

            if (State != null)
            {
                if (State.Time != null)
                {
                    timePicker.Checked = true;
                    timePicker.Value = State.TroopVisit.Date + ((DateTime)State.Time).TimeOfDay;
                }
                else
                    timePicker.Checked = false;

                if (State.Individual2 != null)
                {
                    individualComboBox.SelectedItem = State.Individual2;
                }
            }
        }

        protected override void SetAdditionalValues()
        {
            base.SetAdditionalValues();
            if (timePicker.Checked)
                this.State.Time = State.TroopVisit.Date + timePicker.Value.TimeOfDay;
            this.State.Individual2 = (Individual)individualComboBox.SelectedItem;
        }

    }
}
