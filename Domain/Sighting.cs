using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class Sighting: PersistentObject, IReference
    {
        public virtual string ID { get; set; }
        public virtual bool Inclusion { get; set; }
        public virtual bool Uncertain { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Certain { get { return !Uncertain; } }
        // Inclusions should take precidence of non inclusions
        public virtual int Priority { get { return (Inclusion ? 1 : 0); } }

        public override string ToString()
        {
            return ID;
        }

    }
}
