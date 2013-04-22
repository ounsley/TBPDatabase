using System;

using NHibernate;
using System.Collections.Generic;

namespace TBPDatabase.Domain
{
    public class TroopVisit: PersistentObject, IComparable<TroopVisit>
    {
        public virtual int ID { get; set; }
        public virtual Troop Troop { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Location AMSleepingCliff { get; set; }
        public virtual Location PMSleepingCliff { get; set; }
        public virtual bool Water { get; set; }
        public virtual bool FullDayFollow { get; set; }
        public virtual bool GPSRoute { get; set; }
        public virtual float Distance { get; set; }
        public virtual string Comments { get; set; }
        public virtual ICollection<TroopVisitObserver> Observers { get; set; }

        public override string ToString()
        {
            return Troop + " " + Date.ToShortDateString();
        }

        public override int CompareTo(object obj)
        {
            if (obj.GetType() == typeof(TroopVisit))
                return this.Date.CompareTo(((TroopVisit)obj).Date);
            else
                return base.CompareTo(obj);
        }
        
        public virtual int CompareTo(TroopVisit other)
        {
            if (this.Date == other.Date)
                return this.Troop.CompareTo(other.Troop);
            else
                return this.Date.CompareTo(other.Date);
        }
    }
}
