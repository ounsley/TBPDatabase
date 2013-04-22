using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class Troop : PersistentObject
    {
        public virtual string TroopID { get; set; }
        public virtual DateTime FirstTrapping {get;set;}
        public virtual string Comments { get; set; }

        public override string ToString()
        {
            return this.TroopID.ToString();
        }

    }
}
