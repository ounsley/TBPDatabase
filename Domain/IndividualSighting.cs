using System;
using System.Collections.Generic;

using TBPDatabase.Repositories;
using NHibernate;

namespace TBPDatabase.Domain
{
    public class IndividualSighting : PersistentObject, IIndividualState<Sighting>
    {
        public virtual int ID { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual TroopVisit TroopVisit { get; set; }
        public virtual Sighting Sighting { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual string Comments { get; set; }

        public virtual Sighting State
        {
            get { return this.Sighting; }
            set { this.Sighting = value; }
        }       

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
