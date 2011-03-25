using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.StoredProcedure;
using NHibernate;
using NHibernate.Transform;

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

        private static List<Doctor> sgkDoctors;

        public static List<T> LookUpTable<T>(ref List<T> theObject) where T : class
        {
            if (theObject == null)
                theObject = GetAll<T>();
            return theObject;
        }

        #endregion

        #region General Lookup Tables

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

        #endregion

        #region MedulaDiabet
        private static List<AcuteComplication> acuteComplication;
        private static List<ApplicationReason> applicationReason;
        private static List<DiseaseCode> diseaseCode;
        private static List<EKG> ekg;
        private static List<Exercise> exercise;
        private static List<EyeExam> eyeExam;
        private static List<FootExam> footExam;
        private static List<HabitCode> habitCode;
        private static List<PositiveNegative> positiveNegative;
        private static List<ResidentialType> residentialType;
        private static List<TBT> tbt;
        private static List<VarYok> varYok;

        public static List<AcuteComplication> AcuteComplication
        { get { return LookUpTable<AcuteComplication>(ref acuteComplication); } }

        public static List<ApplicationReason> ApplicationReason
        { get { return LookUpTable<ApplicationReason>(ref applicationReason); } }

        public static List<DiseaseCode> DiseaseCode
        { get { return LookUpTable<DiseaseCode>(ref diseaseCode); } }

        public static List<EKG> EKG
        { get { return LookUpTable<EKG>(ref ekg); } }

        public static List<Exercise> Exercise
        { get { return LookUpTable<Exercise>(ref exercise); } }

        public static List<EyeExam> EyeExam
        { get { return LookUpTable<EyeExam>(ref eyeExam); } }

        public static List<FootExam> FootExam
        { get { return LookUpTable<FootExam>(ref footExam); } }

        public static List<HabitCode> HabitCode
        { get { return LookUpTable<HabitCode>(ref habitCode); } }

        public static List<PositiveNegative> PositiveNegative
        { get { return LookUpTable<PositiveNegative>(ref positiveNegative); } }

        public static List<ResidentialType> ResidentialType
        { get { return LookUpTable<ResidentialType>(ref residentialType); } }

        public static List<TBT> TBT
        { get { return LookUpTable<TBT>(ref tbt); } }

        public static List<VarYok> VarYok
        { get { return LookUpTable<VarYok>(ref varYok); } }
        #endregion

        #region MedulaProvision
        private static List<BranchCode> branchCodes;
        private static List<FollowUpType> followUpTypes;
        private static List<InsuranceType> insuranceTypes;
        private static List<ProvisionType> provisionTypes;
        private static List<RelationType> relationTypes;
        private static List<TransferorInstitution> transferInstitutions;
        private static List<TreatmentStyle> treatmentStyles;
        private static List<TreatmentType> treatmentTypes;

        public static List<BranchCode> BranchCodes
        { get { return LookUpTable<BranchCode>(ref branchCodes); } }

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

        public static List<Doctor> GetSGKDoctors()
        {
            if (sgkDoctors == null)
            {
                using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                {
                    sgkDoctors = (List<Doctor>)session.QueryOver<Doctor>()
                        .OrderBy(x => x.Value).Asc
                        .JoinQueryOver(x => x.Service)
                            .Where(s => s.Type == ServiceTypes.ServiceTypePolyclinic)
                        .JoinQueryOver<SGKAutoExamination>(x => x.SGKAutoExaminations)
                        .JoinQueryOver<Product>(x => x.Product)
                        .TransformUsing(Transformers.DistinctRootEntity)

                        .List<Doctor>();
                }
            }
            return sgkDoctors;
        }

        public static List<SGKAutoExamination> GetSGKAutoExaminations(string servisCode)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                return (List<SGKAutoExamination>)session.QueryOver<SGKAutoExamination>()
                    .Where(s => s.Service.ID == servisCode)
                    .List<SGKAutoExamination>();
            }
        }

        public static List<AccountingDailySummary> GetAccountingDailySummary(DateTime date)
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
