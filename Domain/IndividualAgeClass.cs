using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class IndividualAgeClass : PersistentObject, IIndividualState<AgeClass>
    {
        public virtual int ID{get;set;}
        public virtual Individual Individual { get; set; }
        public virtual AgeClass AgeClass { get; set; }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual string Comments { get; set; }

        public virtual AgeClass State { get { return this.AgeClass; } set { this.AgeClass = value; } }

        public override string ToString()
        {
            return AgeClass.ToString();
        }
    }
}
