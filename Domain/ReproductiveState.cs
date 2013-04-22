using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class ReproductiveState: PersistentObject, IReference
    {
        public virtual string State{get;set;}
        public virtual string Description { get; set; }
        public virtual string ID { get { return State; } set { State = value; } }
        public virtual bool Certain { get { return true; } }
        public virtual bool Event { get {return true; }}
        // Events are of lower priority than other states
        public virtual int Priority { get { return (Event ? 0 : 1); } }

        public override string ToString()
        {
            return State;
        }

        
    }
}
