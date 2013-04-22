using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class Observer: PersistentObject
    {
        public virtual string ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Comments { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
