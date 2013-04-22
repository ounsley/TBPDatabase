using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class IndividualReproductiveState : PersistentObject, IIndividualState<ReproductiveState>
    {
        public virtual int ID { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual ReproductiveState State { get; set; }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual string Comments { get; set; }

        /*public override string GetDescription()
        {
            return ID.ToString();
        }*/

        public override string ToString()
        {
            return State.ToString();
        }
    }
}
