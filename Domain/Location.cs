using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBPDatabase.Domain
{
    public class Location : PersistentObject, IReference
    {
        public enum Type { S, W, O };

        public virtual string ID { get; set; }
        public virtual string CommonName { get; set; }
        public virtual string GPS { get; set; }
        public virtual string LocationType { get; set; }
        public virtual Type LocationTypeEnum { get { return (Type)Enum.Parse(typeof(Type), LocationType); } set { this.LocationType = value.ToString(); } }
        public virtual string Comments { get; set; }
        public virtual string Description { get { return CommonName; } set { CommonName = value; } }
        public virtual bool Certain { get { return true; } }
        public virtual int Priority { get { return 0; } }

        public override string ToString()
        {
            return ID;
        }


    }
}
