using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class ProductOtherCode
    {
        public virtual string BUT { get; set; } // BUT; length(1); 1
        public virtual string CODE { get; set; } // CODE; length(15); 0
        public virtual string CODE1 { get; set; } // CODE1; length(15); 0
        public virtual string FIYLIST { get; set; } // FIYLIST; length(2); 0
        public virtual string GRUP { get; set; } // GRUP; length(3); 0
        public virtual string TANIM { get; set; } // TANIM; length(2); 0

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            ProductOtherCode pv = obj as ProductOtherCode;
            if (pv == null)
                return false;
            if (this.TANIM == pv.TANIM && this.GRUP == pv.GRUP && this.CODE == pv.CODE && this.FIYLIST == pv.FIYLIST)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.TANIM ? 0 : this.TANIM.GetHashCode());
            hash += (null == this.GRUP ? 0 : this.GRUP.GetHashCode());
            hash += (null == this.CODE ? 0 : this.CODE.GetHashCode());
            hash += (null == this.FIYLIST ? 0 : this.FIYLIST.GetHashCode());

            return hash;
        }
    }
}
