using System;
using System.Collections.Generic;
using System.Reflection;

namespace TBPDatabase.Domain
{
    public abstract class PersistentObject : IComparable<string>, IComparable
    {
        public static T CreateInstance<T>() where T : PersistentObject, new()
        {
            T instance = new T();
            return instance;
        }


        /// <summary>
        /// Returns a brief summary of the Persistent object useful for text cells.
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        public virtual int CompareTo(string other)
        {
            return this.ToString().CompareTo(other);
        }

        public virtual int CompareTo(object obj)
        {
            if (obj != null)
                return this.ToString().CompareTo(obj.ToString());
            return 1;
        }
    }
}
