using System;
using System.Collections.Generic;
using System.Linq;

using TBPDatabase.Domain;

namespace TBPDatabase.Utilities
{
    public class StatePersistentObjectHandler<T,S> where T: IIndividualState<S> where S:IReference
    {
        /// <summary>
        /// Will get the most recent entry in collection
        /// for the date provided regardless of troop. This is not
        /// necessarily unique for Sigtings as an individual can be seen in
        /// multiple troops on the same day. Retrieving only a certain entry
        /// if specified.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="collection"></param>
        /// <param name="certainOnly"></param>
        /// <returns></returns>
        public static T GetCurrentOnDate(DateTime date, ICollection<T> collection, bool certainOnly = false)
        {
            T mostRecent = default(T);
            foreach (T a in collection)
            {
                if (a.TroopVisit.Date <= date &&
                    (certainOnly == false || a.State.Certain))
                {
                    if (mostRecent == null || mostRecent.TroopVisit.Date < a.TroopVisit.Date ||
                        (mostRecent.TroopVisit.Date == a.TroopVisit.Date && mostRecent.State.Priority < a.State.Priority))
                        mostRecent = a;
                }
            }
            return mostRecent;
        }

        /// <summary>
        /// Will get the most recent entry in collection 
        /// before the troopVisit date that is for the troopVisit troop
        /// retireving only a certain entry if specified.
        /// </summary>
        /// <param name="troopVisit"></param>
        /// <param name="collection"></param>
        /// <param name="certainOnly"></param>
        /// <returns></returns>
        public static T GetCurrentOnTroopVisit(TroopVisit troopVisit, ICollection<T> collection, bool certainOnly = false)
        {
            T mostRecent = default(T);
            foreach (T a in collection)
            {
                if (a.TroopVisit.Troop.TroopID == troopVisit.Troop.TroopID &&
                    a.TroopVisit.Date <= troopVisit.Date &&
                    (certainOnly == false || a.State.Certain))
                {
                    if (mostRecent == null || mostRecent.TroopVisit.Date < a.TroopVisit.Date ||
                        (mostRecent.TroopVisit.Date == a.TroopVisit.Date && mostRecent.State.Priority < a.State.Priority))
                        mostRecent = a;
                }
            }
            return mostRecent;
        }

        /// <summary>
        /// Get the earliest entry in the collection
        /// should be unique!
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        internal static T GetFirst(ICollection<T> collection)
        {
            T first = default(T);
            foreach (T a in collection)
            {
                if (first == null || first.TroopVisit.Date > a.TroopVisit.Date)
                    first = a;
            }
            return first;
        }
    }
}
