using System;
using DevExpress.Xpo;

namespace Naz.Hastane.Data.Classes
{

    public struct HastaZiyaretKey
    {
        [Persistent("KNR"), Size(6)]
        public string KNR;
        [Persistent("SNR"), Size(3)]
        public string SNR;
    }

    [Persistent("BEHAND"), OptimisticLocking(false)]
    public class HastaZiyaret : XPBaseObject
    {
        HastaZiyaretKey fID;
        [Persistent]
        [Key(AutoGenerate = false)]
        public HastaZiyaretKey ID
        {
            get { return fID; }
            set { SetPropertyValue<HastaZiyaretKey>("ID", ref fID, value); }
        }
        [NonPersistent]
        //public string KNR
        //{
        //    get { return fID.KNR; }
        //    set
        //    {
        //        fID.KNR = value;
        //        OnChanged("KNR");
        //    }
        //}
        //[NonPersistent]
        //public string SNR
        //{
        //    get { return fID.SNR; }
        //    set
        //    {
        //        fID.SNR = value;
        //        OnChanged("SNR");
        //    }
        //}

        DateTime fBHDAT;
        public DateTime BHDAT
        {
            get { return fBHDAT; }
            set { SetPropertyValue<DateTime>("BHDAT", ref fBHDAT, value); }
        }
        short fSEVKGECSURE;
        public short SEVKGECSURE
        {
            get { return fSEVKGECSURE; }
            set { SetPropertyValue<short>("SEVKGECSURE", ref fSEVKGECSURE, value); }
        }
        DateTime fFATURATARIHI;
        public DateTime FATURATARIHI
        {
            get { return fFATURATARIHI; }
            set { SetPropertyValue<DateTime>("FATURATARIHI", ref fFATURATARIHI, value); }
        }

        Doktor fdoktor;
        [Persistent("ARZT")]
        [Size(4)]
        public Doktor doktor
        {
            get { return fdoktor; }
            set { SetPropertyValue<Doktor>("doktor", ref fdoktor, value); }
        }

        string fSERVIS;
        [Size(2)]
        public string SERVIS
        {
            get { return fSERVIS; }
            set { SetPropertyValue<string>("SERVIS", ref fSERVIS, value); }
        }
        string fAMBU;
        [Size(1)]
        public string AMBU
        {
            get { return fAMBU; }
            set { SetPropertyValue<string>("AMBU", ref fAMBU, value); }
        }
        string fIMPF2;
        [Size(1)]
        public string IMPF2
        {
            get { return fIMPF2; }
            set { SetPropertyValue<string>("IMPF2", ref fIMPF2, value); }
        }
        string fKAR_NO;
        [Size(7)]
        public string KAR_NO
        {
            get { return fKAR_NO; }
            set { SetPropertyValue<string>("KAR_NO", ref fKAR_NO, value); }
        }
        string fARSIVNO;
        [Size(7)]
        public string ARSIVNO
        {
            get { return fARSIVNO; }
            set { SetPropertyValue<string>("ARSIVNO", ref fARSIVNO, value); }
        }
        string fTES_ANA;
        [Size(2)]
        public string TES_ANA
        {
            get { return fTES_ANA; }
            set { SetPropertyValue<string>("TES_ANA", ref fTES_ANA, value); }
        }
        string fTES_CODE;
        [Size(15)]
        public string TES_CODE
        {
            get { return fTES_CODE; }
            set { SetPropertyValue<string>("TES_CODE", ref fTES_CODE, value); }
        }
        string fHASTALIKSONU;
        [Size(1)]
        public string HASTALIKSONU
        {
            get { return fHASTALIKSONU; }
            set { SetPropertyValue<string>("HASTALIKSONU", ref fHASTALIKSONU, value); }
        }
        string fAMELIYAT;
        [Size(1)]
        public string AMELIYAT
        {
            get { return fAMELIYAT; }
            set { SetPropertyValue<string>("AMELIYAT", ref fAMELIYAT, value); }
        }
        string fDOGUM;
        [Size(1)]
        public string DOGUM
        {
            get { return fDOGUM; }
            set { SetPropertyValue<string>("DOGUM", ref fDOGUM, value); }
        }
        string fUCRETDURUMU;
        [Size(1)]
        public string UCRETDURUMU
        {
            get { return fUCRETDURUMU; }
            set { SetPropertyValue<string>("UCRETDURUMU", ref fUCRETDURUMU, value); }
        }
        string fSERNO;
        [Size(5)]
        public string SERNO
        {
            get { return fSERNO; }
            set { SetPropertyValue<string>("SERNO", ref fSERNO, value); }
        }
        string fFATURANO;
        [Size(7)]
        public string FATURANO
        {
            get { return fFATURANO; }
            set { SetPropertyValue<string>("FATURANO", ref fFATURANO, value); }
        }
        double fMTOPT;
        public double MTOPT
        {
            get { return fMTOPT; }
            set { SetPropertyValue<double>("MTOPT", ref fMTOPT, value); }
        }
        double fKTOPT;
        public double KTOPT
        {
            get { return fKTOPT; }
            set { SetPropertyValue<double>("KTOPT", ref fKTOPT, value); }
        }
        double fDTOPT;
        public double DTOPT
        {
            get { return fDTOPT; }
            set { SetPropertyValue<double>("DTOPT", ref fDTOPT, value); }
        }
        string fGEL;
        [Size(1)]
        public string GEL
        {
            get { return fGEL; }
            set { SetPropertyValue<string>("GEL", ref fGEL, value); }
        }
        string fFIYATARTISMUAF;
        [Size(1)]
        public string FIYATARTISMUAF
        {
            get { return fFIYATARTISMUAF; }
            set { SetPropertyValue<string>("FIYATARTISMUAF", ref fFIYATARTISMUAF, value); }
        }
        string fODANO;
        [Size(10)]
        public string ODANO
        {
            get { return fODANO; }
            set { SetPropertyValue<string>("ODANO", ref fODANO, value); }
        }
        char fODAUCR;
        public char ODAUCR
        {
            get { return fODAUCR; }
            set { SetPropertyValue<char>("ODAUCR", ref fODAUCR, value); }
        }
        DateTime fCIKTAR;
        public DateTime CIKTAR
        {
            get { return fCIKTAR; }
            set { SetPropertyValue<DateTime>("CIKTAR", ref fCIKTAR, value); }
        }
        short fHZLNO;
        public short HZLNO
        {
            get { return fHZLNO; }
            set { SetPropertyValue<short>("HZLNO", ref fHZLNO, value); }
        }
        double fSIRAID;
        public double SIRAID
        {
            get { return fSIRAID; }
            set { SetPropertyValue<double>("SIRAID", ref fSIRAID, value); }
        }
        string fPROTOKOLNO;
        [Size(6)]
        public string PROTOKOLNO
        {
            get { return fPROTOKOLNO; }
            set { SetPropertyValue<string>("PROTOKOLNO", ref fPROTOKOLNO, value); }
        }
        string fPROVIZYONNO;
        [Size(40)]
        public string PROVIZYONNO
        {
            get { return fPROVIZYONNO; }
            set { SetPropertyValue<string>("PROVIZYONNO", ref fPROVIZYONNO, value); }
        }
        string fOZELNOT;
        [Size(20)]
        public string OZELNOT
        {
            get { return fOZELNOT; }
            set { SetPropertyValue<string>("OZELNOT", ref fOZELNOT, value); }
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
        string fTAKIPNO;
        [Size(20)]
        public string TAKIPNO
        {
            get { return fTAKIPNO; }
            set { SetPropertyValue<string>("TAKIPNO", ref fTAKIPNO, value); }
        }
        string fTAKIPSEND;
        [Size(2)]
        public string TAKIPSEND
        {
            get { return fTAKIPSEND; }
            set { SetPropertyValue<string>("TAKIPSEND", ref fTAKIPSEND, value); }
        }
        string fDESTEKPSG;
        [Size(10)]
        public string DESTEKPSG
        {
            get { return fDESTEKPSG; }
            set { SetPropertyValue<string>("DESTEKPSG", ref fDESTEKPSG, value); }
        }
        bool fXLOCK;
        public bool XLOCK
        {
            get { return fXLOCK; }
            set { SetPropertyValue<bool>("XLOCK", ref fXLOCK, value); }
        }
        double fTAKIPTUTAR;
        public double TAKIPTUTAR
        {
            get { return fTAKIPTUTAR; }
            set { SetPropertyValue<double>("TAKIPTUTAR", ref fTAKIPTUTAR, value); }
        }
        string fPSG;
        [Size(10)]
        public string PSG
        {
            get { return fPSG; }
            set { SetPropertyValue<string>("PSG", ref fPSG, value); }
        }
        string fSTURU;
        [Size(2)]
        public string STURU
        {
            get { return fSTURU; }
            set { SetPropertyValue<string>("STURU", ref fSTURU, value); }
        }
        string fTABKODU;
        [Size(2)]
        public string TABKODU
        {
            get { return fTABKODU; }
            set { SetPropertyValue<string>("TABKODU", ref fTABKODU, value); }
        }
        string fICMALNO;
        [Size(10)]
        public string ICMALNO
        {
            get { return fICMALNO; }
            set { SetPropertyValue<string>("ICMALNO", ref fICMALNO, value); }
        }
        DateTime fICMALTARIHI;
        public DateTime ICMALTARIHI
        {
            get { return fICMALTARIHI; }
            set { SetPropertyValue<DateTime>("ICMALTARIHI", ref fICMALTARIHI, value); }
        }
        string fSEVKTAKIPNO;
        [Size(20)]
        public string SEVKTAKIPNO
        {
            get { return fSEVKTAKIPNO; }
            set { SetPropertyValue<string>("SEVKTAKIPNO", ref fSEVKTAKIPNO, value); }
        }
        string fpaket;
        [Size(2)]
        public string paket
        {
            get { return fpaket; }
            set { SetPropertyValue<string>("paket", ref fpaket, value); }
        }
        string fMYBUTKOD;
        [Size(20)]
        public string MYBUTKOD
        {
            get { return fMYBUTKOD; }
            set { SetPropertyValue<string>("MYBUTKOD", ref fMYBUTKOD, value); }
        }
        double fMEDFATTUTAR;
        public double MEDFATTUTAR
        {
            get { return fMEDFATTUTAR; }
            set { SetPropertyValue<double>("MEDFATTUTAR", ref fMEDFATTUTAR, value); }
        }
        string fTESLIMNO;
        [Size(30)]
        public string TESLIMNO
        {
            get { return fTESLIMNO; }
            set { SetPropertyValue<string>("TESLIMNO", ref fTESLIMNO, value); }
        }
        DateTime fMCIKISTARIHI;
        public DateTime MCIKISTARIHI
        {
            get { return fMCIKISTARIHI; }
            set { SetPropertyValue<DateTime>("MCIKISTARIHI", ref fMCIKISTARIHI, value); }
        }
        string fREFGUNSAY;
        [Size(4)]
        public string REFGUNSAY
        {
            get { return fREFGUNSAY; }
            set { SetPropertyValue<string>("REFGUNSAY", ref fREFGUNSAY, value); }
        }
        string fMEDFATURANO;
        [Size(20)]
        public string MEDFATURANO
        {
            get { return fMEDFATURANO; }
            set { SetPropertyValue<string>("MEDFATURANO", ref fMEDFATURANO, value); }
        }
        DateTime fMEDFATURATARIHI;
        public DateTime MEDFATURATARIHI
        {
            get { return fMEDFATURATARIHI; }
            set { SetPropertyValue<DateTime>("MEDFATURATARIHI", ref fMEDFATURATARIHI, value); }
        }
        string fTAKIPTURU;
        [Size(10)]
        public string TAKIPTURU
        {
            get { return fTAKIPTURU; }
            set { SetPropertyValue<string>("TAKIPTURU", ref fTAKIPTURU, value); }
        }
        DateTime fDESFATURATARIHI;
        public DateTime DESFATURATARIHI
        {
            get { return fDESFATURATARIHI; }
            set { SetPropertyValue<DateTime>("DESFATURATARIHI", ref fDESFATURATARIHI, value); }
        }
        string fHASTABASNO;
        [Size(10)]
        public string HASTABASNO
        {
            get { return fHASTABASNO; }
            set { SetPropertyValue<string>("HASTABASNO", ref fHASTABASNO, value); }
        }
        string fILISKILITAKIPNO;
        [Size(20)]
        public string ILISKILITAKIPNO
        {
            get { return fILISKILITAKIPNO; }
            set { SetPropertyValue<string>("ILISKILITAKIPNO", ref fILISKILITAKIPNO, value); }
        }
        string fTEDAVITURU;
        [Size(4)]
        public string TEDAVITURU
        {
            get { return fTEDAVITURU; }
            set { SetPropertyValue<string>("TEDAVITURU", ref fTEDAVITURU, value); }
        }
        double fFARKTUTAR;
        public double FARKTUTAR
        {
            get { return fFARKTUTAR; }
            set { SetPropertyValue<double>("FARKTUTAR", ref fFARKTUTAR, value); }
        }
        string fARACIKLAMA;
        [Size(50)]
        public string ARACIKLAMA
        {
            get { return fARACIKLAMA; }
            set { SetPropertyValue<string>("ARACIKLAMA", ref fARACIKLAMA, value); }
        }
        bool fARGONDERILDI;
        public bool ARGONDERILDI
        {
            get { return fARGONDERILDI; }
            set { SetPropertyValue<bool>("ARGONDERILDI", ref fARGONDERILDI, value); }
        }
        string fARHATA;
        [Size(50)]
        public string ARHATA
        {
            get { return fARHATA; }
            set { SetPropertyValue<string>("ARHATA", ref fARHATA, value); }
        }
        string fCIKSAAT;
        [Size(10)]
        public string CIKSAAT
        {
            get { return fCIKSAAT; }
            set { SetPropertyValue<string>("CIKSAAT", ref fCIKSAAT, value); }
        }
        char fDURUM;
        public char DURUM
        {
            get { return fDURUM; }
            set { SetPropertyValue<char>("DURUM", ref fDURUM, value); }
        }
        DateTime fKONTROLTAR;
        public DateTime KONTROLTAR
        {
            get { return fKONTROLTAR; }
            set { SetPropertyValue<DateTime>("KONTROLTAR", ref fKONTROLTAR, value); }
        }
        DateTime fKONTROLT;
        public DateTime KONTROLT
        {
            get { return fKONTROLT; }
            set { SetPropertyValue<DateTime>("KONTROLT", ref fKONTROLT, value); }
        }
        char fKONTROL;
        public char KONTROL
        {
            get { return fKONTROL; }
            set { SetPropertyValue<char>("KONTROL", ref fKONTROL, value); }
        }
        public HastaZiyaret(Session session) : base(session) { }
        public HastaZiyaret() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.ID.SNR == null || this.ID.SNR.Length == 0)
            {
                fID.SNR = (new UnitOfWork()).ExecuteSproc("a_YeniHastaZiyaretNo", ID.KNR).ResultSet[0].Rows[0].Values[0].ToString();
                //KNR = HastaHelper.GetNewHastaNumber();
            }
        }

        [Aggregated, Association("HastaZiyaret-HastaZiyaretIslemlers", typeof(HastaZiyaretIslem))]
        public XPCollection HastaZiyaretIslemlers
        {
            get { return GetCollection("HastaZiyaretIslemlers"); }
        }

        [Association("Hasta-HastaZiyarets")]
        [Persistent("KNR")]
        public Hasta Owner;

    }

}
