using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class TroopVisitObserver : PersistentObject
    {
        public virtual int ID { get; set; }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual Observer Observer { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
