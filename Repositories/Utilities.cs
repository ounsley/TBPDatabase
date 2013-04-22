using System;
using System.Collections.Generic;

using NHibernate.Proxy;

namespace TBPDatabase.Repositories
{
    static class Utilities
    {
        public static IList<T> ToProxySafeList<T>(this IList<T> list)
        where T : class
        {
            if (list.Count == 0) return list;

            for (int i=0;i<list.Count;i++)
            {
                var proxy = list[i] as INHibernateProxy;

                if (proxy != null)
                {
                    list[i] = proxy.HibernateLazyInitializer.GetImplementation() as T;
                }
            }
            return list;
        }
    }
}
