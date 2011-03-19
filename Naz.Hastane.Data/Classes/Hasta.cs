using System;
using DevExpress.Xpo;

namespace Naz.Hastane.Data.Classes
{

    [Persistent("ADRES")]
    public class Hasta : XPLiteObject
    {
        public Hasta() : base() { }
        public Hasta(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        protected override void  OnSaving()
        {
 	        base.OnSaving();
            if (this.KNR == null || this.KNR.Length == 0)
            {
                KNR = (new UnitOfWork()).ExecuteSproc("a_YeniHastaNo").ResultSet[0].Rows[0].Values[0].ToString();
                //KNR = HastaHelper.GetNewHastaNumber();
            }
        }

        string fKNR;
        [Key]
        [Size(6)]
        public string KNR
        {
            get { return fKNR; }
            set { SetPropertyValue<string>("KNR", ref fKNR, value); }
        }
        string fPSG;
        [Size(6)]
        public string PSG
        {
            get { return fPSG; }
            set { SetPropertyValue<string>("PSG", ref fPSG, value); }
        }
        string fARSIVNO;
        [Size(10)]
        public string ARSIVNO
        {
            get { return fARSIVNO; }
            set { SetPropertyValue<string>("ARSIVNO", ref fARSIVNO, value); }
        }
        string fADLIARSIVNO;
        [Size(10)]
        public string ADLIARSIVNO
        {
            get { return fADLIARSIVNO; }
            set { SetPropertyValue<string>("ADLIARSIVNO", ref fADLIARSIVNO, value); }
        }
        string fSIGORTANO;
        [Size(15)]
        public string SIGORTANO
        {
            get { return fSIGORTANO; }
            set { SetPropertyValue<string>("SIGORTANO", ref fSIGORTANO, value); }
        }
        string fCINSIYETI;
        [Size(1)]
        public string CINSIYETI
        {
            get { return fCINSIYETI; }
            set { SetPropertyValue<string>("CINSIYETI", ref fCINSIYETI, value); }
        }
        string fMEDENI;
        [Size(1)]
        public string MEDENI
        {
            get { return fMEDENI; }
            set { SetPropertyValue<string>("MEDENI", ref fMEDENI, value); }
        }
        string fHASTAADI;
        [Size(15)]
        public string HASTAADI
        {
            get { return fHASTAADI; }
            set { SetPropertyValue<string>("HASTAADI", ref fHASTAADI, value); }
        }
        string fHASTASOYADI;
        [Size(30)]
        public string HASTASOYADI
        {
            get { return fHASTASOYADI; }
            set { SetPropertyValue<string>("HASTASOYADI", ref fHASTASOYADI, value); }
        }
        string fBABAADI;
        [Size(15)]
        public string BABAADI
        {
            get { return fBABAADI; }
            set { SetPropertyValue<string>("BABAADI", ref fBABAADI, value); }
        }
        string fANAADI;
        [Size(15)]
        public string ANAADI
        {
            get { return fANAADI; }
            set { SetPropertyValue<string>("ANAADI", ref fANAADI, value); }
        }
        string fEV_ADRES;
        [Size(60)]
        public string EV_ADRES
        {
            get { return fEV_ADRES; }
            set { SetPropertyValue<string>("EV_ADRES", ref fEV_ADRES, value); }
        }
        string fEV_PK;
        [Size(5)]
        public string EV_PK
        {
            get { return fEV_PK; }
            set { SetPropertyValue<string>("EV_PK", ref fEV_PK, value); }
        }
        string fEV_SEHIR;
        [Size(20)]
        public string EV_SEHIR
        {
            get { return fEV_SEHIR; }
            set { SetPropertyValue<string>("EV_SEHIR", ref fEV_SEHIR, value); }
        }
        string fEV_TEL1;
        [Size(15)]
        public string EV_TEL1
        {
            get { return fEV_TEL1; }
            set { SetPropertyValue<string>("EV_TEL1", ref fEV_TEL1, value); }
        }
        string fEV_TEL2;
        [Size(15)]
        public string EV_TEL2
        {
            get { return fEV_TEL2; }
            set { SetPropertyValue<string>("EV_TEL2", ref fEV_TEL2, value); }
        }
        string fEV_ILCE;
        [Size(50)]
        public string EV_ILCE
        {
            get { return fEV_ILCE; }
            set { SetPropertyValue<string>("EV_ILCE", ref fEV_ILCE, value); }
        }
        string fEV_MAHALLE;
        [Size(50)]
        public string EV_MAHALLE
        {
            get { return fEV_MAHALLE; }
            set { SetPropertyValue<string>("EV_MAHALLE", ref fEV_MAHALLE, value); }
        }
        string fEMAIL;
        [Size(50)]
        public string EMAIL
        {
            get { return fEMAIL; }
            set { SetPropertyValue<string>("EMAIL", ref fEMAIL, value); }
        }
        string fDOGUMYERI;
        [Size(15)]
        public string DOGUMYERI
        {
            get { return fDOGUMYERI; }
            set { SetPropertyValue<string>("DOGUMYERI", ref fDOGUMYERI, value); }
        }
        DateTime fDOGUMTARIHI;
        public DateTime DOGUMTARIHI
        {
            get { return fDOGUMTARIHI; }
            set { SetPropertyValue<DateTime>("DOGUMTARIHI", ref fDOGUMTARIHI, value); }
        }
        string fUYRUGU;
        [Size(5)]
        public string UYRUGU
        {
            get { return fUYRUGU; }
            set { SetPropertyValue<string>("UYRUGU", ref fUYRUGU, value); }
        }
        string fTCKIMLIKNO;
        [Size(15)]
        public string TCKIMLIKNO
        {
            get { return fTCKIMLIKNO; }
            set { SetPropertyValue<string>("TCKIMLIKNO", ref fTCKIMLIKNO, value); }
        }
        char fHUVIYETTIPI;
        public char HUVIYETTIPI
        {
            get { return fHUVIYETTIPI; }
            set { SetPropertyValue<char>("HUVIYETTIPI", ref fHUVIYETTIPI, value); }
        }
        string fHUVIYETNO;
        [Size(15)]
        public string HUVIYETNO
        {
            get { return fHUVIYETNO; }
            set { SetPropertyValue<string>("HUVIYETNO", ref fHUVIYETNO, value); }
        }
        string fHUVIYETTARIHI;
        [Size(10)]
        public string HUVIYETTARIHI
        {
            get { return fHUVIYETTARIHI; }
            set { SetPropertyValue<string>("HUVIYETTARIHI", ref fHUVIYETTARIHI, value); }
        }
        string fHUVIYETVYER;
        [Size(50)]
        public string HUVIYETVYER
        {
            get { return fHUVIYETVYER; }
            set { SetPropertyValue<string>("HUVIYETVYER", ref fHUVIYETVYER, value); }
        }
        string fNUFUSKAYITLIIL;
        [Size(50)]
        public string NUFUSKAYITLIIL
        {
            get { return fNUFUSKAYITLIIL; }
            set { SetPropertyValue<string>("NUFUSKAYITLIIL", ref fNUFUSKAYITLIIL, value); }
        }
        string fNUFUSKAYITLIILCE;
        [Size(50)]
        public string NUFUSKAYITLIILCE
        {
            get { return fNUFUSKAYITLIILCE; }
            set { SetPropertyValue<string>("NUFUSKAYITLIILCE", ref fNUFUSKAYITLIILCE, value); }
        }
        int fKANGRUBU;
        public int KANGRUBU
        {
            get { return fKANGRUBU; }
            set { SetPropertyValue<int>("KANGRUBU", ref fKANGRUBU, value); }
        }
        char fKANVEREBILIR;
        public char KANVEREBILIR
        {
            get { return fKANVEREBILIR; }
            set { SetPropertyValue<char>("KANVEREBILIR", ref fKANVEREBILIR, value); }
        }
        string fMEMUR;
        [Size(20)]
        public string MEMUR
        {
            get { return fMEMUR; }
            set { SetPropertyValue<string>("MEMUR", ref fMEMUR, value); }
        }
        string fYAKINLIK;
        [Size(20)]
        public string YAKINLIK
        {
            get { return fYAKINLIK; }
            set { SetPropertyValue<string>("YAKINLIK", ref fYAKINLIK, value); }
        }
        char fDURUM;
        public char DURUM
        {
            get { return fDURUM; }
            set { SetPropertyValue<char>("DURUM", ref fDURUM, value); }
        }
        string fMESLEK;
        [Size(20)]
        public string MESLEK
        {
            get { return fMESLEK; }
            set { SetPropertyValue<string>("MESLEK", ref fMESLEK, value); }
        }
        string fEMSNO;
        [Size(20)]
        public string EMSNO
        {
            get { return fEMSNO; }
            set { SetPropertyValue<string>("EMSNO", ref fEMSNO, value); }
        }
        string fPROTNO;
        [Size(20)]
        public string PROTNO
        {
            get { return fPROTNO; }
            set { SetPropertyValue<string>("PROTNO", ref fPROTNO, value); }
        }
        string fBAGNO;
        [Size(20)]
        public string BAGNO
        {
            get { return fBAGNO; }
            set { SetPropertyValue<string>("BAGNO", ref fBAGNO, value); }
        }
        string fBAGKARNENO;
        [Size(20)]
        public string BAGKARNENO
        {
            get { return fBAGKARNENO; }
            set { SetPropertyValue<string>("BAGKARNENO", ref fBAGKARNENO, value); }
        }
        string fYKARTNO;
        [Size(10)]
        public string YKARTNO
        {
            get { return fYKARTNO; }
            set { SetPropertyValue<string>("YKARTNO", ref fYKARTNO, value); }
        }
        string fGELHAST;
        [Size(20)]
        public string GELHAST
        {
            get { return fGELHAST; }
            set { SetPropertyValue<string>("GELHAST", ref fGELHAST, value); }
        }
        double fBORC;
        public double BORC
        {
            get { return fBORC; }
            set { SetPropertyValue<double>("BORC", ref fBORC, value); }
        }
        double fALACAK;
        public double ALACAK
        {
            get { return fALACAK; }
            set { SetPropertyValue<double>("ALACAK", ref fALACAK, value); }
        }
        string fSIGMUD;
        [Size(2)]
        public string SIGMUD
        {
            get { return fSIGMUD; }
            set { SetPropertyValue<string>("SIGMUD", ref fSIGMUD, value); }
        }
        string fIS_ADI;
        [Size(25)]
        public string IS_ADI
        {
            get { return fIS_ADI; }
            set { SetPropertyValue<string>("IS_ADI", ref fIS_ADI, value); }
        }
        string fIS_ADRESI;
        [Size(60)]
        public string IS_ADRESI
        {
            get { return fIS_ADRESI; }
            set { SetPropertyValue<string>("IS_ADRESI", ref fIS_ADRESI, value); }
        }
        string fIS_PK;
        [Size(5)]
        public string IS_PK
        {
            get { return fIS_PK; }
            set { SetPropertyValue<string>("IS_PK", ref fIS_PK, value); }
        }
        string fIS_SEHIR;
        [Size(20)]
        public string IS_SEHIR
        {
            get { return fIS_SEHIR; }
            set { SetPropertyValue<string>("IS_SEHIR", ref fIS_SEHIR, value); }
        }
        string fIS_TEL1;
        [Size(15)]
        public string IS_TEL1
        {
            get { return fIS_TEL1; }
            set { SetPropertyValue<string>("IS_TEL1", ref fIS_TEL1, value); }
        }
        string fIS_TEL2;
        [Size(15)]
        public string IS_TEL2
        {
            get { return fIS_TEL2; }
            set { SetPropertyValue<string>("IS_TEL2", ref fIS_TEL2, value); }
        }
        string fIS_FAX;
        [Size(15)]
        public string IS_FAX
        {
            get { return fIS_FAX; }
            set { SetPropertyValue<string>("IS_FAX", ref fIS_FAX, value); }
        }
        string fIS_YERINO;
        [Size(25)]
        public string IS_YERINO
        {
            get { return fIS_YERINO; }
            set { SetPropertyValue<string>("IS_YERINO", ref fIS_YERINO, value); }
        }
        char fHASTAKATILIM;
        public char HASTAKATILIM
        {
            get { return fHASTAKATILIM; }
            set { SetPropertyValue<char>("HASTAKATILIM", ref fHASTAKATILIM, value); }
        }
        double fHASTALIMIT;
        public double HASTALIMIT
        {
            get { return fHASTALIMIT; }
            set { SetPropertyValue<double>("HASTALIMIT", ref fHASTALIMIT, value); }
        }
        char fILACKONTROL;
        public char ILACKONTROL
        {
            get { return fILACKONTROL; }
            set { SetPropertyValue<char>("ILACKONTROL", ref fILACKONTROL, value); }
        }
        string fOZGECMIS;
        [Size(5000)]
        public string OZGECMIS
        {
            get { return fOZGECMIS; }
            set { SetPropertyValue<string>("OZGECMIS", ref fOZGECMIS, value); }
        }
        string fSIGORTATURU;
        [Size(2)]
        public string SIGORTATURU
        {
            get { return fSIGORTATURU; }
            set { SetPropertyValue<string>("SIGORTATURU", ref fSIGORTATURU, value); }
        }
        string fDEVREDILENKURUM;
        [Size(2)]
        public string DEVREDILENKURUM
        {
            get { return fDEVREDILENKURUM; }
            set { SetPropertyValue<string>("DEVREDILENKURUM", ref fDEVREDILENKURUM, value); }
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
        string fSIGORTALIKARTNO;
        [Size(20)]
        public string SIGORTALIKARTNO
        {
            get { return fSIGORTALIKARTNO; }
            set { SetPropertyValue<string>("SIGORTALIKARTNO", ref fSIGORTALIKARTNO, value); }
        }

        [Aggregated, Association("Hasta-HastaZiyarets", typeof(HastaZiyaret))]
        public XPCollection HastaZiyarets
        {
            get { return GetCollection("HastaZiyarets"); }
        }
    
    }

    [NonPersistent]
    public class a_YeniHastaNo : PersistentBase
    {
        string fString_column_0;
        public string String_column_0
        {
            get { return fString_column_0; }
            set { SetPropertyValue<string>("String_column_0", ref fString_column_0, value); }
        }
        public a_YeniHastaNo(Session session) : base(session) { }
        public a_YeniHastaNo() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public static class HastaHelper
    {

        public static DevExpress.Xpo.DB.SelectedData Execa_YeniHastaNo(Session session)
        {
            return session.ExecuteSproc("a_YeniHastaNo");
        }

        public static System.Collections.Generic.ICollection<a_YeniHastaNo> Execa_YeniHastaNoIntoObjects(Session session)
        {
            return session.GetObjectsFromSproc<a_YeniHastaNo>("a_YeniHastaNo");
        }

        public static string GetNewHastaNumber()
        {
            System.Collections.Generic.ICollection<a_YeniHastaNo> col = (new UnitOfWork()).GetObjectsFromSproc<a_YeniHastaNo>("a_YeniHastaNo");
            foreach (a_YeniHastaNo item in col)
            {
                return item.String_column_0;
            }
            return "";
        }

        public static XPDataView Execa_YeniHastaNoIntoDataView(Session session)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("a_YeniHastaNo");
            return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(a_YeniHastaNo)), sprocData);
        }
        public static void Execa_YeniHastaNoIntoDataView(XPDataView dataView, Session session)
        {
            DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("a_YeniHastaNo");
            dataView.PopulateProperties(session.GetClassInfo(typeof(a_YeniHastaNo)));
            dataView.LoadData(sprocData);
        }
    }
}   
