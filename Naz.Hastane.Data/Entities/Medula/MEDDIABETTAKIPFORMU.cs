using System.Collections.Generic;
using System.Text;
using System;


namespace Naz.Hastane.Data.Entities
{

    public class MEDDIABETTAKIPFORMU : PatientVisitExtraBase
    {

        public MEDDIABETTAKIPFORMU() { }

        //public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        public virtual string TCKIMLIKNO { get; set; }
        public virtual string AD { get; set; }
        public virtual string SOYAD { get; set; }
        public virtual string CEPTEL { get; set; }
        public virtual string PROTOKOLNO { get; set; }
        public virtual System.Nullable<System.DateTime> VIZITTARIHI { get; set; }
        public virtual System.Nullable<int> SAGLIKTESISKODU { get; set; }
        public virtual string CINSIYET { get; set; }
        public virtual System.Nullable<int> IKAMETTURU { get; set; }
        public virtual string ICD10TANI { get; set; }
        public virtual System.Nullable<System.DateTime> TANITARIHI { get; set; }
        public virtual System.Nullable<int> TIBBIBESLENMETEDAVISI { get; set; }
        public virtual System.Nullable<int> EGZERSIZ { get; set; }
        public virtual System.Nullable<int> BASVURUNEDENI { get; set; }
        public virtual string GLUKOMETRE { get; set; }
        public virtual System.Nullable<int> KANSEKERITAKIPSAYISI { get; set; }
        public virtual System.Nullable<int> SISTOLIKKANBASINICI { get; set; }
        public virtual System.Nullable<int> DIYOSTOLIKKANBASINCI { get; set; }
        public virtual string BOY { get; set; }
        public virtual string KILO { get; set; }
        public virtual string VKI { get; set; }
        public virtual string APG { get; set; }
        public virtual string TPG { get; set; }
        public virtual string HBA1C { get; set; }
        public virtual string KREATININ { get; set; }
        public virtual string TRIGLISERID { get; set; }
        public virtual string LDLKKOL { get; set; }
        public virtual string HDLKOL { get; set; }
        public virtual string ALT { get; set; }
        public virtual string ANTIGAD { get; set; }
        public virtual System.Nullable<int> EKG { get; set; }
        public virtual string MIKROALBUMINURI { get; set; }
        public virtual System.Nullable<int> GOZMUAYENE { get; set; }
        public virtual string PERIFERIKSENSORYAL { get; set; }
        public virtual string KRONERARTER { get; set; }
        public virtual string SEREBOVASKULERH { get; set; }
        public virtual string AYAKMUAYENSI { get; set; }
        public virtual System.Nullable<int> AKUTKOMLIKASYON { get; set; }
        public virtual System.Nullable<int> YATISGUN { get; set; }
        public virtual string INSULINPOMPASI { get; set; }
        public virtual System.Nullable<System.DateTime> INSULINPOMPASIVERTARIH { get; set; }
        public virtual System.Nullable<System.DateTime> INSULINPOMPDEGTARIH { get; set; }
        public virtual System.Nullable<int> BIREYSELEGITIMSAYISI { get; set; }
        public virtual System.Nullable<int> GRUPEGITIMSAYISI { get; set; }
        public virtual string EGITIMDM { get; set; }
        public virtual string GONDERILDI { get; set; }
        public virtual string TAKIPFORMUNO { get; set; }
    }
}
