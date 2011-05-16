using System;
using System.Collections.Generic;
using System.Linq;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Naz.Hastane.Data.Entities.LookUp;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Hastane.Data.Entities.Accounting;
using Naz.Utilities.Classes;
using Naz.Hastane.Data.DTO;
using Naz.Hastane.Data.Entities.Logs;

namespace Naz.Hastane.Data.Services
{
    public static class PatientServices
    {
        public static bool IsValidTCID(string aTCID)
        {
            return IsValidNumeric(aTCID, 11);
        }

        public static bool IsValidPatientNo(string aPatientNo)
        {
            return IsValidNumeric(aPatientNo, 6);
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

        public static Patient GetPatientByID(string aPatientNo)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetPatientByID(aPatientNo, session);
        }
        public static Patient GetPatientByID(string aPatientNo, ISession session)
        {
            if (String.IsNullOrWhiteSpace(aPatientNo))
                return null;

            return session.Get<Patient>(aPatientNo);
        }

        public static IList<Patient> GetByTCId(string aTCID)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                IList<Patient> result = session
                    .CreateCriteria(typeof(Patient))
                    .Add(Restrictions.Eq("TCId", aTCID))
                    .List<Patient>();
                return result;
            }
        }

        public static IList<Patient> GetByWhere(string aWhere)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                return session.CreateQuery("From Patient as patient where " + aWhere)
                    .SetMaxResults(100)
                    .List<Patient>();
            }
        }

        public static void SavePatient(ISession session, Patient patient, User user)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                patient.USER_ID_UPDATE = user.USER_ID;
                patient.DATE_UPDATE = DateTime.Now;

                if (patient.PatientNo == null || patient.PatientNo == "")
                {
                    patient.PatientNo = GetNewPatientNo();
                    patient.USER_ID = user.USER_ID;
                    patient.DATE_CREATE = DateTime.Now;
                    session.Save(patient);
                }
                else
                {
                    session.Update(patient);
                }
                transaction.Commit();
            }
        }

        public static void SavePatientVisit(PatientVisit pv)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                if (pv.VisitNo == null || pv.VisitNo == "")
                {
                    pv.VisitNo = GetNewPatientNo();
                    session.Save(pv);
                }
                else
                {
                    session.Update(pv);
                }
                transaction.Commit();
            }
        }

        public static Patient CreateNewPatient()
        {
            Patient patient = DataBindingFactory.Create<Patient>();

            patient.FirstName = ""; //HASTAADI
            patient.LastName = ""; //HASTASOYADI
            patient.TCId = ""; //TCKIMLIKNO
            patient.FatherName = ""; //BABAADI
            patient.MotherName = ""; //ANAADI
            patient.Sex = "2"; //CINSIYETI 1:Male, 2:Female
            patient.MaritalStatus = "B"; //MEDENI B:Single, E:Married
            patient.BirthPlace = ""; //DOGUMYERI
            //patient.BirthDate = ""; //DOGUMTARIHI
            patient.Nationality = "TC"; //UYRUGU
            patient.RegisteredTown = ""; //NUFUSKAYITLIILCE
            patient.RegisteredCity = ""; //NUFUSKAYITLIIL

            patient.BloodType = 8; //KANGRUBU
            patient.CanBeBloodDonour = 'F'; //KANVEREBILIR
            patient.MedControl = 'F'; //ILACKONTROL
            patient.CV = ""; //OZGECMIS

            patient.HomeAddress = ""; //EV_ADRES
            patient.HomeDistrict = ""; //EV_MAHALLE
            patient.HomeTown = ""; //EV_ILCE
            patient.HomePostCode = ""; //EV_PK
            patient.HomeCity = ""; //EV_SEHIR
            patient.HomePhone1 = ""; //EV_TEL1
            patient.HomePhone2 = ""; //EV_TEL2

            patient.JobName = ""; //IS_ADI
            patient.JobAddress = ""; //IS_ADRESI
            patient.JobPostCode = ""; //IS_PK
            patient.JobCity = ""; //IS_SEHIR
            patient.JobPhone1 = ""; //IS_TEL1
            patient.JobPhone2 = ""; //IS_TEL2
            patient.JobFax = ""; //IS_FAX
            patient.JobNo = ""; //IS_YERINO

            patient.Email = ""; //EMAIL
            patient.Profession = ""; //MESLEK

            //patient.InsuranceCompany = ""; //PSG SGK: SGK
            patient.ProtocolNo = ""; //PROTNO
            patient.PatientContribution = 'F'; //HASTAKATILIM SGK 'T' !!! Yanlış
            patient.PatientLimit = 0.0; //HASTALIMIT
            patient.InsuranceType = ""; //SIGORTATURU SGK 1
            patient.TransferorInstitution = ""; //DEVREDILENKURUM
            patient.Officer = ""; //MEMUR
            patient.Relation = ""; //YAKINLIK Serbest Alan
            patient.Status = '1'; //DURUM  PatientRelation

            patient.SIGMUD = ""; //SIGMUD
            patient.SIGORTANO = ""; //SIGORTANO
            patient.SIGORTALIKARTNO = ""; //SIGORTALIKARTNO
            patient.EMSNO = ""; //EMSNO
            patient.BAGNO = ""; //BAGNO
            patient.BAGKARNENO = ""; //BAGKARNENO

            patient.IDType = '1'; //HUVIYETTIPI
            patient.IDNO = ""; //HUVIYETNO
            patient.IDDate = ""; //HUVIYETTARIHI
            patient.IDPlace = ""; //HUVIYETVYER

            patient.ArchiveID = null; //ARSIVNO
            patient.CriminalArchiveID = null; //ADLIARSIVNO

            patient.YKARTNO = ""; //YKARTNO
            patient.GELHAST = ""; //GELHAST
            patient.BORC = 0.0; //BORC
            patient.ALACAK = 0.0; //ALACAK

            patient.USER_ID = ""; //USER_ID
            //patient.DATE_CREATE = ""; //DATE_CREATE
            patient.USER_ID_UPDATE = ""; //USER_ID_UPDATE
            //patient.DATE_UPDATE = ""; //DATE_UPDATE

            return patient;
        }

        public static Patient GetNewSGKPatient(ISession session)
        {
            Patient patient = CreateNewPatient();
            patient.InsuranceCompany = LookUpServices.GetSGK(session);
            patient.PatientContribution = 'F';
            patient.InsuranceType = "1";
            patient.TransferorInstitution = "1";

            return patient;
        }

        /// <summary>
        /// SGK Poliklinik İşlemleri ekler
        /// </summary>
        /// <param name="session"></param>
        /// <param name="user"></param>
        /// <param name="patient"></param>
        /// <param name="doctor"></param>
        public static PatientVisit AddSGKPolyclinic(ISession session, User user, Patient patient, Doctor doctor, bool sameDay)
        {
            if (patient == null || doctor == null)
                return null;

            float doctorQueueNo = LookUpServices.GetNewDoctorQueueNo(session, doctor);

            PatientVisit pv = AddNewPatientVisit(session, user, patient, doctor, doctorQueueNo);

            PatientVisitRecord pvr = AddNewPatientVisitRecord(session, user, pv);

            if (sameDay)
                foreach (var sae in LookUpServices.GetSGKAutoExaminationSameDays(doctor.Service))
                {
                    if (IsAutoExamItemValid(patient, sae))
                    {
                        PatientVisitDetail pvd = AddNewPatientVisitDetail(session, user, patient, pv, sae.Product);
                    }
                }
            else
                foreach (var sae in LookUpServices.GetSGKAutoExaminations(doctor.Service))
                {
                    if (IsAutoExamItemValid(patient, sae))
                    {
                        PatientVisitDetail pvd = AddNewPatientVisitDetail(session, user, patient, pv, sae.Product);
                    }
                }

            UpdatePatientVisitFromDetails(session, user, pv);

            return pv;
        }

        public static bool IsSGKSameDay(Patient patient)
        {
            return ((patient.InsuranceCompany.IsSGK() || patient.InsuranceCompany.IsSGKAcil()) && 
                patient.PatientVisits.Count >= 1 && 
                patient.PatientVisits[0].VisitDate.Date == DateTime.Today);
        }

        public static bool IsAutoExamItemValid(Patient patient, SGKAutoExaminationBase sae)
        {
            if (patient.InsuranceCompany.IsSGK())
            {
                if (sae.Contribution == PatientContributionValues.NoContribution.GetDescription())
                // SGKKATILIM olmayan maddelerde Medula'ya gönderilecekleri seç
                    return (sae.Product.MEDGONDER == "1");
                else
                    // SGKKATILIM olanda "Çalışan"lar için katılım ekle seç
                    return (patient.InsuranceType == InsuranceTypeValues.Worker.GetDescription());
            }
            else
            {
                if (sae.Contribution == PatientContributionValues.NoContribution.GetDescription())
                    return (sae.Product.MEDGONDER == "0");
                else
                    return false;
            }
        }

        public static PatientVisit AddNewPatientVisit(ISession session, User user, Patient patient, Doctor doctor, float queueNo)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                patient.InsuranceCompany.SIRAID += 1;
                session.Save(patient.InsuranceCompany);

                PatientVisit pv = new PatientVisit();
                pv.VisitNo = GetNewPatientVisitNo(session, patient);
                pv.VisitDate = DateTime.Now.Date;
                pv.TransferValidityPeriod = (short)patient.InsuranceCompany.SEVKGECSURE;
                pv.Doctor = doctor;
                pv.Servis = doctor.Service.Code;
                pv.QueueNo = String.Format("{0:00000}",queueNo);
                pv.VisitType = PatientCardType.Polyclinic.GetDescription();
                pv.SIRAID = patient.InsuranceCompany.SIRAID;
                pv.HZLNO = 1; /// TODO HZLNO nerede artıyor?
                pv.ProvisionNo = "";
                pv.USER_ID = user.USER_ID;
                pv.SupportInsCompany = "";
                pv.DATE_CREATE = DateTime.Now;
                pv.PSG = patient.InsuranceCompany.Code;
                pv.ExitTime = "";
                pv.SEVKTAKIPNO = "";
                pv.TAKIPSEND = "9";
                pv.TABKODU = "02";
                pv.Status = '1';

                patient.AddPatientVisit(pv);
                session.Save(pv);
                transaction.Commit();
                return pv;
            }
        }
        public static PatientVisitRecord AddNewPatientVisitRecord(ISession session, User user, PatientVisit pv)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                PatientVisitRecord pvr = new PatientVisitRecord();

                pvr.PatientVisit = pv;
                pvr.VisitDate = DateTime.Now;
                pvr.Doctor = pv.Doctor;
                pvr.Servis = pv.Servis;
                pvr.QueueNo = pv.QueueNo;
                pvr.VisitType = pv.VisitType;
                pvr.USER_ID = user.USER_ID;
                pvr.DATE_CREATE = DateTime.Now;

                pvr.MUAYENEOLDU = "F";
                pvr.PSG = pv.PSG;
                pvr.ISTISNAIDURUM = "0";
                pvr.EKSORGU = "H";

                pv.AddPatientVisitRecord(pvr);
                session.Save(pvr);
                transaction.Commit();
                return pvr;
            }

        }
        public static PatientVisitDetail AddNewPatientVisitDetail(ISession session, User user, Patient patient, PatientVisit pv, Product product)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                PatientVisitDetail pvd = GetNewPatientVisitDetailFromProduct(pv, product);

                pvd.PatientVisit  = pv;
                pvd.DetailNo      = GetNewPatientVisitDetailNo(session, pv);
                pvd.PatientPrice        = product.GetPatientPrice(patient.InsuranceCompany.YFIYLIST);
                pvd.CompanyPrice       = product.GetCompanyPrice(patient.InsuranceCompany.YFIYLIST);
                pvd.USER_ID       = user.USER_ID;
                pvd.DATE_CREATE   = DateTime.Now;

                pv.AddPatientVisitDetail(pvd);
                session.Save(pvd);
                transaction.Commit();
                return pvd;
            }

        }

        public static void AddPatientVisitDetails(ISession session, User user, Patient patient, PatientVisit pv, IList<PatientVisitDetail> pvds)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (PatientVisitDetail pvd in pvds)
                {
                    pvd.PatientVisit = pv;
                    pvd.DetailNo = GetNewPatientVisitDetailNo(session, pv);
                    pvd.USER_ID = user.USER_ID;
                    pvd.DATE_CREATE = DateTime.Now;

                    pv.AddPatientVisitDetail(pvd);
                    session.Save(pvd);
                }
                transaction.Commit();
                UpdatePatientVisitFromDetails(session, user, pv);
                return;
            }

        }
        public static PatientVisitDetail GetNewPatientVisitDetailFromProduct(PatientVisit pv, Product product)
        {
            PatientVisitDetail pvd = new PatientVisitDetail();

            pvd.TARIH = DateTime.Now;
            pvd.TANIM = product.TANIM;
            pvd.GRUP = product.GRUP;
            pvd.CODE = product.CODE;
            pvd.NAME1 = product.NAME1;
            pvd.KDV = product.KDV;
            pvd.ADET = 1;
            pvd.PatientPrice = product.PatientPrice;
            pvd.CompanyPrice = product.CompanyPrice;
            pvd.PSG = pv.PSG;
            pvd.Doctor = pv.Doctor;
            pvd.Doctor2 = pv.Doctor;
            pvd.HZLNO = pv.HZLNO;
            pvd.DATE_CREATE = DateTime.Now;
            pvd.FATURAEDILSIN = "E";
            pvd.KABUL = "0";
            pvd.ISDURUM = "0";
            pvd.HODENDI = "0";
            pvd.HYATISTARIHI = pvd.DATE_CREATE;
            pvd.HCIKISTARIHI = pvd.DATE_CREATE;
            pvd.MEDSIRANO = "";
            pvd.MEDONAY = "0";
            pvd.TG = 1;
            pvd.MEDANOMALI = "0";

            return pvd;
        }

        public static void UpdatePatientVisitFromDetails(ISession session, User user, PatientVisit pv)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                UpdatePatientVisitFromDetails(user, pv);

                session.Update(pv);
                transaction.Commit();
            }

        }
        public static void UpdatePatientVisitFromDetails(User user, PatientVisit pv)
        {
            double patientTotal = 0;
            double companyTotal = 0;

            foreach (PatientVisitDetail pvd in pv.PatientVisitDetails)
            {
                patientTotal += pvd.ADET * pvd.PatientPrice;
                companyTotal += pvd.ADET * pvd.CompanyPrice;
            }
            pv.PatientTotal = patientTotal;
            pv.InsuranceTotal = companyTotal;
            pv.USER_ID_UPDATE = user.USER_ID;
            pv.DATE_UPDATE = DateTime.Now;

        }

        public static bool DeletePatientVisit(ISession session, User user, PatientVisit pv)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                pv.Patient.RemovePatientVisit(pv);
                foreach (PatientVisitDetail pvd in pv.PatientVisitDetails)
                    session.Delete(pvd);
                foreach (PatientVisitRecord pvr in pv.PatientVisitRecords)
                    session.Delete(pvr);

                session.Delete(pv);
                transaction.Commit();
                return true;
            }
        }
        public static bool DeletePatientVisitDetail(ISession session, User user, PatientVisitDetail pvd)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                pvd.PatientVisit.RemovePatientVisitDetail(pvd);
                session.Delete(pvd);
                transaction.Commit();
            }

            UpdatePatientVisitFromDetails(session, user, pvd.PatientVisit);

            return true;
        }

        public static void UpdatePatientRecordsFromMedula(ISession session, User user, Patient patient, PatientVisit pv, MedulaProvisionResult mpr)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                patient.InsuranceType         = mpr.SigortaliTuru;
                patient.TransferorInstitution = mpr.TransferorInstitution;
                patient.USER_ID_UPDATE        = user.USER_ID;
                patient.DATE_UPDATE           = DateTime.Now;

                session.Update(patient);
                transaction.Commit();
            }
            UpdatePatientVisitWithMedulaProvision(session, user, pv, mpr);
            UpdatePatientVisitRecordWithMedulaProvision(session, user, pv.PatientVisitRecords[0], mpr);
        }

        public static void UpdatePatientVisitWithMedulaProvision(ISession session, User user, PatientVisit pv, MedulaProvisionResult mpr)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                pv.TAKIPNO           = mpr.TakipNo;
                pv.HASTABASNO        = mpr.HastaBasvuruNo;
                pv.RelatedFollowUpNo = mpr.RelatedFollowUpNo;
                pv.TreatmentStyle    = mpr.TreatmentStyle;
                pv.ProvisionType     = mpr.ProvisionType;
                pv.USER_ID_UPDATE    = user.USER_ID;
                pv.DATE_UPDATE       = DateTime.Now;

                session.Update(pv);
                transaction.Commit();
            }
        }
        public static void UpdatePatientVisitRecordWithMedulaProvision(ISession session, User user, PatientVisitRecord pvr, MedulaProvisionResult mpr)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                pvr.BranchCode        = mpr.BranchCode;
                pvr.HASTABASNO        = mpr.HastaBasvuruNo;
                pvr.RelatedFollowUpNo = mpr.RelatedFollowUpNo;
                pvr.TreatmentType     = mpr.TreatmentType;
                pvr.FollowUpType      = mpr.FollowUpType;
                pvr.TreatmentStyle    = mpr.TreatmentStyle;
                pvr.SEVKTAKIPNO       = mpr.TakipNo;
                pvr.ProvisionType     = mpr.ProvisionType;
                pvr.USER_ID_UPDATE    = user.USER_ID;
                pvr.DATE_UPDATE       = DateTime.Now;

                session.Update(pvr);
                transaction.Commit();
            }
        }

        public static bool UpdatePatientVisitWithMedulaProvisionDelete(ISession session, User user, Patient patient, string takipNo)
        {
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (PatientVisit pv in patient.PatientVisits)
                    if (pv.TAKIPNO == takipNo)
                    {
                        pv.TAKIPNO = "";
                        pv.HASTABASNO = "";
                        pv.RelatedFollowUpNo = "";
                        pv.TreatmentStyle = "";
                        pv.ProvisionType = "";

                        pv.USER_ID_UPDATE = user.USER_ID;
                        pv.DATE_UPDATE = DateTime.Now;

                        session.Update(pv);
                        transaction.Commit();
                        return true;
                    }
            }
            return false;
        }

        #region New Key Generators
        public static string GetNewPatientNo()
        {
            return LookUpServices.GetNewSystemSettingNo("KNR");
            //using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            //using (ITransaction transaction = session.BeginTransaction())
            //{
            //    SystemSetting ss = session
            //        .CreateCriteria(typeof(SystemSetting))
            //        .Add(Restrictions.Eq("ID0", "00"))
            //        .Add(Restrictions.Eq("ID", "KNR"))
            //        .UniqueResult<SystemSetting>();
            //    int id = Convert.ToInt32(ss.Value);
            //    id += 1;
            //    ss.Value = id.ToString();
            //    session.Update(ss);
            //    transaction.Commit();
            //    return ss.Value;
            //}
        }

        public static string GetNewPatientVisitNo(Patient patient)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetNewPatientVisitNo(session, patient);
        }
        public static string GetNewPatientVisitNo(ISession session, Patient patient)
        {
            string a = (from patientVisit in session.Query<PatientVisit>()
                        where patientVisit.Patient == patient
                        select patientVisit.VisitNo).Min();

            int newNo = 1000;

            if (a != null)
                newNo = int.Parse(a);

            newNo--;

            return newNo.ToString("D3");
        }

        public static double GetNewPatientVisitDetailNo(PatientVisit pv)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetNewPatientVisitDetailNo(session, pv);
        }
        public static double GetNewPatientVisitDetailNo(ISession session, PatientVisit pv)
        {
            double? a = session.QueryOver<PatientVisitDetail>()
                .Where(x => x.PatientVisit == pv)
                .Select(
                    Projections
                        .ProjectionList()
                        .Add(Projections.Max<PatientVisitDetail>(x => x.DetailNo)))
                .List<double?>().First();

            return a.GetValueOrDefault() + 1;
        }
        #endregion

        #region Invoice
        public static IList<Patient> GetPatientsForInvoice(ISession session)
        {
            IList<Patient> result = (from p in session.Query<Patient>()
                            join pv in session.Query<PatientVisit>() on p equals pv.Patient
                            join pvd in session.Query<PatientVisitDetail>() on pv equals pvd.PatientVisit
                            where  pvd.MAKNO == null && pvd.AMAKNO == null
                            && pvd.ADET != 0
                            && pvd.PatientPrice != 0
                            && pvd.TARIH >= new DateTime(2011, 3, 1)
                            orderby p.FirstName ascending, p.LastName ascending
                            select p
                            )
                .Distinct<Patient>().ToList<Patient>();
            return result;
        }

        public static IList<object> GetPatientVisitsForInvoice(ISession session)
        {
            Patient patient = null;
            PatientVisit pv = null;
            PatientVisitDetail pvd = null;

            var result = session.QueryOver<Patient>(() => patient)
                .JoinQueryOver<PatientVisit>(x => x.PatientVisits, () => pv)
                .JoinQueryOver<PatientVisitDetail>(() => pv.PatientVisitDetails, () => pvd)
                    .Where(d => d.MAKNO == null)
                    .And(d => d.AMAKNO == null)
                    .And(d => d.ADET != 0)
                    .And(d => d.PatientPrice != 0)
                    .And(d => d.TARIH >= new DateTime(2011, 3, 1))
                //.Select(Projections.ProjectionList()
                //.Add(Projections.Property(() => patient.FirstName), "First Name")
                //.Add(Projections.Property(() => patient.LastName), "LastName")
                //.Add(Projections.Property(() => pv.VisitNo), "VisitNo")
                //.Add(Projections.Property(() => pv.VisitDate), "VisitDate")
                //.Add(Projections.Property(() => pv.ExitDate), "ExitDate")
                //.Add(Projections.Property(() => pv.PatientTotal), "PatientTotal"))
                .SelectList(list => list
                    .Select(() => patient.FirstName)
                    .Select(() => patient.LastName)
                    .Select(() => pv.VisitNo)
                    .Select(() => pv.VisitDate)
                    .Select(() => pv.ExitDate)
                    .Select(() => pv.PatientTotal))
                .List<object[]>()
                .Select(properties => new
                {
                    FirstName = (string)properties[0],
                    LastName = (string)properties[1],
                    VisitNo = (string)properties[2],
                    VisitDate = (DateTime?)properties[3],
                    ExitDate = (DateTime?)properties[4],
                    PatientTotal = (double)properties[5]
                })
                .Distinct()
                .ToList<object>();
            return result;
        }
        public static IList<PatientVisit> GetPatientVisitsForInvoice(ISession session, Patient patient)
        {
            IList<PatientVisit> result;
            if (patient == null)
                result = new List<PatientVisit>();
            else
                result = (from pv in session.Query<PatientVisit>()
                    join pvd in session.Query<PatientVisitDetail>() on pv equals pvd.PatientVisit
                    where pv.Patient == patient 
                    && pvd.MAKNO == null && pvd.AMAKNO == null
                    && pvd.ADET != 0 && pvd.PatientPrice != 0
                    orderby pv.VisitNo descending
                    select pv
                    )
                    .Distinct<PatientVisit>()
                    .ToList<PatientVisit>();
            return result;
        }

        public static IList<PatientVisitDetail> GetPatientVisitDetailsForInvoice(ISession session, IList<PatientVisit> pvs)
        {
            if (pvs.Count == 0)
                return new List<PatientVisitDetail>();

            IList<string> pvIDs = (from pv in pvs
                                    select pv.VisitNo)
                                    .ToList<string>();


            IList<PatientVisitDetail> result = (from pvd in session.Query<PatientVisitDetail>()
                                                where
                                                    pvd.PatientVisit.Patient == pvs[0].Patient
                                                    && pvIDs.Contains(pvd.PatientVisit.VisitNo)
                                                    && pvd.MAKNO == null && pvd.AMAKNO == null
                                                    && pvd.ADET != 0 && pvd.PatientPrice != 0
                                                join pv in session.Query<PatientVisit>() on pvd.PatientVisit equals pv
                                                //orderby pvd.PatientVisit.VisitNo descending, pvd.DetailNo ascending
                                                select pvd
                                                )
                                                .Distinct<PatientVisitDetail>()
                                                .ToList<PatientVisitDetail>();
            return result;
        }

        public static IList<AdvancePayment> GetPatientAdvancePaymentsForInvoice(ISession session, Patient patient)
        {
            IList<AdvancePayment> result;
            if (patient == null)
                result = new List<AdvancePayment>();
            else
                result = (from ap in session.Query<AdvancePayment>()
                          where ap.PatientVisit.Patient == patient
                              && ap.TUTAR - (ap.KULLANILAN + ap.IADEEDILEN) > 0
                          orderby ap.TARIH ascending
                          select ap
                )
                .ToList<AdvancePayment>();

            return result;
        }

        public static void AddNewInvoice(ISession session, User user, Patient patient, IList<PatientVisitDetail> pvds, 
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, double advancePaymentUsed, string tellerInvoiceNo)
        {
            if (pvds.Count == 0)
                return;

            //using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    string newInvoiceNo = LookUpServices.GetNewInvoiceNo();

                    UpdateAdvancePaymentRecords(session, user, patient, advancePaymentUsed);

                    InsertNewAdvancePaymentForInvoice(session, user,
                        pvds[0].PatientVisit, paymentType, POSType, cashPayment,
                        tellerInvoiceNo, newInvoiceNo);

                    InsertNewInvoice(session, user, patient,
                        pvds, paymentType, POSType,
                        productTotal, VATTotal, invoiceTotal, discountTotal, VATPercent, cashPayment,
                        tellerInvoiceNo, newInvoiceNo);
                    transaction.Commit();

                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Verilen avansı sırasıyla avans kayıtlarından düşer
        /// <remarks>Test Edilecek</remarks>
        /// </summary>
        /// <param name="session"></param>
        /// <param name="transaction"></param>
        /// <param name="user"></param>
        /// <param name="patient"></param>
        /// <param name="advancePaymentUsed"></param>
        public static void UpdateAdvancePaymentRecords(ISession session, User user, Patient patient, 
            double advancePaymentUsed)
        {
            if (advancePaymentUsed == 0)
                return;

            double remainingAdvancePayment = advancePaymentUsed;

            IList<AdvancePayment> aps = GetPatientAdvancePaymentsForInvoice(session, patient);
            for (int i = 0; i < aps.Count && remainingAdvancePayment > 0; i++)
            {
                AdvancePayment ap        = aps[i];
                double usedPayment       = Math.Min(remainingAdvancePayment, ap.RemainingAmount);
                ap.KULLANILAN           += usedPayment;
                ap.DATE_UPDATE           = DateTime.Now;
                remainingAdvancePayment -= usedPayment;
                session.Update(ap);

                AdvancePaymentUsed apu = new AdvancePaymentUsed();
                apu.AdvancePayment     = ap;
                apu.TARIH              = DateTime.Today;
                apu.TUTAR              = usedPayment;
                apu.USER_ID            = user.USER_ID;
                apu.DATE_CREATE        = DateTime.Today;
                session.Save(apu);
            }
        }

        public static void InsertNewAdvancePaymentForInvoice(ISession session, User user, 
            PatientVisit pv,
            string paymentType, string POSType, 
            double cashPayment, string tellerInvoiceNo, string invoiceNo)
        {
            CashDeskRecord cdr = AddNewCashDeskRecord(session, user, pv,
                "F-" + tellerInvoiceNo, invoiceNo, "A", paymentType, POSType, cashPayment);

            string apNo = LookUpServices.GetNewAdvancePaymentNo();

            AdvancePayment ap = new AdvancePayment();
            ap.AV_ID          = Convert.ToDouble(apNo);
            ap.PatientVisit   = pv;
            ap.TARIH          = DateTime.Today;
            ap.TUTAR          = cashPayment;
            ap.KULLANILAN     = cashPayment;
            ap.ODEMESEKLI     = paymentType;
            ap.POSNO          = POSType;
            ap.MAKNO          = cdr.MAKNO;
            ap.HESAPKODU      = null;
            ap.ALTHESAPKODU   = null;
            ap.USER_ID        = user.USER_ID;
            ap.DATE_CREATE    = DateTime.Now;

            session.Save(ap);

            AdvancePaymentUsed apu = new AdvancePaymentUsed();
            apu.AdvancePayment     = ap;
            apu.TARIH              = DateTime.Today;
            apu.FATURANO           = invoiceNo;
            apu.TUTAR              = cashPayment;
            apu.USER_ID            = user.USER_ID;
            apu.DATE_CREATE        = DateTime.Now;

            session.Save(apu);
        }

        public static CashDeskRecord AddNewCashDeskRecord(ISession session, User user,
            PatientVisit pv, string tellerVoucherNo, string invoiceNo, string voucherType, string paymentType, string POSType, double payment)
        {
            string makNo = LookUpServices.GetNewVoucherNo();

            CashDeskRecord cdr = new CashDeskRecord();
            cdr.MAKNO          = makNo;
            cdr.KNR            = pv.Patient.PatientNo;
            cdr.SNR            = pv.VisitNo;
            cdr.TARIH          = DateTime.Today;
            cdr.MAKBUZNO       = tellerVoucherNo;
            cdr.MAKBUZTIPI     = voucherType;
            cdr.ODEMESEKLI     = paymentType[0];
            cdr.POSNO          = POSType;
            cdr.TUTAR          = payment;
            cdr.BORCALACAK     = 'B';
            cdr.FATURANO       = invoiceNo;
            cdr.VEZNE          = user.VEZNE;
            cdr.HESAPKODU      = null;
            cdr.ALTHESAPKODU   = null;
            cdr.USER_ID        = user.USER_ID;
            cdr.DATE_CREATE    = DateTime.Now;

            session.Save(cdr);

            return cdr;
        }

        public static void InsertNewInvoice(ISession session, User user,
            Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, string tellerInvoiceNo, string invoiceNo)
        {
            string makNo = LookUpServices.GetNewVoucherNo();

            Invoice invoice      = new Invoice();
            invoice.KNR          = patient.PatientNo;
            invoice.FATURA_ID    = invoiceNo;
            invoice.SLNR         = tellerInvoiceNo;
            invoice.FATURANO     = tellerInvoiceNo;
            invoice.FATURATARIHI = DateTime.Now;
            invoice.HIZMETTUTARI = productTotal;
            invoice.INDIRIM      = discountTotal;
            invoice.KDVTUTARI    = VATTotal;
            invoice.YUVARLAMA    = 0;
            invoice.FATURATUTARI = invoiceTotal;
            invoice.KDVORANI     = VATPercent.ToString();
            invoice.NAME         = patient.FullName;
            invoice.FATURATIPI   = "H";
            invoice.FAK          = "K";
            invoice.ZHLKZ        = "N";
            invoice.PSG          = "";
            invoice.ISODENDI     = "1";
            invoice.MAKNO        = makNo;
            invoice.VEZNE        = user.VEZNE;
            invoice.USER_ID      = user.USER_ID;
            invoice.DATE_CREATE  = DateTime.Now;

            session.Save(invoice);

            UpdatePatientVisitDetails(session, user, pvds, makNo);

            LookUpServices.UpdateTellerInvoiceNo(user, tellerInvoiceNo);
        }

        public static void UpdatePatientVisitDetails(ISession session, User user, IList<PatientVisitDetail> pvds, string voucherNo)
        {
            foreach (PatientVisitDetail pvd in pvds)
            {
                pvd.MAKNO = voucherNo;
                pvd.USER_ID_UPDATE = user.USER_ID;
                pvd.DATE_UPDATE = DateTime.Now;
                session.Update(pvd);
            }

        }

        public static void InsertDoctorInvoice(ISession session, ITransaction transaction, User user,
            Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, string tellerInvoiceNo, string invoiceNo)
        {
            foreach (PatientVisitDetail pvd in pvds)
            {
                if (pvd.TANIM != "09" && pvd.TANIM != "16")
                {
                    DoctorProductPercent dpp1 = (from dpp in session.Query<DoctorProductPercent>()
                                                 //join doctor in session.Query<Doctor>() on dpp.ARZT equals doctor.Code
                                                 where
                                                        dpp.TANIM == pvd.TANIM &&
                                                        dpp.GRUP == pvd.GRUP &&
                                                        dpp.CODE == pvd.CODE &&
                                                        dpp.ARZT == pvd.Doctor2.Code
                                                 select dpp)
                                                 .FirstOrDefault();

                }
            }
        }
        #endregion

        public static void AddNewVoucher(ISession session, User user, IList<PatientVisitDetail> pvds,
        string paymentType, string POSType,
        double cashPayment, string tellerVoucherNo)
        {
            if (pvds.Count == 0)
                return;

            //using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    CashDeskRecord cdr = AddNewCashDeskRecord(session, user,
                        pv: pvds[0].PatientVisit,
                        tellerVoucherNo: tellerVoucherNo,
                        invoiceNo: "",
                        voucherType: "V",
                        paymentType: paymentType,
                        POSType: POSType,
                        payment: cashPayment);

                    UpdatePatientVisitDetails(session, user, pvds, cdr.MAKNO);

                    LookUpServices.UpdateTellerVoucherNo(user, tellerVoucherNo);
                    transaction.Commit();

                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static IList<PatientVisit> GetPatientVisitsForInsuranceCompanyChange(ISession session, Patient patient)
        {
            IList<PatientVisit> result = (from pv in session.Query<PatientVisit>()
                                     where pv.Patient == patient
                                        && pv.IMPF2 == null && pv.ExitDate == null && pv.TAKIPSEND == "9"
                                     orderby pv.VisitNo descending
                                     select pv
                                    )
                                    .ToList<PatientVisit>();
            return result;
        }

        public static IList<PatientVisitDetailWithProduct> GetPatientVisitDetailsForInsuranceCompanyChange(ISession session, IList<PatientVisit> pvs, string priceListCode)
        {
            IList<PatientVisitDetailWithProduct> pvdwps = new List<PatientVisitDetailWithProduct>();
            if (pvs.Count == 0)
                return pvdwps;

            IList<PatientVisitDetail> pvds = new List<PatientVisitDetail>();
            foreach(PatientVisit pv in pvs)
                foreach(PatientVisitDetail pvd in pv.PatientVisitDetails)
                {
                    pvdwps.Add(new PatientVisitDetailWithProduct
                    {
                        PatientVisitDetail = pvd,
                        Product = LookUpServices.GetProduct(session, pvd.TANIM, pvd.GRUP, pvd.CODE, priceListCode),
                        Discount = 0
                    });
                }

            return pvdwps;
        }

        public static void ChangeInsuranceCompany(ISession session, User user, Patient patient, IList<PatientVisit> pvs, IList<PatientVisitDetailWithProduct>  pvdwps, InsuranceCompany insuranceCompany)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    LOGKURUM_DEGISTI log = new LOGKURUM_DEGISTI();
                    log.KD_ID = Convert.ToDecimal(LookUpServices.GetNewLOGKURUM_DEGISTINo(user));
                    log.KNR = patient.PatientNo;
                    log.TARIH = DateTime.Now;
                    log.EPSG = patient.InsuranceCompany.Code;
                    log.YPSG = insuranceCompany.Code;
                    log.OHASTATOP = 0; //??

                    patient.InsuranceCompany = insuranceCompany;
                    patient.USER_ID_UPDATE = user.USER_ID;
                    patient.DATE_UPDATE = DateTime.Now;
                    session.Update(patient);

                    foreach (PatientVisit pv in pvs)
                    {
                        pv.PSG = insuranceCompany.Code;
                        pv.USER_ID_UPDATE = user.USER_ID;
                        pv.DATE_UPDATE = DateTime.Now;
                        session.Update(pv);
                        foreach (PatientVisitRecord pvr in pv.PatientVisitRecords)
                        {
                            pvr.PSG = pv.PSG;
                            session.Update(pvr);
                        }
                    }
                    foreach (PatientVisitDetailWithProduct pvdwp in pvdwps)
                    {
                        pvdwp.PatientVisitDetail.PatientPrice = pvdwp.Product.PatientPrice;
                        pvdwp.PatientVisitDetail.CompanyPrice = pvdwp.Product.CompanyPrice;
                        pvdwp.PatientVisitDetail.PSG = insuranceCompany.Code;
                        session.Update(pvdwp.PatientVisitDetail);
                    }
                    foreach (PatientVisit pv in pvs)
                    {
                        log.EHASTATOP += pv.PatientTotal;
                        log.EKURUMTOP += pv.InsuranceTotal;

                        UpdatePatientVisitFromDetails(user, pv);

                        log.YHASTATOP += pv.PatientTotal;
                        log.YKURUMTOP += pv.InsuranceTotal;

                        session.Update(pv);
                    }

                    log.USER_ID = user.USER_ID;
                    log.DATE_CREATE = DateTime.Now;
                    session.Save(log);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

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
