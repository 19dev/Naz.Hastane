using System;
using System.Collections.Generic;
using System.Linq;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.General;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.LookUp.MedulaReport;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Entities.StoredProcedure;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Transform;
using Naz.Hastane.Data.Entities.Reports;

namespace Naz.Hastane.Data.Services
{
    public static class LookUpServices
    {

        public static T GetByID<T>(string aID)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
                return session.Get<T>(aID);
        }

        public static IList<T> GetAll<T>() where T : class
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return session.CreateCriteria<T>().List<T>();
            }
        }

        #region LookUpLists

        public static IList<T> LookUpTable<T>(ref IList<T> theObject) where T : class
        {
            if (theObject == null)
                theObject = GetAll<T>();
            return theObject;
        }

        #region General Lookup Tables

        private static IList<BloodType> _BloodTypes;
        public static IList<BloodType> BloodTypes
        { get { return LookUpTable(ref _BloodTypes); } }

        private static IList<City> _Cities;
        public static IList<City> Cities
        { get { return LookUpTable(ref _Cities); } }

        private static IList<IDType> _IDTypes;
        public static IList<IDType> IDTypes
        { get { return LookUpTable(ref _IDTypes); } }

        private static IList<Nationality> _Nationalities;
        public static IList<Nationality> Nationalities
        { get { return LookUpTable(ref _Nationalities); } }

        private static IList<PatientRelation> _PatientRelations;
        public static IList<PatientRelation> PatientRelations
        { get { return LookUpTable(ref _PatientRelations); } }

        private static IList<VAT> _VATs;
        public static IList<VAT> VATs
        { get { return LookUpTable(ref _VATs); } }

        private static IList<YesNo> _YesNos;
        public static IList<YesNo> YesNos
        { get { return LookUpTable(ref _YesNos); } }

        #endregion

        #region MedulaDiabet
        private static IList<AcuteComplication> _AcuteComplications;
        public static IList<AcuteComplication> AcuteComplications
        { get { return LookUpTable(ref _AcuteComplications); } }

        private static IList<ApplicationReason> _ApplicationReasons;
        public static IList<ApplicationReason> ApplicationReasons
        { get { return LookUpTable(ref _ApplicationReasons); } }

        private static IList<DiseaseCode> _DiseaseCodes;
        public static IList<DiseaseCode> DiseaseCodes
        { get { return LookUpTable(ref _DiseaseCodes); } }

        private static IList<EKG> _EKGs;
        public static IList<EKG> EKGs
        { get { return LookUpTable(ref _EKGs); } }

        private static IList<Exercise> _Exercises;
        public static IList<Exercise> Exercises
        { get { return LookUpTable(ref _Exercises); } }

        private static IList<EyeExam> _EyeExams;
        public static IList<EyeExam> EyeExams
        { get { return LookUpTable(ref _EyeExams); } }

        private static IList<FootExam> _FootExams;
        public static IList<FootExam> FootExams
        { get { return LookUpTable(ref _FootExams); } }

        private static IList<HabitCode> _HabitCodes;
        public static IList<HabitCode> HabitCodes
        { get { return LookUpTable(ref _HabitCodes); } }

        private static IList<PositiveNegative> _PositiveNegatives;
        public static IList<PositiveNegative> PositiveNegatives
        { get { return LookUpTable(ref _PositiveNegatives); } }

        private static IList<ResidentialType> _ResidentialTypes;
        public static IList<ResidentialType> ResidentialTypes
        { get { return LookUpTable(ref _ResidentialTypes); } }

        private static IList<TBT> _TBTs;
        public static IList<TBT> TBTs
        { get { return LookUpTable(ref _TBTs); } }

        private static IList<VarYok> _VarYoks;
        public static IList<VarYok> VarYoks
        { get { return LookUpTable(ref _VarYoks); } }
        #endregion

        #region MedulaProvision
        private static IList<BranchCode> _BranchCodes;
        public static IList<BranchCode> BranchCodes
        { get { return LookUpTable(ref _BranchCodes); } }

        private static IList<FollowUpType> _FollowUpTypes;
        public static IList<FollowUpType> FollowUpTypes
        { get { return LookUpTable(ref _FollowUpTypes); } }

        private static IList<InsuranceType> _InsuranceTypes;
        public static IList<InsuranceType> InsuranceTypes
        { get { return LookUpTable(ref _InsuranceTypes); } }

        private static IList<ProvisionType> _ProvisionTypes;
        public static IList<ProvisionType> ProvisionTypes
        { get { return LookUpTable(ref _ProvisionTypes); } }

        private static IList<RelationType> _RelationTypes;
        public static IList<RelationType> RelationTypes
        { get { return LookUpTable(ref _RelationTypes); } }

        private static IList<TransferorInstitution> _TransferInstitutions;
        public static IList<TransferorInstitution> TransferorInstitutions
        { get { return LookUpTable(ref _TransferInstitutions); } }

        private static IList<TreatmentStyle> _TreatmentStyles;
        public static IList<TreatmentStyle> TreatmentStyles
        { get { return LookUpTable(ref _TreatmentStyles); } }

        private static IList<TreatmentType> _TreatmentTypes;
        public static IList<TreatmentType> TreatmentTypes
        { get { return LookUpTable(ref _TreatmentTypes); } }
        #endregion

        #region MedulaReport
        private static IList<DoctorType> _DoctorTypes;
        public static IList<DoctorType> DoctorTypes
        { get { return LookUpTable(ref _DoctorTypes); } }

        private static IList<EditingType> _EditingTypes;
        public static IList<EditingType> EditingTypes
        { get { return LookUpTable(ref _EditingTypes); } }

        private static IList<EffectiveSubstance> _EffectiveSubstances;
        public static IList<EffectiveSubstance> EffectiveSubstances
        { get { return LookUpTable(ref _EffectiveSubstances); } }

        private static IList<ESWTBodyPart> _ESWTBodyParts;
        public static IList<ESWTBodyPart> ESWTBodyParts
        { get { return LookUpTable(ref _ESWTBodyParts); } }

        private static IList<FTRBodyPart> _FTRBodyParts;
        public static IList<FTRBodyPart> FTRBodyParts
        { get { return LookUpTable(ref _FTRBodyParts); } }

        private static IList<KidneyStoneLocalisationCode> _KidneyStoneLocalisationCodes;
        public static IList<KidneyStoneLocalisationCode> KidneyStoneLocalisationCodes
        { get { return LookUpTable(ref _KidneyStoneLocalisationCodes); } }

        private static IList<KidneyType> _KidneyTypes;
        public static IList<KidneyType> KidneyTypes
        { get { return LookUpTable(ref _KidneyTypes); } }

        private static IList<MedulaReportTreatmentType> _MedulaReportTreatmentTypes;
        public static IList<MedulaReportTreatmentType> MedulaReportTreatmentTypes
        { get { return LookUpTable(ref _MedulaReportTreatmentTypes); } }

        private static IList<MedulaReportType> _MedulaReportTypes;
        public static IList<MedulaReportType> MedulaReportTypes
        { get { return LookUpTable(ref _MedulaReportTypes); } }

        #endregion

        #region Special LookUp Tables
        private static IList<Depository> _Depositories;
        public static IList<Depository> Depositories
        { get { return LookUpTable(ref _Depositories); } }

        private static IList<Doctor> _Doctors;
        public static IList<Doctor> Doctors
        { get { return LookUpTable(ref _Doctors); } }

        private static IList<FunctionGroup> _FunctionGroups;
        public static IList<FunctionGroup> FunctionGroups
        { get { return LookUpTable(ref _FunctionGroups); } }

        private static IList<FunctionGroupType> _FunctionGroupTypes;
        public static IList<FunctionGroupType> FunctionGroupTypes
        { get { return LookUpTable(ref _FunctionGroupTypes); } }

        private static IList<Room> _Rooms;
        public static IList<Room> Rooms
        { get { return LookUpTable(ref _Rooms); } }

        private static IList<Service> _Services;
        public static IList<Service> Services
        { get { return LookUpTable(ref _Services); } }

        private static IList<SystemSetting> _SystemSettings;
        public static IList<SystemSetting> SystemSettings
        { get { return LookUpTable(ref _SystemSettings); } }

        private static IList<User> _Users;
        public static IList<User> Users
        { get { return LookUpTable(ref _Users); } }

        private static IList<Warehouse> _Warehouses;
        public static IList<Warehouse> Warehouses
        { get { return LookUpTable(ref _Warehouses); } }

        #endregion

        #region AdminReports

        private static IList<OzetAYPAnaIslem> _OzetAYPAnaIslems;
        public static IList<OzetAYPAnaIslem> OzetAYPAnaIslems
        { get { return LookUpTable(ref _OzetAYPAnaIslems); } }

        private static IList<OzetAYPKurum> _OzetAYPKurums;
        public static IList<OzetAYPKurum> OzetAYPKurums
        { get { return LookUpTable(ref _OzetAYPKurums); } }

        private static IList<OzetDoktorAnaIslem> _OzetDoktorAnaIslems;
        public static IList<OzetDoktorAnaIslem> OzetDoktorAnaIslems
        { get { return LookUpTable(ref _OzetDoktorAnaIslems); } }

        private static IList<OzetHastaneServisAnaIslem> _OzetHastaneServisAnaIslems;
        public static IList<OzetHastaneServisAnaIslem> OzetHastaneServisAnaIslems
        { get { return LookUpTable(ref _OzetHastaneServisAnaIslems); } }

        private static IList<OzetKurumAnaIslem> _OzetKurumAnaIslems;
        public static IList<OzetKurumAnaIslem> OzetKurumAnaIslems
        { get { return LookUpTable(ref _OzetKurumAnaIslems); } }

        private static IList<OzetServisAnaIslem> _OzetServisAnaIslems;
        public static IList<OzetServisAnaIslem> OzetServisAnaIslems
        { get { return LookUpTable(ref _OzetServisAnaIslems); } }

        #endregion

        private static IList<Doctor> _SGKDoctors;
        public static IList<Doctor> SGKDoctors
        { 
            get 
            {
                if (_SGKDoctors == null)
                {
                    using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
                    {
                        _SGKDoctors = session.QueryOver<Doctor>()
                            .OrderBy(x => x.Value).Asc
                            .JoinQueryOver(x => x.Service)
                                .Where(s => s.Type == ServiceTypes.ServiceTypePolyclinic)
                            .JoinQueryOver<SGKAutoExamination>(x => x.SGKAutoExaminations)
                            .JoinQueryOver<Product>(x => x.Product)
                            .TransformUsing(Transformers.DistinctRootEntity)
                            .List();
                    }
                }
                return _SGKDoctors;
            }
        }

        private static IList<Doctor> _SGKLicensedDoctors;
        public static IList<Doctor> SGKLicensedDoctors
        {
            get
            {
                if (_SGKLicensedDoctors == null)
                {
                    using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                    {
                        _SGKLicensedDoctors = session.QueryOver<Doctor>()
                            .OrderBy(x => x.Value).Asc
                            .Where(x => x.LicenseNo != "0")
                            .And(x => x.LicenseNo != null)
                            .And(x => x.LicenseNo != "")
                            .List();
                    }
                }
                return _SGKLicensedDoctors;
            }
        }

        private static IList<Service> _ServiceBranchCodes;
        public static IList<Service> ServiceBranchCodes
        {
            get
            {
                if (_ServiceBranchCodes == null)
                {
                    using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                    {
                        _ServiceBranchCodes = session.QueryOver<Service>()
                            .OrderBy(x => x.Value).Asc
                            .Where(x => x.BranchCode != "0")
                            .List();
                    }
                }
                return _ServiceBranchCodes;
            }
        }

        #endregion

        public static IList<SGKAutoExamination> SGKAutoExaminations(string servisCode)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return session.QueryOver<SGKAutoExamination>()
                    .Where(s => s.Service.ID == servisCode)
                    .List();
            }
        }

        public static IList<AccountingDailySummary> GetAccountingDailySummary(DateTime date)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                string s = date.ToString("MMddyyyy");
                return session.GetNamedQuery("sp_GetGunlukMuhasebeFisi")
                    .SetDateTime("Date", date.Date)
                    .List<AccountingDailySummary>();
            }
        
        }

        #region ID Generators
        public static string GetNewSystemSettingNo(string key)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                string serialID = "";
                int serialNo = 0;

                /// TODO Add control for no element
                SystemSetting ss = (from systemSetting in session.Query<SystemSetting>()
                                    where systemSetting.ID0 == "00" && systemSetting.ID == key
                                    select systemSetting
                                    ).Single<SystemSetting>();

                for (int i = ss.Value.Length - 1; i >= 0; i--)
                {
                    if (!Char.IsNumber(ss.Value[i]))
                    {
                        serialID = ss.Value.Substring(0, i+1);
                        string s = ss.Value.Substring(i + 1);
                        serialNo = Convert.ToInt32(s);
                        break;
                    }
                    if (i == 0)
                        serialNo = Convert.ToInt32(ss.Value);
                }
                serialNo += 1;
                ss.Value = serialID + serialNo.ToString();
                try
                {
                    session.Update(ss);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }

                return ss.Value;
            }
        }

        public static string GetNewInvoiceNo()
        {
            return GetNewSystemSettingNo("FATNO");
        }

        public static string GetNewVoucherNo()
        {
            return GetNewSystemSettingNo("MAKNO");
        }

        public static string GetNewAdvancePaymentNo()
        {
            return GetNewSystemSettingNo("AVANS_ID");
        }

        public static string GetNewTellerInvoiceNo(User user)
        {
            return GetNewSystemSettingNo("KELEGNUM" + user.VEZNE);
        }

        public static string GetNewTellerVoucherNo(User user)
        {
            return GetNewSystemSettingNo("MAKNUM" + user.VEZNE);
        }

        #endregion

    }
}
