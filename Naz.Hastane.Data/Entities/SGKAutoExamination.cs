using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class SGKAutoExamination {
        public virtual string SERVISKODU { get; set; }
        public virtual Product Product { get; set; }
        public virtual string KATILIM { get; set; }
        public virtual string AYKATILIM { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            SGKAutoExamination pv = obj as SGKAutoExamination;
            if (pv == null)
                return false;
            if (this.SERVISKODU == pv.SERVISKODU && this.Product == pv.Product)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.SERVISKODU ? 0 : this.SERVISKODU.GetHashCode());
            hash += (null == this.Product ? 0 : this.Product.GetHashCode());

            return hash;
        }

    }
}
