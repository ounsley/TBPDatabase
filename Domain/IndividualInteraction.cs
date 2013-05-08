using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class IndividualInteraction : PersistentObject, IIndividualState<Interaction>
    {
        public virtual int ID { get; set; }
        public virtual Individual Individual { get { return this.Individual1; } set { this.Individual1 = value; } }
        private Individual Individual1 { get; set; }
        public virtual Individual Individual2 { get; set; }
        public virtual Interaction Interaction { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual string TimeString { get { return this.Time != null ? ((DateTime)Time).ToShortTimeString() : "null"; } }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual string Comments { get; set; }

        public virtual Interaction State { get { return this.Interaction; } set { this.Interaction = value; } }

        public override string ToString()
        {
            return Interaction.ToString();
        }
    }
}
