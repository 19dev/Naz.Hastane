using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.General;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.LookUp.MedulaReport;
using Naz.Hastane.Data.Entities.LookUp.Special;
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
        private static List<IDType> iDTypes;
        private static List<Nationality> nationalities;
        private static List<PatientRelation> patientRelations;
        private static List<VAT> vats;
        private static List<YesNo> yesNos;

        public static List<BloodType> BloodTypes
        { get { return LookUpTable<BloodType>(ref bloodTypes); } }
        public static List<City> Cities
        { get { return LookUpTable<City>(ref cities); } }
        public static List<IDType> IDTypes
        { get { return LookUpTable<IDType>(ref iDTypes); } }
        public static List<Nationality> Nationalities
        { get { return LookUpTable<Nationality>(ref nationalities); } }
        public static List<PatientRelation> PatientRelations
        { get { return LookUpTable<PatientRelation>(ref patientRelations); } }
        public static List<VAT> VATs
        { get { return LookUpTable<VAT>(ref vats); } }
        public static List<YesNo> YesNos
        { get { return LookUpTable<YesNo>(ref yesNos); } }

        #endregion

        #region MedulaDiabet
        private static List<AcuteComplication> acuteComplications;
        private static List<ApplicationReason> applicationReasons;
        private static List<DiseaseCode> diseaseCodes;
        private static List<EKG> ekgs;
        private static List<Exercise> exercises;
        private static List<EyeExam> eyeExams;
        private static List<FootExam> footExams;
        private static List<HabitCode> habitCodes;
        private static List<PositiveNegative> positiveNegatives;
        private static List<ResidentialType> residentialTypes;
        private static List<TBT> tbts;
        private static List<VarYok> varYoks;

        public static List<AcuteComplication> AcuteComplications
        { get { return LookUpTable<AcuteComplication>(ref acuteComplications); } }
        public static List<ApplicationReason> ApplicationReasons
        { get { return LookUpTable<ApplicationReason>(ref applicationReasons); } }
        public static List<DiseaseCode> DiseaseCodes
        { get { return LookUpTable<DiseaseCode>(ref diseaseCodes); } }
        public static List<EKG> EKGs
        { get { return LookUpTable<EKG>(ref ekgs); } }
        public static List<Exercise> Exercises
        { get { return LookUpTable<Exercise>(ref exercises); } }
        public static List<EyeExam> EyeExams
        { get { return LookUpTable<EyeExam>(ref eyeExams); } }
        public static List<FootExam> FootExams
        { get { return LookUpTable<FootExam>(ref footExams); } }
        public static List<HabitCode> HabitCodes
        { get { return LookUpTable<HabitCode>(ref habitCodes); } }
        public static List<PositiveNegative> PositiveNegatives
        { get { return LookUpTable<PositiveNegative>(ref positiveNegatives); } }
        public static List<ResidentialType> ResidentialTypes
        { get { return LookUpTable<ResidentialType>(ref residentialTypes); } }
        public static List<TBT> TBTs
        { get { return LookUpTable<TBT>(ref tbts); } }
        public static List<VarYok> VarYoks
        { get { return LookUpTable<VarYok>(ref varYoks); } }
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

        #region MedulaReport
        private static List<DoctorType> doctorTypes;
        private static List<EditingType> editingTypes;
        private static List<ESWTBodyPart> eswtBodyParts;
        private static List<FTRBodyPart> ftrBodyParts;
        private static List<MedulaReportTreatmentType> medulaReportTreatmentTypes;
        private static List<MedulaReportType> medulaReportTypes;

        public static List<DoctorType> DoctorTypes
        { get { return LookUpTable<DoctorType>(ref doctorTypes); } }
        public static List<EditingType> EditingTypes
        { get { return LookUpTable<EditingType>(ref editingTypes); } }
        public static List<ESWTBodyPart> ESWTBodyParts
        { get { return LookUpTable<ESWTBodyPart>(ref eswtBodyParts); } }
        public static List<FTRBodyPart> FTRBodyParts
        { get { return LookUpTable<FTRBodyPart>(ref ftrBodyParts); } }
        public static List<MedulaReportTreatmentType> MedulaReportTreatmentTypes
        { get { return LookUpTable<MedulaReportTreatmentType>(ref medulaReportTreatmentTypes); } }
        public static List<MedulaReportType> MedulaReportTypes
        { get { return LookUpTable<MedulaReportType>(ref medulaReportTypes); } }

        #endregion

        #region Special LookUp Tables
        private static List<Depository> depositories;
        private static List<Doctor> doctors;
        private static List<FunctionGroup> functionGroups;
        private static List<FunctionGroupType> functionGroupTypes;
        private static List<Room> rooms;
        private static List<Service> services;
        private static List<SystemSetting> systemSettings;
        private static List<User> users;
        private static List<Warehouse> warehouses;

        public static List<Depository> Depositories
        { get { return LookUpTable<Depository>(ref depositories); } }
        public static List<Doctor> Doctors
        { get { return LookUpTable<Doctor>(ref doctors); } }
        public static List<FunctionGroup> FunctionGroups
        { get { return LookUpTable<FunctionGroup>(ref functionGroups); } }
        public static List<FunctionGroupType> FunctionGroupTypes
        { get { return LookUpTable<FunctionGroupType>(ref functionGroupTypes); } }
        public static List<Room> Rooms
        { get { return LookUpTable<Room>(ref rooms); } }
        public static List<Service> Services
        { get { return LookUpTable<Service>(ref services); } }
        public static List<SystemSetting> SystemSettings
        { get { return LookUpTable<SystemSetting>(ref systemSettings); } }
        public static List<User> Users
        { get { return LookUpTable<User>(ref users); } }
        public static List<Warehouse> Warehouses
        { get { return LookUpTable<Warehouse>(ref warehouses); } }

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
