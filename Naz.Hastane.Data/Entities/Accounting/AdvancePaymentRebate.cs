using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class AdvancePaymentRebate {
        public AdvancePaymentRebate() { }

        public virtual AdvancePayment AdvancePayment { get; set; }
//        public virtual double AV_ID { get; set; }
        
        public virtual string IADEMAKNO { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            AdvancePaymentRebate apr = obj as AdvancePaymentRebate;
            if (apr == null)
                return false;
            if (this.AdvancePayment == apr.AdvancePayment && this.IADEMAKNO == apr.IADEMAKNO)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.AdvancePayment ? 0 : this.AdvancePayment.GetHashCode());
            hash += (null == this.IADEMAKNO ? 0 : this.IADEMAKNO.GetHashCode());

            return hash;
        }
    }
}
