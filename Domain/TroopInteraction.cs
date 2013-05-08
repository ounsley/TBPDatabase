using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class TroopInteraction : PersistentObject, ITroopState<Interaction>
    {
        public virtual int ID { get; set; }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual Interaction Interaction { get; set; }
        public virtual Troop ForeignTroop { get; set; }
        public virtual Interaction State { get { return this.Interaction; } set { this.Interaction = value; } }
        public virtual DateTime? Time { get; set; }
        public virtual string Comments { get; set; }

        public override string ToString()
        {
            return this.Interaction.ToString();
        }
    }
}
