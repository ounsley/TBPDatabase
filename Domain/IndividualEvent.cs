using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class IndividualEvent : PersistentObject, IIndividualState<Event>
    {
        public virtual int ID { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual Event Event { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual string TimeString { get { return this.Time != null?((DateTime)Time).ToShortTimeString():"null"; } }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual string Comments { get; set; }

        public virtual Event State { get { return this.Event; } set { this.Event = value; } }

        public override string ToString()
        {
            return Event.ToString();
        }
    }
}
