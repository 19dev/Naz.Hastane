﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using Naz.Hastane.Data.Entities.LookUp;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data.Services
{
    public static class LookUpServices
    {

        public static List<T> GetAll<T>() where T : class
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                return (List<T>)session.CreateCriteria<T>().List<T>();
            }
        }

        #region LookUpLists

        #region privates
        private static List<BloodType> bloodTypes;
        private static List<City> cities;
        private static List<Depository> depositories;
        private static List<Doctor> doctors;
        private static List<FunctionGroup> functionGroups;
        private static List<FunctionGroupType> functionGroupTypes;
        private static List<IDType> iDTypes;
        private static List<Nationality> nationalities;
        private static List<PatientRelation> patientRelations;
        private static List<Room> rooms;
        private static List<Service> services;
        private static List<SystemSetting> systemSettings;
        private static List<User> users;
        private static List<VAT> vats;
        private static List<Warehouse> warehouses;

        private static List<FollowUpType> followUpTypes;
        private static List<InsuranceType> insuranceTypes;
        private static List<ProvisionType> provisionTypes;
        private static List<RelationType> relationTypes;
        private static List<TransferorInstitution> transferInstitutions;
        private static List<TreatmentStyle> treatmentStyles;
        private static List<TreatmentType> treatmentTypes;
        #endregion

        public static List<T> LookUpTable<T>(ref List<T> theObject) where T : class
        {
            if (theObject == null)
                theObject = GetAll<T>();
            return theObject;
        }

        public static List<BloodType> BloodTypes
        { get { return LookUpTable<BloodType>(ref bloodTypes); } }

        public static List<City> Cities
        { get { return LookUpTable<City>(ref cities); } }
        
        public static List<Depository> Depositories
        { get { return LookUpTable<Depository>(ref depositories); } }
        
        public static List<Doctor> Doctors
        { get { return LookUpTable<Doctor>(ref doctors); } }

        public static List<FunctionGroup> FunctionGroups
        { get { return LookUpTable<FunctionGroup>(ref functionGroups); } }

        public static List<FunctionGroupType> FunctionGroupTypes
        { get { return LookUpTable<FunctionGroupType>(ref functionGroupTypes); } }

        public static List<IDType> IDTypes
        { get { return LookUpTable<IDType>(ref iDTypes); } }
        
        public static List<Nationality> Nationalities
        { get { return LookUpTable<Nationality>(ref nationalities); } }
        
        public static List<PatientRelation> PatientRelations
        { get { return LookUpTable<PatientRelation>(ref patientRelations); } }

        public static List<Room> Rooms
        { get { return LookUpTable<Room>(ref rooms); } }

        public static List<Service> Services
        { get { return LookUpTable<Service>(ref services); } }

        public static List<SystemSetting> SystemSettings
        { get { return LookUpTable<SystemSetting>(ref systemSettings); } }

        public static List<User> Users
        { get { return LookUpTable<User>(ref users); } }

        public static List<VAT> VATs
        { get { return LookUpTable<VAT>(ref vats); } }

        public static List<Warehouse> Warehouses
        { get { return LookUpTable<Warehouse>(ref warehouses); } }

        #region Medula LookUp Tables
        public static List<FollowUpType> FollowUpTypes
        { get { return LookUpTable<FollowUpType>(ref followUpTypes); } }

        public static List<InsuranceType> InsuranceTypes
        { get { return LookUpTable<InsuranceType>(ref insuranceTypes); } }

        public static List<ProvisionType> ProvisionTypes
        { get { return LookUpTable<ProvisionType>(ref provisionTypes); } }

        public static List<RelationType> RelationTypes
        { get { return LookUpTable<RelationType>(ref relationTypes); } }

        public static List<TransferorInstitution> TransferorInstitutions
        { get { return LookUpTable<TransferorInstitution>(ref transferInstitutions); } }

        public static List<TreatmentStyle> TreatmentStyles
        { get { return LookUpTable<TreatmentStyle>(ref treatmentStyles); } }

        public static List<TreatmentType> TreatmentTypes
        { get { return LookUpTable<TreatmentType>(ref treatmentTypes); } }
        #endregion

        #endregion

        #region New Key Generators
        public static string GetNewPatientNo()
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                SystemSetting ss = session
                    .CreateCriteria(typeof(SystemSetting))
                    .Add(Restrictions.Eq("ID0", "00"))
                    .Add(Restrictions.Eq("ID", "KNR"))
                    .UniqueResult<SystemSetting>();
                int id = Convert.ToInt32(ss.Value);
                id += 1;
                ss.Value = id.ToString();
                session.Update(ss);
                transaction.Commit();
                return ss.Value;
            }
        }

        public static string GetNewPatientVisitNo(Patient patient)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                var ss = session
                    .CreateQuery("SELECT MIN(VisitNo) FROM PatientVisit as visit WHERE visit.Patient.PatientNo =" + patient.PatientNo)
                    .List();
                int id = 1000;
                if (ss[0] != null)
                    id = Convert.ToInt32(ss[0].ToString());
                id -= 1;
                return id.ToString();
            }
        }

        public static double GetNewPatientVisitDetailNo(PatientVisit pv)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                var ss = session
                    .CreateQuery("SELECT MAX(DetailNo) FROM PatientVisitDetail as pvd WHERE pvd.PatientVisit.Patient.PatientNo =" + pv.Patient.PatientNo +
                    " and pvd.PatientVisit.VisitNo = " + pv.VisitNo)
                    .List();
                double id = 0;
                if (ss[0] != null)
                    id = Convert.ToDouble(ss[0].ToString());
                id += 1;
                return id;
            }
        }
        #endregion

        public static List<Doctor> GetSGKDoctors()
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                return (List<Doctor>)session.QueryOver<Doctor>()
                    .OrderBy(x => x.Value).Asc
                    .JoinQueryOver(x => x.Service)
                        .Where(s => s.Type == ServiceTypes.ServiceTypePolyclinic)
                    .List<Doctor>();
            }
        }

        public static List<AccountingDailySummary>  GetAccountingDailySummary(DateTime date)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                string s = date.ToString("MMddyyyy");
                return (List<AccountingDailySummary>)session.GetNamedQuery("sp_GetGunlukMuhasebeFisi")
                    .SetDateTime("Date", date.Date)
                    .List<AccountingDailySummary>();
            }
        
        }
    }
}