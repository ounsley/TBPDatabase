using System;
using System.Collections.Generic;

namespace TBPDatabase.Domain
{
    /// <summary>
    /// Represents persistent objects that have a TroopVisit element
    /// and we may want to know things like, most recent.
    /// </summary>
    public interface ITroopState<T>
        where T : IReference
    {
        int ID { get; set; }
        TroopVisit TroopVisit { get; set; }
        T State { get; set; }
        string Comments { get; set; }
    }
}
