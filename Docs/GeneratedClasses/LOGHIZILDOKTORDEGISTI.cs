using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LOGHIZILDOKTORDEGISTI {
        public LOGHIZILDOKTORDEGISTI() { }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual double SIRANO { get; set; }
        public virtual string AKOD { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string EARZT { get; set; }
        public virtual string YARZT { get; set; }
        public virtual string EARZT2 { get; set; }
        public virtual string YARZT2 { get; set; }
        public virtual double EADET { get; set; }
        public virtual System.Nullable<double> YADET { get; set; }
        public virtual double ESATISF { get; set; }
        public virtual double YSATISF { get; set; }
        public virtual double EKSATISF { get; set; }
        public virtual System.Nullable<double> YKSATISF { get; set; }
        public virtual System.DateTime ETARIH { get; set; }
        public virtual System.Nullable<System.DateTime> YTARIH { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
    }
}
