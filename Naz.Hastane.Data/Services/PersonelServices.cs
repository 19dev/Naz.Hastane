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
    public static class PersonelServices
    {
        public static IList<Personel> GetPersonelByTCId(string aTCID)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return  (from p in session.Query<Personel>()
                    where p.TCID == aTCID
                    select p)
                    .ToList<Personel>();
            }
        }

        public static IList<Personel> GetPersonelByPersonelNo(string aPersonelNo)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return (from p in session.Query<Personel>()
                        where p.PersonelNo == aPersonelNo
                        select p)
                    .ToList<Personel>();
            }
        }

        public static Personel GetPersonelByID(int aPersonelNo)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetPersonelByID(aPersonelNo, session);
        }

        public static Personel GetPersonelByID(int aPersonelNo, ISession session)
        {
            if (aPersonelNo == 0)
                return null;

            return session.Get<Personel>(aPersonelNo);
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

        public static double GetNewPersonelNo()
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetNewPersonelNo(session);
        }

        public static double GetNewPersonelNo(ISession session)
        {
            double? a = session.QueryOver<Personel>()
                .Select(
                    Projections
                        .ProjectionList()
                        .Add(Projections.Max<Personel>(x => x.PersonelNo)))
                .List<double?>().First();

            return a.GetValueOrDefault() + 1;
        }
        
        public static Personel CreateNewPersonel()
        {
            Personel personel = DataBindingFactory.Create<Personel>();

            personel.Ad = "";
            personel.Soyad = "";
            personel.TCID = "";
            personel.Cinsiyeti = "E";
            personel.MedeniHali = "B";
            //Personel.KanGrubu = 9; 
            personel.KimlikTuru = "N";
            personel.EvAdresi = "";
            personel.Mahalle = "";
            personel.Ilce = "";
            personel.Il = "034";
            personel.EvTelefonu = "";
            personel.CepTelefonu = "";
            personel.Email = "";
            personel.IsRetired = "N";
            personel.HasUnion = "N";
            personel.IseGirisTarihi = DateTime.Today;
            personel.Uyrugu = "TC";

            return personel;
        }                      
         
        public static PersonelHastaneBolumu CreateNewPersonelHastaneBolumu()
        {
            return DataBindingFactory.Create<PersonelHastaneBolumu>();
        }
        public static PersonelEgitim CreateNewPersonelEgitim()
        {
            return DataBindingFactory.Create<PersonelEgitim>();
        }
        public static PersonelRapor CreateNewPersonelRapor()
        {
            return DataBindingFactory.Create<PersonelRapor>();
        }
        public static PersonelIzin CreateNewPersonelIzin()
        {
            return DataBindingFactory.Create<PersonelIzin>();
        }
        public static PersonelYabanciDil CreateNewPersonelYabanciDil()
        {
            return DataBindingFactory.Create<PersonelYabanciDil>();
        }
        public static PersonelSertifika CreateNewPersonelSertifika()
        {
            return DataBindingFactory.Create<PersonelSertifika>();
        }

    }

}
