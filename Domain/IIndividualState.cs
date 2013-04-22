using System;
using System.Collections.Generic;

namespace TBPDatabase.Domain
{
    /// <summary>
    /// Represents persistent objects that have a TroopVisit element
    /// and we may want to know things like, most recent.
    /// </summary>
    public interface IIndividualState<T>
        where T : IReference
    {
        TroopVisit TroopVisit { get; set; }
        Individual Individual { get; set; }
        T State { get; set; }
        string Comments { get; set; }
    }
}
