using System;

using TBPDatabase.Domain;
using TBPDatabase.Utilities;
using NHibernate;
using TBPDatabase.Repositories;
using System.Collections.Generic;

namespace TBPDatabase.DailyInput
{

    /// <summary>
    /// A singleton class to hold the data from the daily input wiizard
    /// </summary>
    public class DailyData
    {
        private static DailyData current;

        public static DailyData Current
        {
            get
            {
                if (current == null)
                {
                    current = new DailyData();
                }
                return current;
            }
        }

        public TroopVisit TroopVisit;
        public List<IndividualSighting> NewSightings;
        public List<Individual> NewIndividuals;
        public List<IndividualReproductiveState> NewReproductiveStates;
        public List<TroopVisitObserver> NewTroopVisitObservers;
        public List<Location> NewLocations = new List<Location>();
        public List<IndividualAgeClass> NewAgeClass = new List<IndividualAgeClass>();
        public List<IndividualSighting> SightingsToDelete = new List<IndividualSighting>();
        public List<Individual> IndividualsToDelete = new List<Individual>();
        public List<IndividualReproductiveState> ReproductiveStatesToDelete = new List<IndividualReproductiveState>();
        
        public bool RetrievedData = false;
        public List<Individual> MissingToday = new List<Individual>();
        public List<Individual> MigratedToday = new List<Individual>();

        private DailyData()
        {
            this.TroopVisit = new TroopVisit();
            this.NewSightings = new List<IndividualSighting>();
            this.NewIndividuals = new List<Individual>();
            this.NewReproductiveStates = new List<IndividualReproductiveState>();
            this.NewTroopVisitObservers = new List<TroopVisitObserver>();
        }

        public void Save()
        {
            // This should be called when all the steps in the wizard are complete
            NHibernateHelper.DisposeCurrentSession();
            ISession session = NHibernateHelper.OpenNewSession();
            ITransaction tx = session.BeginTransaction();

            foreach (Location l in NewLocations)
                session.SaveOrUpdate(l);
            session.SaveOrUpdate(current.TroopVisit);

            // Go through deletes first
            foreach (IndividualSighting s in SightingsToDelete)
            {
                // Quick check that the ID has been set, this is a bit 
                // nauhgty can't guarentee 0 is not valid,
                // but auto increment starts at 1 so should be fine
                if (s.ID != 0)
                    session.Delete(s);
            }
            foreach (IndividualReproductiveState irs in ReproductiveStatesToDelete)
            {
                if (irs.ID != 0)
                    session.Delete(irs);
            }
            foreach (Individual s in IndividualsToDelete)
            {
                    session.Delete(s);
            }
            

            foreach (Individual i in NewIndividuals)
                session.SaveOrUpdate(i);
            foreach (IndividualSighting s in NewSightings)
                session.SaveOrUpdate(s);
            foreach (TroopVisitObserver tvo in NewTroopVisitObservers)
                session.SaveOrUpdate(tvo);
            foreach (IndividualReproductiveState s in NewReproductiveStates)
                session.SaveOrUpdate(s);
            foreach (IndividualAgeClass iac in NewAgeClass)
                session.SaveOrUpdate(iac);
            

            tx.Commit();
            NHibernateHelper.DisposeCurrentSession();

        }
        public void Load(TroopVisit troopVisit)
        {
            RetrievedData = true;

            TroopVisit = troopVisit;

            // Load all the data with this troop visit reference
            ISession session = NHibernateHelper.GetCurrentSession();
            ITransaction tx = session.BeginTransaction();
            TroopVisit = session.Get<TroopVisit>(troopVisit.ID);
            NHibernateUtil.Initialize(TroopVisit.AMSleepingCliff);
            NHibernateUtil.Initialize(TroopVisit.PMSleepingCliff);
            tx.Commit();

        }

        public void Dispose()
        {
            current = null;
        }

    }
}
