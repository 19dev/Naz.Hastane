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

        public static List<T> LookUpTable<T>(ref List<T> theObject) where T : class
        {
            if (theObject == null)
                theObject = GetAll<T>();
            return theObject;
        }

        #region General Lookup Tables

        private static List<BloodType> _BloodTypes;
        public static List<BloodType> BloodTypes
        { get { return LookUpTable<BloodType>(ref _BloodTypes); } }

        private static List<City> _Cities;
        public static List<City> Cities
        { get { return LookUpTable<City>(ref _Cities); } }

        private static List<IDType> _IDTypes;
        public static List<IDType> IDTypes
        { get { return LookUpTable<IDType>(ref _IDTypes); } }

        private static List<Nationality> _Nationalities;
        public static List<Nationality> Nationalities
        { get { return LookUpTable<Nationality>(ref _Nationalities); } }

        private static List<PatientRelation> _PatientRelations;
        public static List<PatientRelation> PatientRelations
        { get { return LookUpTable<PatientRelation>(ref _PatientRelations); } }

        private static List<VAT> _VATs;
        public static List<VAT> VATs
        { get { return LookUpTable<VAT>(ref _VATs); } }

        private static List<YesNo> _YesNos;
        public static List<YesNo> YesNos
        { get { return LookUpTable<YesNo>(ref _YesNos); } }

        #endregion

        #region MedulaDiabet
        private static List<AcuteComplication> _AcuteComplications;
        public static List<AcuteComplication> AcuteComplications
        { get { return LookUpTable<AcuteComplication>(ref _AcuteComplications); } }

        private static List<ApplicationReason> _ApplicationReasons;
        public static List<ApplicationReason> ApplicationReasons
        { get { return LookUpTable<ApplicationReason>(ref _ApplicationReasons); } }

        private static List<DiseaseCode> _DiseaseCodes;
        public static List<DiseaseCode> DiseaseCodes
        { get { return LookUpTable<DiseaseCode>(ref _DiseaseCodes); } }

        private static List<EKG> _EKGs;
        public static List<EKG> EKGs
        { get { return LookUpTable<EKG>(ref _EKGs); } }

        private static List<Exercise> _Exercises;
        public static List<Exercise> Exercises
        { get { return LookUpTable<Exercise>(ref _Exercises); } }

        private static List<EyeExam> _EyeExams;
        public static List<EyeExam> EyeExams
        { get { return LookUpTable<EyeExam>(ref _EyeExams); } }

        private static List<FootExam> _FootExams;
        public static List<FootExam> FootExams
        { get { return LookUpTable<FootExam>(ref _FootExams); } }

        private static List<HabitCode> _HabitCodes;
        public static List<HabitCode> HabitCodes
        { get { return LookUpTable<HabitCode>(ref _HabitCodes); } }

        private static List<PositiveNegative> _PositiveNegatives;
        public static List<PositiveNegative> PositiveNegatives
        { get { return LookUpTable<PositiveNegative>(ref _PositiveNegatives); } }

        private static List<ResidentialType> _ResidentialTypes;
        public static List<ResidentialType> ResidentialTypes
        { get { return LookUpTable<ResidentialType>(ref _ResidentialTypes); } }

        private static List<TBT> _TBTs;
        public static List<TBT> TBTs
        { get { return LookUpTable<TBT>(ref _TBTs); } }

        private static List<VarYok> _VarYoks;
        public static List<VarYok> VarYoks
        { get { return LookUpTable<VarYok>(ref _VarYoks); } }
        #endregion

        #region MedulaProvision
        private static List<BranchCode> _BranchCodes;
        public static List<BranchCode> BranchCodes
        { get { return LookUpTable<BranchCode>(ref _BranchCodes); } }

        private static List<FollowUpType> _FollowUpTypes;
        public static List<FollowUpType> FollowUpTypes
        { get { return LookUpTable<FollowUpType>(ref _FollowUpTypes); } }

        private static List<InsuranceType> _InsuranceTypes;
        public static List<InsuranceType> InsuranceTypes
        { get { return LookUpTable<InsuranceType>(ref _InsuranceTypes); } }

        private static List<ProvisionType> _ProvisionTypes;
        public static List<ProvisionType> ProvisionTypes
        { get { return LookUpTable<ProvisionType>(ref _ProvisionTypes); } }

        private static List<RelationType> _RelationTypes;
        public static List<RelationType> RelationTypes
        { get { return LookUpTable<RelationType>(ref _RelationTypes); } }

        private static List<TransferorInstitution> _TransferInstitutions;
        public static List<TransferorInstitution> TransferorInstitutions
        { get { return LookUpTable<TransferorInstitution>(ref _TransferInstitutions); } }

        private static List<TreatmentStyle> _TreatmentStyles;
        public static List<TreatmentStyle> TreatmentStyles
        { get { return LookUpTable<TreatmentStyle>(ref _TreatmentStyles); } }

        private static List<TreatmentType> _TreatmentTypes;
        public static List<TreatmentType> TreatmentTypes
        { get { return LookUpTable<TreatmentType>(ref _TreatmentTypes); } }
        #endregion

        #region MedulaReport
        private static List<DoctorType> _DoctorTypes;
        public static List<DoctorType> DoctorTypes
        { get { return LookUpTable<DoctorType>(ref _DoctorTypes); } }

        private static List<EditingType> _EditingTypes;
        public static List<EditingType> EditingTypes
        { get { return LookUpTable<EditingType>(ref _EditingTypes); } }

        private static List<ESWTBodyPart> _ESWTBodyParts;
        public static List<ESWTBodyPart> ESWTBodyParts
        { get { return LookUpTable<ESWTBodyPart>(ref _ESWTBodyParts); } }

        private static List<FTRBodyPart> _FTRBodyParts;
        public static List<FTRBodyPart> FTRBodyParts
        { get { return LookUpTable<FTRBodyPart>(ref _FTRBodyParts); } }

        private static List<KidneyStoneLocalisationCode> _KidneyStoneLocalisationCodes;
        public static List<KidneyStoneLocalisationCode> KidneyStoneLocalisationCodes
        { get { return LookUpTable<KidneyStoneLocalisationCode>(ref _KidneyStoneLocalisationCodes); } }

        private static List<KidneyType> _KidneyTypes;
        public static List<KidneyType> KidneyTypes
        { get { return LookUpTable<KidneyType>(ref _KidneyTypes); } }

        private static List<MedulaReportTreatmentType> _MedulaReportTreatmentTypes;
        public static List<MedulaReportTreatmentType> MedulaReportTreatmentTypes
        { get { return LookUpTable<MedulaReportTreatmentType>(ref _MedulaReportTreatmentTypes); } }

        private static List<MedulaReportType> _MedulaReportTypes;
        public static List<MedulaReportType> MedulaReportTypes
        { get { return LookUpTable<MedulaReportType>(ref _MedulaReportTypes); } }

        #endregion

        #region Special LookUp Tables
        private static List<Depository> _Depositories;
        public static List<Depository> Depositories
        { get { return LookUpTable<Depository>(ref _Depositories); } }

        private static List<Doctor> _Doctors;
        public static List<Doctor> Doctors
        { get { return LookUpTable<Doctor>(ref _Doctors); } }

        private static List<FunctionGroup> _FunctionGroups;
        public static List<FunctionGroup> FunctionGroups
        { get { return LookUpTable<FunctionGroup>(ref _FunctionGroups); } }

        private static List<FunctionGroupType> _FunctionGroupTypes;
        public static List<FunctionGroupType> FunctionGroupTypes
        { get { return LookUpTable<FunctionGroupType>(ref _FunctionGroupTypes); } }

        private static List<Room> _Rooms;
        public static List<Room> Rooms
        { get { return LookUpTable<Room>(ref _Rooms); } }

        private static List<Service> _Services;
        public static List<Service> Services
        { get { return LookUpTable<Service>(ref _Services); } }

        private static List<SystemSetting> _SystemSettings;
        public static List<SystemSetting> SystemSettings
        { get { return LookUpTable<SystemSetting>(ref _SystemSettings); } }

        private static List<User> _Users;
        public static List<User> Users
        { get { return LookUpTable<User>(ref _Users); } }

        private static List<Warehouse> _Warehouses;
        public static List<Warehouse> Warehouses
        { get { return LookUpTable<Warehouse>(ref _Warehouses); } }

        #endregion

        private static List<Doctor> _SGKDoctors;
        public static List<Doctor> SGKDoctors
        { 
            get 
            {
                if (_SGKDoctors == null)
                {
                    using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                    {
                        _SGKDoctors = (List<Doctor>)session.QueryOver<Doctor>()
                            .OrderBy(x => x.Value).Asc
                            .JoinQueryOver(x => x.Service)
                                .Where(s => s.Type == ServiceTypes.ServiceTypePolyclinic)
                            .JoinQueryOver<SGKAutoExamination>(x => x.SGKAutoExaminations)
                            .JoinQueryOver<Product>(x => x.Product)
                            .TransformUsing(Transformers.DistinctRootEntity)

                            .List<Doctor>();
                    }
                }
                return _SGKDoctors;
            }
        }

        #endregion

        public static List<SGKAutoExamination> SGKAutoExaminations(string servisCode)
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
