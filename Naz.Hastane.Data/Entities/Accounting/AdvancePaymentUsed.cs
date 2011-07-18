namespace Naz.Hastane.Data.Entities 
{
    public class AdvancePaymentUsed 
    {
        public virtual AdvancePayment AdvancePayment { get; set; }
        //public virtual double AV_ID { get; set; }
        public virtual string FATURANO { get; set; }
        
        public virtual System.DateTime TARIH { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            AdvancePaymentUsed apu = obj as AdvancePaymentUsed;
            if (apu == null)
                return false;
            if (this.AdvancePayment == apu.AdvancePayment && this.FATURANO == apu.FATURANO)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.AdvancePayment ? 0 : this.AdvancePayment.GetHashCode());
            hash += (null == this.FATURANO ? 0 : this.FATURANO.GetHashCode());

            return hash;
        }
    }
}
