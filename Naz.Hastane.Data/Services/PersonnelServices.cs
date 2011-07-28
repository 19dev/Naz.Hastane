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
            if (aPersonnelNo == 0)
                return null;
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
            personnel.Cinsiyeti = ""; 
            personnel.KanGrubu = ""; 
            personnel.EvAdresi = "";
            personnel.Mahalle = "";
            personnel.Ilce = "";
            personnel.Il = "";
            personnel.EvTelefonu = "";
            personnel.CepTelefonu = "";
            personnel.Email = "";

            return personnel;
        }                      
                                      
                       
    }

}
