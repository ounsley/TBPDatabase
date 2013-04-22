using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TBPDatabase.Controls
{
    class TimeControl : PropertyControl<DateTime>
    {
        DateTimePicker timePicker;

        public TimeControl(DateTime time):base()
        {
            this.timePicker = new DateTimePicker();
            this.timePicker.Format = DateTimePickerFormat.Time;
            this.timePicker.Width = 80;
            if (time != null)
                this.timePicker.Value = DateTime.Today + time.TimeOfDay;

            this.Controls.Add(new TBPLabel("Time"));
            this.Controls.Add(timePicker);
        }

        public override DateTime GetProperty()
        {
            return timePicker.Value;
        }
    }
}
