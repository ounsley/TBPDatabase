using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public interface IReference
    {
        string ID { get; set; }
        string Description { get; set; }
        bool Certain { get; }
        // Determines which values takes precidence if multiple
        // references fall on the same day.
        int Priority { get; }
    }
}
