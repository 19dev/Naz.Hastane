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
using Naz.Hastane.Data.Entities.LookUp;

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
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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

        public static IList<T> LookUpTable<T>(ref IList<T> theObject, string discriminatorValue) where T : OldLookUpBase
        {
            if (theObject == null)
            {
                using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                {
                    return (from t in session.Query<T>()
                            where t.ID0 == discriminatorValue
                            select t
                            ).ToList<T>();
                }

            }
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

        private static IList<PaymentType> _PaymentTypes;
        public static IList<PaymentType> PaymentTypes
        { get { return LookUpTable(ref _PaymentTypes); } }

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

        private static IList<InsuranceCompany> _InsuranceCompanys;
        public static IList<InsuranceCompany> InsuranceCompanys
        { get { return LookUpTable(ref _InsuranceCompanys); } }

        private static IList<FunctionGroup> _FunctionGroups;
        public static IList<FunctionGroup> FunctionGroups
        { get { return LookUpTable(ref _FunctionGroups); } }

        private static IList<SubFunctionGroup> _SubFunctionGroups;
        public static IList<SubFunctionGroup> SubFunctionGroups
        { get { return LookUpTable(ref _SubFunctionGroups); } }

        private static IList<FunctionGroupType> _FunctionGroupTypes;
        public static IList<FunctionGroupType> FunctionGroupTypes
        { get { return LookUpTable(ref _FunctionGroupTypes); } }

        private static IList<POS> _POSs;
        public static IList<POS> POSs
        { get { return LookUpTable(ref _POSs); } }

        private static IList<PriceList> _PriceLists;
        public static IList<PriceList> PriceLists
        { get { return LookUpTable(ref _PriceLists); } }

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

        private static IList<User> _Tellers;
        public static IList<User> Tellers
        {
            get
            {
                if (_Tellers == null)
                {
                    using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                    {
                        _Tellers = (from user in session.Query<User>()
                                       where user.VEZNE != null
                                       orderby user.USER_ID ascending
                                       select user
                                      )
                                      .ToList<User>();
                    }
                }
                return _Tellers;
            }
        }

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

        public static InsuranceCompany GetSGK(ISession session)
        {
            return session.Get<InsuranceCompany>(InsuranceCompany.SGKCode);
        }
        public static InsuranceCompany GetSGKAcil(ISession session)
        {
            return session.Get<InsuranceCompany>(InsuranceCompany.SGKAcilCode);
        }
        public static InsuranceCompany GetNormalPatientCode(ISession session)
        {
            return session.Get<InsuranceCompany>(InsuranceCompany.NormalPatientCode);
        }
        public static InsuranceCompany GetSpecialPatientCode(ISession session)
        {
            return session.Get<InsuranceCompany>(InsuranceCompany.SpecialPatientCode);
        }

        public static IList<Doctor> GetSGKDoctors(ISession session)
        { 
            IList<Doctor> result = (from doctor in session.Query<Doctor>()
                            where doctor.Service.Type == ServiceTypes.ServiceTypePolyclinic 
                                && doctor.Service.SGKAutoExaminations.Count > 0
                                && doctor.OnLeave == 0
                            join service in session.Query<Service>() on doctor.Service.Code equals service.Code
                            join sae in session.Query<SGKAutoExamination>() on service equals sae.Service
                            join product in session.Query<Product>() on sae.Product equals product
                            orderby doctor.Value
                            select doctor
                            )
                            .Distinct<Doctor>()
                            .ToList<Doctor>();
            return result;
        }

        public static IList<SGKAutoExamination> GetSGKAutoExaminations(Service service)
        {
            IList<SGKAutoExamination> result = new List<SGKAutoExamination>();
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                result = (from sae in session.Query<SGKAutoExamination>()
                        where sae.Service == service
                        select sae
                        )
                        .ToList<SGKAutoExamination>();
            }
            return result;
        }

        public static IList<SGKAutoExaminationSameDay> GetSGKAutoExaminationSameDays(Service service)
        {
            IList<SGKAutoExaminationSameDay> result = new List<SGKAutoExaminationSameDay>();
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                result = (from sae in session.Query<SGKAutoExaminationSameDay>()
                          where sae.Service == service
                          select sae
                        )
                        .ToList<SGKAutoExaminationSameDay>();
            }
            return result;
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

        public static IList<Product> GetProducts(string tanim, string grup, string priceList)
        {
            IList<Product> products = null;

            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                products = (from p in session.Query<Product>()
                               where p.TANIM == tanim && p.GRUP == grup
                               orderby p.NAME1
                               select p
                              )
                              .ToList<Product>();
            }
            foreach (Product p in products)
                p.SetPriceList(priceList);
            return products;
        }

        public static IList<Product> GetProducts(string tanim, string priceList)
        {
            IList<Product> products = null;

            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                products = (from p in session.Query<Product>()
                            where p.TANIM == tanim
                            orderby p.NAME1
                            select p
                              )
                              .ToList<Product>();
            }
            foreach (Product p in products)
                p.SetPriceList(priceList);
            return products;
        }

        public static Product GetProduct(ISession session, string tanim, string grup, string code, string priceList)
        {
            Product product = (from p in session.Query<Product>()
                        where p.TANIM == tanim && p.GRUP == grup && p.CODE == code
                        select p
                            )
                            .SingleOrDefault<Product>();
            product.SetPriceList(priceList);
            return product;
        }

        #endregion

        public static IList<SGKAutoExamination> SGKAutoExaminations(string servisCode)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return (from sae in session.Query<SGKAutoExamination>()
                        where sae.Service.Code == servisCode
                        select sae
                        ).ToList<SGKAutoExamination>();
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

        public static IList<DailyTellerReportRecord> GetDailyTellerReportData(string userName, DateTime startDate, DateTime endDate)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return session.GetNamedQuery("sp_GetDailyTellerReport")
                    .SetString("UserList", userName)
                    .SetDateTime("StartDate", startDate.Date)
                    .SetDateTime("EndDate", endDate.Date)
                    .List<DailyTellerReportRecord>();
            }

        }

        #region ID Generators
        public static string GetNewSystemSettingNo(string key, bool updateDB = true)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                string serialID = "";
                int serialNo = 0;

                /// TODO Add control for no element
                SystemSetting ss = (from systemSetting in session.Query<SystemSetting>()
                                    where systemSetting.ID0 == "00" && systemSetting.Code == key
                                    select systemSetting
                                    ).SingleOrDefault<SystemSetting>();

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
                if (updateDB)
                {
                    try
                    {
                        session.Update(ss);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

                return ss.Value;
            }
        }

        public static void UpdateSystemSettingNo(string key, string value)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                SystemSetting ss = (from systemSetting in session.Query<SystemSetting>()
                                    where systemSetting.ID0 == "00" && systemSetting.Code == key
                                    select systemSetting
                                    ).SingleOrDefault<SystemSetting>();
                ss.Value = value;
                if (String.IsNullOrEmpty(ss.Code))
                {
                    try
                    {
                        ss.ID0 = "00";
                        ss.Code = key;
                        session.Save(ss);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        session.Update(ss);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static float GetNewDoctorQueueNo(ISession asession, Doctor doctor)
        {
            Doctor d;
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                d = session.Get<Doctor>(doctor.Code);

                SystemSetting ss = (from systemSetting in session.Query<SystemSetting>()
                                    where systemSetting.ID0 == "00" && systemSetting.Code == "TARİH"
                                    select systemSetting
                                    ).SingleOrDefault<SystemSetting>();

                string today = DateTime.Now.ToString("dd/MM/yyyy");
                if (today != ss.Value)
                {
                    ss.Value = today;
                    d.QueueNo = 0;
                    session.Update(ss);
                }
                d.QueueNo += 1;
                session.Update(d);
                transaction.Commit();
            }
            return d.QueueNo;
        }

        public static string GetNewInvoiceNo(bool updateDB = true)
        {
            return GetNewSystemSettingNo("FATNO", updateDB);
        }
        public static string GetNewVoucherNo(bool updateDB = true)
        {
            return GetNewSystemSettingNo("MAKNO", updateDB);
        }
        public static string GetNewAdvancePaymentNo(bool updateDB = true)
        {
            return GetNewSystemSettingNo("AVANS_ID", updateDB);
        }
        public static string GetNewTellerInvoiceNo(User user, bool updateDB = true)
        {
            return GetNewSystemSettingNo("KELEGNUM" + user.VEZNE, updateDB);
        }
        public static void UpdateTellerInvoiceNo(User user, string value)
        {
            UpdateSystemSettingNo("KELEGNUM" + user.VEZNE, value);
        }
        public static string GetNewTellerVoucherNo(User user, bool updateDB = true)
        {
            return GetNewSystemSettingNo("MAKNUM" + user.VEZNE, updateDB);
        }
        public static void UpdateTellerVoucherNo(User user, string value)
        {
            UpdateSystemSettingNo("MAKNUM" + user.VEZNE, value);
        }

        #endregion

    }
}
