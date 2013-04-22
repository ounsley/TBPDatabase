using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class AgeClass : PersistentObject, IReference
    {
        public virtual string ID { get; set;}
        public virtual string Description{get;set;}
        public virtual bool Certain { get { return true; } }
        public virtual int Priority { get { return 0; } }

        public override string ToString()
        {
            return ID;
        }
    }
}
