using System;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public class OldLookUpBase
    {
        public virtual string ID0 { get; set; }
        public virtual string ID { get; set; }
        public virtual string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            OldLookUpBase lb = obj as OldLookUpBase;
            if (lb == null)
                return false;
            if (this.ID0 == lb.ID0 && this.ID == lb.ID)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.ID0 ? 0 : this.ID0.GetHashCode());
            hash += (null == this.ID ? 0 : this.ID.GetHashCode());

            return hash;
        }
    }
}
