using System.Collections.Generic;
using System.Text;
using System;


namespace Naz.Hastane.Data.Entities
{

    public class MEDILACRAPOR : PatientVisitExtraBase
    {

        public MEDILACRAPOR() { }

        //public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }

        public virtual string RAPORNO { get; set; }
        public virtual System.Nullable<System.DateTime> RAPORTARIHI { get; set; }
        public virtual string RAPORTURU { get; set; }
        public virtual System.Nullable<System.DateTime> RAPORBASTARIH { get; set; }
        public virtual System.Nullable<System.DateTime> RAPORBITTARIH { get; set; }
        public virtual string RAPORDTUR { get; set; }
        public virtual string RAPPROTNO { get; set; }
        public virtual System.Nullable<System.DateTime> RAPPROTTARIH { get; set; }
        public virtual string RAPDURUM { get; set; }
        public virtual string RAPACIKLAMA { get; set; }
        public virtual string RAPKTANI { get; set; }
        public virtual string HSTTAKIPNO { get; set; }
        public virtual string HSTTCNO { get; set; }
        public virtual string HSTSNO { get; set; }
        public virtual string HSTKNO { get; set; }
        public virtual string HSTYKODU { get; set; }
        public virtual string HSTPTIPI { get; set; }
        public virtual System.Nullable<System.DateTime> HSTPTARIH { get; set; }
        public virtual string HSTDEVKURUM { get; set; }
        public virtual string HSTSGTURU { get; set; }
        public virtual string DRTESNO { get; set; }
        public virtual string DRADI { get; set; }
        public virtual string DRSOYADI { get; set; }
        public virtual string DRBRANSKODU { get; set; }
        public virtual string DRTIPI { get; set; }
        public virtual string DRTANIKODU { get; set; }
        public virtual string HASTAADI { get; set; }
        public virtual string HASTASOYADI { get; set; }
        public virtual System.Nullable<System.DateTime> RAPTESBASTARIH { get; set; }
        public virtual System.Nullable<System.DateTime> RAPTESBITTARIH { get; set; }
        public virtual string RAPTESKODU { get; set; }
        public virtual string TAKIPNO { get; set; }
        public virtual string RAPGONDERILDI { get; set; }
        public virtual string RAPTAKIPNO { get; set; }
        public virtual string RAPTURU { get; set; }
        public virtual string RAPTEDAVITURU { get; set; }
        public virtual string ESWTVBKODU { get; set; }
        public virtual string ESWTSGUN { get; set; }
        public virtual string ESWTSSAY { get; set; }
        public virtual string ESWTBUTKODU { get; set; }
        public virtual string FTRVBKODU { get; set; }
        public virtual string FTRSGUN { get; set; }
        public virtual string FTRSSAY { get; set; }
        public virtual string FTRBUTKODU { get; set; }
        public virtual string ESWLBUTKODU { get; set; }
        public virtual string ESWLTASSAYI { get; set; }
        public virtual string ESWLSSAY { get; set; }
        public virtual string ESWLBBILG { get; set; }
        public virtual string TAKIPFORMUNO { get; set; }
    }
}
