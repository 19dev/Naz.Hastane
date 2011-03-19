using System;
using DevExpress.Xpo;

namespace Naz.Hastane.Data.Classes
{

    public struct HastaZiyaretIslemKey
    {
        //[Persistent("KNR"), Size(6)]
        //public string KNR;
        //[Persistent("SNR"), Size(3)]
        //public string SNR;
        //[Persistent("SIRANO")]
        //public double SIRANO;
    }

    [Persistent("HIZIL"), OptimisticLocking(false)]
    public class HastaZiyaretIslem : XPBaseObject
    {
        protected override void OnSaving()
        {
 	        base.OnSaving();
            if (this.SIRANO == 0)
            {
                SIRANO =Double.Parse((new UnitOfWork()).ExecuteSproc("a_YeniHastaZiyaretIslemNo", KNR, SNR).ResultSet[0].Rows[0].Values[0].ToString());
                //KNR = HastaHelper.GetNewHastaNumber();
            }
        }

        HastaZiyaretIslemKey fID;
        [Persistent]
        [Key(false)]
        public HastaZiyaretIslemKey ID
        {
            get { return fID; }
            set { SetPropertyValue<HastaZiyaretIslemKey>("ID", ref fID, value); }
        }
        [NonPersistent]
        public string KNR
        {
            get { return fID.KNR; }
            set
            {
                fID.KNR = value;
                OnChanged("KNR");
            }
        }
        [NonPersistent]
        public string SNR
        {
            get { return fID.SNR; }
            set
            {
                fID.SNR = value;
                OnChanged("SNR");
            }
        }
        [NonPersistent]
        public double SIRANO
        {
            get { return fID.SIRANO; }
            set
            {
                fID.SIRANO = value;
                OnChanged("SIRANO");
            }
        }

        string fAKOD;
        [Size(2)]
        public string AKOD
        {
            get { return fAKOD; }
            set { SetPropertyValue<string>("AKOD", ref fAKOD, value); }
        }
        string fTANIM;
        [Size(2)]
        public string TANIM
        {
            get { return fTANIM; }
            set { SetPropertyValue<string>("TANIM", ref fTANIM, value); }
        }
        string fGRUP;
        [Size(3)]
        public string GRUP
        {
            get { return fGRUP; }
            set { SetPropertyValue<string>("GRUP", ref fGRUP, value); }
        }
        string fCODE;
        [Size(15)]
        public string CODE
        {
            get { return fCODE; }
            set { SetPropertyValue<string>("CODE", ref fCODE, value); }
        }

        Doktor fdoktor;
        [Persistent("ARZT")]
        [Size(4)]
        public Doktor doktor
        {
            get { return fdoktor; }
            set { SetPropertyValue<Doktor>("doktor", ref fdoktor, value); }
        }

        Doktor fdoktor2;
        [Persistent("ARZT2")]
        [Size(4)]
        public Doktor doktor2
        {
            get { return fdoktor2; }
            set { SetPropertyValue<Doktor>("doktor2", ref fdoktor2, value); }
        }

        double fADET;
        public double ADET
        {
            get { return fADET; }
            set { SetPropertyValue<double>("ADET", ref fADET, value); }
        }
        string fUNITE;
        [Size(2)]
        public string UNITE
        {
            get { return fUNITE; }
            set { SetPropertyValue<string>("UNITE", ref fUNITE, value); }
        }
        string fNAME1;
        public string NAME1
        {
            get { return fNAME1; }
            set { SetPropertyValue<string>("NAME1", ref fNAME1, value); }
        }
        double fSATISF;
        public double SATISF
        {
            get { return fSATISF; }
            set { SetPropertyValue<double>("SATISF", ref fSATISF, value); }
        }
        double fKSATISF;
        public double KSATISF
        {
            get { return fKSATISF; }
            set { SetPropertyValue<double>("KSATISF", ref fKSATISF, value); }
        }
        double fDSATISF;
        public double DSATISF
        {
            get { return fDSATISF; }
            set { SetPropertyValue<double>("DSATISF", ref fDSATISF, value); }
        }
        double fKDV;
        public double KDV
        {
            get { return fKDV; }
            set { SetPropertyValue<double>("KDV", ref fKDV, value); }
        }
        DateTime fTARIH;
        public DateTime TARIH
        {
            get { return fTARIH; }
            set { SetPropertyValue<DateTime>("TARIH", ref fTARIH, value); }
        }
        string fPSG;
        [Size(6)]
        public string PSG
        {
            get { return fPSG; }
            set { SetPropertyValue<string>("PSG", ref fPSG, value); }
        }
        short fHZLNO;
        public short HZLNO
        {
            get { return fHZLNO; }
            set { SetPropertyValue<short>("HZLNO", ref fHZLNO, value); }
        }
        string fUSER_ID;
        [Size(20)]
        public string USER_ID
        {
            get { return fUSER_ID; }
            set { SetPropertyValue<string>("USER_ID", ref fUSER_ID, value); }
        }
        DateTime fDATE_CREATE;
        public DateTime DATE_CREATE
        {
            get { return fDATE_CREATE; }
            set { SetPropertyValue<DateTime>("DATE_CREATE", ref fDATE_CREATE, value); }
        }
        string fUSER_ID_UPDATE;
        [Size(20)]
        public string USER_ID_UPDATE
        {
            get { return fUSER_ID_UPDATE; }
            set { SetPropertyValue<string>("USER_ID_UPDATE", ref fUSER_ID_UPDATE, value); }
        }
        DateTime fDATE_UPDATE;
        public DateTime DATE_UPDATE
        {
            get { return fDATE_UPDATE; }
            set { SetPropertyValue<DateTime>("DATE_UPDATE", ref fDATE_UPDATE, value); }
        }
        string fMAKNO;
        [Size(8)]
        public string MAKNO
        {
            get { return fMAKNO; }
            set { SetPropertyValue<string>("MAKNO", ref fMAKNO, value); }
        }
        string fKFATNO;
        [Size(7)]
        public string KFATNO
        {
            get { return fKFATNO; }
            set { SetPropertyValue<string>("KFATNO", ref fKFATNO, value); }
        }
        string fFATURAEDILSIN;
        [Size(1)]
        public string FATURAEDILSIN
        {
            get { return fFATURAEDILSIN; }
            set { SetPropertyValue<string>("FATURAEDILSIN", ref fFATURAEDILSIN, value); }
        }
        string fISLENDIMI;
        [Size(1)]
        public string ISLENDIMI
        {
            get { return fISLENDIMI; }
            set { SetPropertyValue<string>("ISLENDIMI", ref fISLENDIMI, value); }
        }
        string fPAKET;
        [Size(1)]
        public string PAKET
        {
            get { return fPAKET; }
            set { SetPropertyValue<string>("PAKET", ref fPAKET, value); }
        }
        string fLRGOR;
        [Size(1)]
        public string LRGOR
        {
            get { return fLRGOR; }
            set { SetPropertyValue<string>("LRGOR", ref fLRGOR, value); }
        }
        string fBUTCODE;
        [Size(20)]
        public string BUTCODE
        {
            get { return fBUTCODE; }
            set { SetPropertyValue<string>("BUTCODE", ref fBUTCODE, value); }
        }
        string fBUTNAME;
        public string BUTNAME
        {
            get { return fBUTNAME; }
            set { SetPropertyValue<string>("BUTNAME", ref fBUTNAME, value); }
        }
        double fESKI_SATISF;
        public double ESKI_SATISF
        {
            get { return fESKI_SATISF; }
            set { SetPropertyValue<double>("ESKI_SATISF", ref fESKI_SATISF, value); }
        }
        string fKABUL;
        [Size(1)]
        public string KABUL
        {
            get { return fKABUL; }
            set { SetPropertyValue<string>("KABUL", ref fKABUL, value); }
        }
        string fISODENDI;
        [Size(1)]
        public string ISODENDI
        {
            get { return fISODENDI; }
            set { SetPropertyValue<string>("ISODENDI", ref fISODENDI, value); }
        }
        double fCARIFIYAT;
        public double CARIFIYAT
        {
            get { return fCARIFIYAT; }
            set { SetPropertyValue<double>("CARIFIYAT", ref fCARIFIYAT, value); }
        }
        DateTime fODEMETARIHI;
        public DateTime ODEMETARIHI
        {
            get { return fODEMETARIHI; }
            set { SetPropertyValue<DateTime>("ODEMETARIHI", ref fODEMETARIHI, value); }
        }
        string fISDURUM;
        [Size(1)]
        public string ISDURUM
        {
            get { return fISDURUM; }
            set { SetPropertyValue<string>("ISDURUM", ref fISDURUM, value); }
        }
        string fPSEANS;
        [Size(2)]
        public string PSEANS
        {
            get { return fPSEANS; }
            set { SetPropertyValue<string>("PSEANS", ref fPSEANS, value); }
        }
        string fSAGSOL;
        [Size(1)]
        public string SAGSOL
        {
            get { return fSAGSOL; }
            set { SetPropertyValue<string>("SAGSOL", ref fSAGSOL, value); }
        }
        string fEUSCORE;
        [Size(3)]
        public string EUSCORE
        {
            get { return fEUSCORE; }
            set { SetPropertyValue<string>("EUSCORE", ref fEUSCORE, value); }
        }
        string fHMAKNO;
        [Size(12)]
        public string HMAKNO
        {
            get { return fHMAKNO; }
            set { SetPropertyValue<string>("HMAKNO", ref fHMAKNO, value); }
        }
        string fHODENDI;
        [Size(1)]
        public string HODENDI
        {
            get { return fHODENDI; }
            set { SetPropertyValue<string>("HODENDI", ref fHODENDI, value); }
        }
        string fAMAKNO;
        [Size(12)]
        public string AMAKNO
        {
            get { return fAMAKNO; }
            set { SetPropertyValue<string>("AMAKNO", ref fAMAKNO, value); }
        }
        DateTime fHYATISTARIHI;
        public DateTime HYATISTARIHI
        {
            get { return fHYATISTARIHI; }
            set { SetPropertyValue<DateTime>("HYATISTARIHI", ref fHYATISTARIHI, value); }
        }
        DateTime fHCIKISTARIHI;
        public DateTime HCIKISTARIHI
        {
            get { return fHCIKISTARIHI; }
            set { SetPropertyValue<DateTime>("HCIKISTARIHI", ref fHCIKISTARIHI, value); }
        }
        string fREFGUNSAY;
        [Size(4)]
        public string REFGUNSAY
        {
            get { return fREFGUNSAY; }
            set { SetPropertyValue<string>("REFGUNSAY", ref fREFGUNSAY, value); }
        }
        string fISLEMSIRANO;
        [Size(20)]
        public string ISLEMSIRANO
        {
            get { return fISLEMSIRANO; }
            set { SetPropertyValue<string>("ISLEMSIRANO", ref fISLEMSIRANO, value); }
        }
        string fMEDSIRANO;
        [Size(20)]
        public string MEDSIRANO
        {
            get { return fMEDSIRANO; }
            set { SetPropertyValue<string>("MEDSIRANO", ref fMEDSIRANO, value); }
        }
        string fMEDONAY;
        [Size(2)]
        public string MEDONAY
        {
            get { return fMEDONAY; }
            set { SetPropertyValue<string>("MEDONAY", ref fMEDONAY, value); }
        }
        double fMEDTUTAR;
        public double MEDTUTAR
        {
            get { return fMEDTUTAR; }
            set { SetPropertyValue<double>("MEDTUTAR", ref fMEDTUTAR, value); }
        }
        string fTBASLANGICSAATI;
        [Size(5)]
        public string TBASLANGICSAATI
        {
            get { return fTBASLANGICSAATI; }
            set { SetPropertyValue<string>("TBASLANGICSAATI", ref fTBASLANGICSAATI, value); }
        }
        string fTBITISSAATI;
        [Size(5)]
        public string TBITISSAATI
        {
            get { return fTBITISSAATI; }
            set { SetPropertyValue<string>("TBITISSAATI", ref fTBITISSAATI, value); }
        }
        string fMEDOZDURUM;
        [Size(1)]
        public string MEDOZDURUM
        {
            get { return fMEDOZDURUM; }
            set { SetPropertyValue<string>("MEDOZDURUM", ref fMEDOZDURUM, value); }
        }
        string fMEDANOMALI;
        [Size(1)]
        public string MEDANOMALI
        {
            get { return fMEDANOMALI; }
            set { SetPropertyValue<string>("MEDANOMALI", ref fMEDANOMALI, value); }
        }
        int fTG;
        public int TG
        {
            get { return fTG; }
            set { SetPropertyValue<int>("TG", ref fTG, value); }
        }
        public HastaZiyaretIslem(Session session) : base(session) { }
        public HastaZiyaretIslem() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [Association("HastaZiyaret-HastaZiyaretIslemlers")]
        [Persistent("")]
        public HastaZiyaret Owner;


    }
}
