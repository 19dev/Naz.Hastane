using System;
using System.Collections.Generic;
using System.Linq;
using Naz.Hastane.Data.DTO;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.Accounting;
using Naz.Hastane.Data.Entities.Logs;
using Naz.Hastane.Data.Entities.LookUp;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Utilities.Classes;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Naz.Hastane.Data.Services
{
    public static class PersonnelServices
    {
        public static bool IsValidTCID(string aTCID)
        {
            return IsValidNumeric(aTCID, 11);
        }

        //public static bool IsValidPatientNo(string aPatientNo)
        //{
        //    return IsValidNumeric(aPatientNo, 6);
        //}

        public static bool IsValidNumeric(string aString)
        {
            if (String.IsNullOrWhiteSpace(aString))
                return false;
            foreach (char c in aString)
                if (!Char.IsNumber(c))
                    return false;
            return true;
        }
        
        public static bool IsValidNumeric(string aString, int length)
        {
            if (String.IsNullOrWhiteSpace(aString) || aString.Length != length)
                return false;
            foreach (char c in aString)
                if (!Char.IsNumber(c))
                    return false;
            return true;
        }        

        public static IList<Personel> GetByTCId(string aTCID)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                IList<Personel> result = session
                    .CreateCriteria(typeof(Personel))
                    .Add(Restrictions.Eq("TCID", aTCID))
                    .List<Personel>();
                return result;
            }
        }

        public static IList<Personel> GetPersonnelByPersonnelNo(string aPersonnelNo)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                IList<Personel> result = session
                    .CreateCriteria(typeof(Personel))
                    .Add(Restrictions.Eq("PersonelNo", aPersonnelNo))
                    .List<Personel>();
                return result;
            }
        }

        public static Personel GetPersonnelByID(int aPersonnelNo)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetPersonnelByID(aPersonnelNo, session);
        }

        public static Personel GetPersonnelByID(int aPersonnelNo, ISession session)
        {
            //if (String.IsNullOrWhiteSpace(aPersonnelNo))
            //    return null;

            return session.Get<Personel>(aPersonnelNo);
        }

        public static IList<Personel> GetByWhere(string aWhere)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return session.CreateQuery("From Personel as personel where " + aWhere)
                    .SetMaxResults(100)
                    .List<Personel>();
            }
        }

        public static Personel GetNewPersonnel()
        {
            Personel personnel = CreateNewPersonnel();
            return personnel;
        }

        public static void SavePersonnel(ISession session, Personel personnel)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(personnel);
                //if (personnel.PersonelNo == null || personnel.PersonelNo == "")
                //{
                //    personnel.PersonelNo = GetNewPersonnelNo().ToString();
                //    session.Save(personnel);
                //}
                //else
                //{
                //    session.Update(personnel);
                //}
                transaction.Commit();
            }
        }

        public static double GetNewPersonnelNo()
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetNewPersonnelNo(session);
        }

        public static double GetNewPersonnelNo(ISession session)
        {
            double? a = session.QueryOver<Personel>()
                .Select(
                    Projections
                        .ProjectionList()
                        .Add(Projections.Max<Personel>(x => x.PersonelNo)))
                .List<double?>().First();

            return a.GetValueOrDefault() + 1;
        }
        
        public static Personel CreateNewPersonnel()
        {
            Personel personnel = DataBindingFactory.Create<Personel>();

            personnel.Ad = "";
            personnel.Soyad = "";
            personnel.TCID = "";
            personnel.Cinsiyet = 1; //CINSIYETI 1:Male, 2:Female
            personnel.KanGrubu = 8; //KANGRUBU
            personnel.EvAdresi = "";
            personnel.Mahalle = "";
            personnel.Ilce = "";
            personnel.Il = "";
            personnel.EvTelefonu = "";
            personnel.CepTelefonu = "";
            personnel.Email = "";

            return personnel;
        }                      
                                      
                       
        //'select H.SNR, H.AKOD, H.TANIM, H.GRUP, H.CODE, H.TARIH, H.NAME1, H.ADET, H.SATISF, H.KSATISF, H.MAKNO, H.SIRANO, B.AMBU 
        //from HIZIL H, BEHAND B 
        //where H.KNR=B.KNR and H.SNR=B.SNR and H.KNR=''870366'' AND h.SNR in (''993'') and B.IMPF2 is NULL and B.CIKTAR is null  
        //AND B.TAKIPSEND=''9'' order by H.TARIH'

        //select isnull(sum(ESATISF),0) as ESKISATISF, isnull(sum(YSATISF),0) as YENISATISF from HASTAINDIRIMLER_DETAY 
        //    where KNR='870366' and SNR='993' and SIRANO=1

        //select KNR, PFIYLIST, YFIYLIST,  ILACODE, SARFODE, HASTAKATILIM from KURADR where PSG='SGK'

        //select SATISF93 As SATISF, KSATISF93 As KSATISF from HIZMET where TANIM='00' and GRUP='011' and CODE='1700'

        //'SELECT INDIRIMORANI FROM KURUMINDIRIMORANLARI WHERE KNR=''01035'' AND TANIM=''00'' AND GRUP=''011''

        // INSERT into LOGKURUM_DEGISTI (KD_ID, KNR, TARIH, EPSG, YPSG, OHASTATOP, EHASTATOP, EKURUMTOP, YHASTATOP, YKURUMTOP, USER_ID, DATE_CREATE) values (275977,'870366','09.05.2011 10:32:10','SGK - ','SGK',0,20.33

        
        // Hasta Borç Alacak

        //select SNR, BHDAT, MTOPT from BEHAND where KNR='870366' and MTOPT>0 order by SNR
        //select SNR, TARIH, TUTAR, MAKBUZTIPI, BORCALACAK from KASA where KATILIM is NULL AND KNR='870366' and ISIPTAL is null order by SNR
        //select FATURATARIHI, INDIRIM, KDVTUTARI, YUVARLAMA from FATURA where KNR='870366' and ISIPTAL is null order by FATURATARIHI
    }

}
