using System.Collections.Generic;

namespace Naz.Hastane.Data.Entities {
    
    public class AdvancePayment {

        public AdvancePayment() { }
        
        public virtual double AV_ID { get; set; }

        public virtual PatientVisit PatientVisit { get; set; }
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        
        public virtual System.DateTime TARIH { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual double KULLANILAN { get; set; }
        public virtual double IADEEDILEN { get; set; }
        public virtual string ODEMESEKLI { get; set; }
        public virtual string POSNO { get; set; }
        public virtual string MAKNO { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public virtual string HESAPKODU { get; set; }
        public virtual string ALTHESAPKODU { get; set; }
        public virtual string TIPI { get; set; }
        public virtual string AFATNO { get; set; }
        public virtual System.Nullable<double> KALAN { get; set; }
        public virtual string AMAKNO { get; set; }

        private IList<AdvancePaymentRebate> _AdvancePaymentRebates = new List<AdvancePaymentRebate>();

        public virtual IList<AdvancePaymentRebate> AdvancePaymentRebates
        {
            get { return _AdvancePaymentRebates; }
            set { _AdvancePaymentRebates = value; }
        }

        public virtual void AddAdvancePaymentRebate(AdvancePaymentRebate apr)
        {
            apr.AdvancePayment = this;
            this.AdvancePaymentRebates.Insert(0, apr);
        }

        private IList<AdvancePaymentUsed> _AdvancePaymentUseds = new List<AdvancePaymentUsed>();

        public virtual IList<AdvancePaymentUsed> AdvancePaymentUseds
        {
            get { return _AdvancePaymentUseds; }
            set { _AdvancePaymentUseds = value; }
        }

        public virtual void AddAdvancePaymentUsed(AdvancePaymentUsed apu)
        {
            apu.AdvancePayment = this;
            this.AdvancePaymentUseds.Insert(0, apu);
        }

    }
}
