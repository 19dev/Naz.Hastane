using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LOGHIZILDELETED {
        public LOGHIZILDELETED() { }
        public virtual int HD_ID { get; set; }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual double SIRANO { get; set; }
        public virtual string AKOD { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string ARZT { get; set; }
        public virtual string ARZT2 { get; set; }
        public virtual double ADET { get; set; }
        public virtual string UNITE { get; set; }
        public virtual string NAME1 { get; set; }
        public virtual double SATISF { get; set; }
        public virtual double KSATISF { get; set; }
        public virtual System.Nullable<double> DSATISF { get; set; }
        public virtual double KDV { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual string PSG { get; set; }
        public virtual System.Nullable<short> HZLNO { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public virtual string MAKNO { get; set; }
        public virtual string KFATNO { get; set; }
        public virtual string FATURAEDILSIN { get; set; }
        public virtual string ISLENDIMI { get; set; }
        public virtual string PAKET { get; set; }
        public virtual string LRGOR { get; set; }
        public virtual string BUTCODE { get; set; }
        public virtual string BUTNAME { get; set; }
        public virtual System.Nullable<double> ESKI_SATISF { get; set; }
        public virtual string KABUL { get; set; }
        public virtual string ISODENDI { get; set; }
        public virtual System.Nullable<double> CARIFIYAT { get; set; }
        public virtual System.Nullable<System.DateTime> ODEMETARIHI { get; set; }
        public virtual string ISDURUM { get; set; }
        public virtual string PSEANS { get; set; }
        public virtual string SAGSOL { get; set; }
        public virtual string EUSCORE { get; set; }
        public virtual string HMAKNO { get; set; }
        public virtual string HODENDI { get; set; }
        public virtual string AMAKNO { get; set; }
        public virtual System.Nullable<System.DateTime> HYATISTARIHI { get; set; }
        public virtual System.Nullable<System.DateTime> HCIKISTARIHI { get; set; }
        public virtual string REFGUNSAY { get; set; }
        public virtual string ISLEMSIRANO { get; set; }
        public virtual string MEDSIRANO { get; set; }
        public virtual string MEDONAY { get; set; }
        public virtual System.Nullable<double> MEDTUTAR { get; set; }
        public virtual string TBASLANGICSAATI { get; set; }
        public virtual string TBITISSAATI { get; set; }
        public virtual string MEDOZDURUM { get; set; }
        public virtual string MEDANOMALI { get; set; }
        public virtual System.Nullable<int> TG { get; set; }
        public virtual System.Nullable<int> SAAT { get; set; }
        public virtual string USER_ID_DELETED { get; set; }
        public virtual System.DateTime DATE_DELETED { get; set; }
    }
}
