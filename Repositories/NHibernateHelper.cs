using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;

namespace TBPDatabase.Repositories
{
    /// <summary>
    /// Singleton to manage a session factory;
    /// </summary>
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;
        private static ISession session;

        /// <summary>
        /// Only create session factory once (singleton)
        /// </summary>
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration
                        .AddAssembly(typeof(TBPDatabase.Domain.Individual).Assembly);

                    sessionFactory = configuration.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        private static ISession Session
        {
            get
            {
                if (session == null || !session.IsOpen)
                {
                    session = SessionFactory.OpenSession();
                }
                return session;
            }
        }


        public static ISession GetCurrentSession()
        {
            return Session;
        }

        public static void DisposeCurrentSession()
        {
            if (session != null && session.IsOpen)
            {
                Session.Close();
                Session.Dispose();
                session = null;
            }
        }

        public static ISession OpenNewSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
