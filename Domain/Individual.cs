using System;
using System.Collections;
using System.Collections.Generic;
using Iesi.Collections.Generic;

using NHibernate;
using TBPDatabase.Utilities;
using NHibernate.Transform;

namespace TBPDatabase.Domain
{
    [System.ComponentModel.DefaultBindingProperty("Name")]
    public class Individual : PersistentObject
    {
        private static string SELECT_QUERY = "select i from Individual as i " +
               "left join fetch i.ReproductiveStateHistory as irs " +
                "left join fetch irs.TroopVisit as tv " +
                "left join fetch tv.Observers " +
                "left join fetch irs.State " +
                "left join fetch i.SightingHistory as tcs " +
                "left join fetch tcs.TroopVisit as tcstv " +
                "left join fetch tcstv.Observers " +
                "left join fetch i.AgeClassHistory as ach " +
                "left join fetch tcs.TroopVisit as achtv " +
                "left join fetch achtv.Observers " +
                "left join fetch ach.AgeClass " +
                "left join fetch i.Mother ";

        private string sex { get; set; }
        public enum SexEnum { M, F };
        public virtual string ID { get; set; }

        public virtual string Name { get; set; }
        public virtual SexEnum Sex { get { return (SexEnum)Enum.Parse(typeof(SexEnum), sex); } set { this.sex = value.ToString(); } }
        public virtual DateTime? DateNotched { get; set; }
        public virtual string TrappingID { get; set; }
        public virtual bool RightTop { get; set; }
        public virtual bool RightMiddle { get; set; }
        public virtual bool RightBottom { get; set; }
        public virtual bool LeftTop { get; set; }
        public virtual bool LeftMiddle { get; set; }
        public virtual bool LeftBottom { get; set; }
        public virtual string IDNote { get; set; }
        public virtual Individual Mother { get; set; }
        public virtual DateTime? ActualDOB { get; set; }
        public virtual DateTime? FieldEstimatedDOB { get; set; }
        public virtual DateTime? TrappingEstimatedDOB { get; set; }
        public virtual string Comment { get; set; }

        public virtual ICollection<IndividualReproductiveState> ReproductiveStateHistory { get; set; }
        public virtual ICollection<IndividualSighting> SightingHistory { get; set; }
        public virtual ICollection<IndividualAgeClass> AgeClassHistory { get; set; }

        public Individual()
        {
            // Create history collections
            this.SightingHistory = new SortableBindingList<IndividualSighting>();
            this.AgeClassHistory = new SortableBindingList<IndividualAgeClass>();
            this.ReproductiveStateHistory = new SortableBindingList<IndividualReproductiveState>();
        }

        public virtual IndividualSighting CurrentSighting(DateTime dateTime, bool certainOnly = false)
        {
            return StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetCurrentOnDate(dateTime, this.SightingHistory, certainOnly);
        }

        public virtual IndividualSighting CurrentSighting(TroopVisit troopVisit, bool certainOnly = false)
        {
            return StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetCurrentOnTroopVisit(troopVisit, this.SightingHistory, certainOnly);
        }

        public virtual IndividualSighting PreviousUncertainOrCurrent(TroopVisit troopVisit, bool forToday)
        {
            IndividualSighting sighting = null;
            if (forToday)
            {
                // Lets get the most recent entry
                sighting = StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetCurrentOnTroopVisit(troopVisit, this.SightingHistory, false);

                // If the value returned is not for today,
                // we want to get the last certain entry only as uncertain entries
                // do not apply for today anymore
                if(sighting != null &&
                    sighting.State.Certain == false && 
                    sighting.TroopVisit.Date.Date != troopVisit.Date.Date)
                    sighting = StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetCurrentOnTroopVisit(troopVisit, this.SightingHistory, true);
            }
            else// We are looking for the result for the last troop visit
                // Uncertain or otherwise
                sighting = StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetCurrentOnTroopVisit(troopVisit, this.SightingHistory, false);
            return sighting;
        }

        /// <summary>
        /// Is caluclated for each call, store locally if referenced
        /// often
        /// </summary>
        public virtual Troop CurrentTroop(DateTime? date = null)
        {
            Troop currentTroop = null;
            DateTime nonNull = DateTime.Today;
            if(date != null)
                nonNull = (DateTime)date;

            IndividualSighting s = StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetCurrentOnDate(nonNull, this.SightingHistory, true);

            if (s != null && s.Sighting.Inclusion)
                currentTroop = s.TroopVisit.Troop;

            return currentTroop;
        }

        /// <summary>
        /// Is caluclated for each call, store locally if referenced
        /// often
        /// </summary>
        public virtual IndividualReproductiveState CurrentReproductiveState(DateTime date)
        {
            return StatePersistentObjectHandler<IndividualReproductiveState, ReproductiveState>
                .GetCurrentOnDate(date, this.ReproductiveStateHistory);
        }

        /// <summary>
        /// Is caluclated for each call, store locally if referenced
        /// often
        public virtual IndividualAgeClass CurrentAgeClass(DateTime? date = null)
        {
            DateTime nonNull = DateTime.Today;
            if (date != null)
                nonNull = (DateTime)date;
            return StatePersistentObjectHandler<IndividualAgeClass, AgeClass>
                .GetCurrentOnDate(DateTime.Today, this.AgeClassHistory);
        }

        public virtual TroopVisit TroopVisitFirstObserved()
        {
            return FirstSighting().TroopVisit;
        }

        public virtual IndividualSighting FirstSighting()
        {
            return StatePersistentObjectHandler<IndividualSighting, Sighting>
                .GetFirst(this.SightingHistory);
        }

        public virtual IndividualAgeClass FirstAgeClass()
        {
            return StatePersistentObjectHandler<IndividualAgeClass, AgeClass>
                .GetFirst(this.AgeClassHistory);
        }

        public override string ToString()
        {
            return Name;
        }

        public static Individual LoadIndividual(ISession session, Individual individual)
        {
            return session.CreateQuery(SELECT_QUERY +
                "where i = :individual")
                .SetParameter<Individual>("individual", individual)
                // This stops multiple instances of the same individual being returned
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .UniqueResult<Individual>();
        }

        public static List<Individual> LoadAll(ISession session)
        {
            return (List<Individual>)session.CreateQuery(SELECT_QUERY)
                // This stops multiple instances of the same individual being returned
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .List<Individual>();
        }

        public static List<Individual> LoadAllFemales(ISession session)
        {
            return (List<Individual>)session.CreateQuery(SELECT_QUERY + 
                "where i.sex = 'F'")
                // This stops multiple instances of the same individual being returned
                .SetResultTransformer(new DistinctRootEntityResultTransformer())
                .List<Individual>();
        }

        public static string GenerateNewId(List<Individual> individuals, TroopVisit troopVisit, Individual.SexEnum sex)
        {
            // ID should be of the form "U" troopid sex number
            string newId = "U" + troopVisit.Troop.TroopID + sex.ToString();

            //Determine the highest number for this troop + sex combination
            int number = 0;

            foreach (Individual i in individuals)
            {
                if (i.ID.StartsWith(newId))
                {
                    int idNumber = int.Parse(i.ID.Substring(3, 2));
                    if (number <= idNumber)
                    {
                        number = idNumber + 1;
                    }
                }
            }
            return newId + number.ToString("D2");
        }

        public static string GenerateNewTrappingId(List<Individual> individuals, TroopVisit troopVisit, Individual.SexEnum sex)
        {
            // ID should be of the form troopid sex number
            string newId = troopVisit.Troop.TroopID + sex.ToString();

            //Determine the highest number for this troop + sex combination
            int number = 0;

            foreach (Individual i in individuals)
            {
                if (i.ID.StartsWith(newId))
                {
                    int idNumber = int.Parse(i.ID.Substring(2, 2));
                    if (number <= idNumber)
                    {
                        number = idNumber + 1;
                    }
                }
            }
            return newId + number.ToString("D2");
        }

    }
}
