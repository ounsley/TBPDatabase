using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class TroopEvent : PersistentObject, ITroopState<Event>
    {
        public virtual int ID { get; set; }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual Event Event { get; set; }
        public virtual Event State { get { return this.Event; } set { this.Event = value; } }
        public virtual DateTime? Time { get; set; }

        public virtual string Comments { get; set; }

        public override string ToString()
        {
            return this.Event.ToString();
        }
    }
}
