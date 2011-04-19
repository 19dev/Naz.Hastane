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

namespace Naz.Hastane.Data.Services
{
    public static class PatientServices
    {
        public static Patient GetPatientByID(string aPatientNo)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetPatientByID(aPatientNo, session);
        }
        public static Patient GetPatientByID(string aPatientNo, ISession session)
        {
            return session.Get<Patient>(aPatientNo);
        }

        public static Patient GetByTCId(string aTCID)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                Patient patient = session
                    .CreateCriteria(typeof(Patient))
                    .Add(Restrictions.Eq("TCId", aTCID))
                    .UniqueResult<Patient>();
                return patient;
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

        public static void SavePatient(ISession session, Patient patient)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                if (patient.PatientNo == null || patient.PatientNo == "")
                {
                    patient.PatientNo = GetNewPatientNo();
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

        public static Patient GetNewPatient()
        {
            Patient patient = new Patient();

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
            patient.PatientContribution = 'F'; //HASTAKATILIM SGK 'T'
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

            patient.ArchiveID = ""; //ARSIVNO
            patient.CriminalArchiveID = ""; //ADLIARSIVNO

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
            Patient patient = GetNewPatient();
            patient.InsuranceCompany = LookUpServices.GetSGK(session);
            patient.PatientContribution = 'T';
            patient.InsuranceType = "1";
            patient.TransferorInstitution = "1";

            return patient;
        }

        public static void AddSGKPolyclinic(ISession session, User user, Patient patient, Doctor doctor)
        {
            if (patient == null || doctor == null)
                return;

            //using (ITransaction transaction = session.BeginTransaction())
            //{
                float doctorQueueNo = LookUpServices.GetNewDoctorQueueNo(session, doctor);

                PatientVisit pv = AddNewPatientVisit(session, user, patient, doctor);

                PatientVisitRecord pvr = AddNewPatientVisitRecord(session, user, pv);

                foreach (SGKAutoExamination sae in doctor.Service.SGKAutoExaminations)
                {
                    if (IsAutoExamItemValid(patient, sae))
                    {
                        PatientVisitDetail pvd = AddNewPatientVisitDetail(session, user, patient, pv, sae.Product);
                    }
                }
                //transaction.Commit();
            //}

        }

        public static bool IsAutoExamItemValid(Patient patient, SGKAutoExamination sae)
        {
            if (sae.Contribution == PatientContributionValues.NoContribution.GetDescription())
                return true;
            else
                return (patient.InsuranceType == InsuranceTypeValues.Worker.GetDescription());
        }

        public static PatientVisit AddNewPatientVisit(ISession asession, User user, Patient patient, Doctor doctor)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                patient.InsuranceCompany.SIRAID += 1;
                asession.Save(patient.InsuranceCompany);

                PatientVisit pv = new PatientVisit();
                pv.VisitNo = GetNewPatientVisitNo(session, patient);
                pv.VisitDate = DateTime.Now.Date;
                pv.TransferValidityPeriod = (short)patient.InsuranceCompany.SEVKGECSURE;
                pv.Doctor = doctor.Code;
                pv.Servis = doctor.Service.Code;
                pv.QueueNo = doctor.QueueNo.ToString("f0");
                pv.VisitType = PatientCardType.Polyclinic.GetDescription();
                pv.SIRAID = patient.InsuranceCompany.SIRAID;
                pv.HZLNO = 1; /// TODO HZLNO nerede artıyor?
                pv.ProvisionNo = "";
                pv.USER_ID = user.USER_ID;
                pv.SupportInsCompany = "";
                pv.PSG = patient.InsuranceCompany.Name;
                pv.DATE_CREATE = DateTime.Now;
                pv.ExitTime = "";
                pv.SEVKTAKIPNO = "";

                patient.AddPatientVisit(pv);
                session.Save(pv);
                transaction.Commit();
                return pv;
            }
        }
        public static PatientVisitRecord AddNewPatientVisitRecord(ISession asession, User user, PatientVisit pv)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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

                pvr.MUAYENEOLDU = "";

                pv.AddPatientVisitRecord(pvr);
                session.Save(pvr);
                transaction.Commit();
                return pvr;
            }

        }
        public static PatientVisitDetail AddNewPatientVisitDetail(ISession asession, User user, Patient patient, PatientVisit pv, Product product)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                PatientVisitDetail pvd = new PatientVisitDetail();

                pvd.PatientVisit = pv;
                pvd.DetailNo = GetNewPatientVisitDetailNo(session, pv);

                pvd.TARIH = DateTime.Now;

                pvd.TANIM = product.TANIM;
                pvd.GRUP = product.GRUP;
                pvd.CODE = product.CODE;
                pvd.NAME1 = product.NAME1;

                pvd.KDV = 0;
                pvd.ADET = 1;
                string price = Utilities.GetMemberValueByName(product, "SATISF" + patient.InsuranceCompany.YFIYLIST);
                pvd.SATISF = Convert.ToDouble(price);
                string kprice = Utilities.GetMemberValueByName(product, "KSATISF" + patient.InsuranceCompany.YFIYLIST);
                pvd.KSATISF = Convert.ToDouble(kprice);
                pvd.PSG = pv.PSG;
                pvd.Doctor = pv.Doctor;
                pvd.Doctor2 = pv.Doctor;
                pvd.HZLNO = 0;

                pvd.USER_ID = user.USER_ID;
                pvd.DATE_CREATE = DateTime.Now;

                pvd.MEDANOMALI = "0";

                pv.AddPatientVisitDetail(pvd);
                session.Save(pvd);
                transaction.Commit();
                return pvd;
            }

        }

        public static void UpdatePatientRecordsFromMedula(ISession session, User user, Patient patient, MedulaProvisionResult mpr)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                patient.InsuranceType = mpr.SigortaliTuru;
                patient.TransferorInstitution = mpr.TransferorInstitution;
                session.Update(patient);
                transaction.Commit();
            }
            UpdatePatientVisitWithMedulaProvision(session, user, patient.PatientVisits[0], mpr);
            UpdatePatientVisitRecordWithMedulaProvision(session, user, patient.PatientVisits[0].PatientVisitRecords[0], mpr);
        }

        public static void UpdatePatientVisitWithMedulaProvision(ISession asession, User user, PatientVisit pv, MedulaProvisionResult mpr)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                pv.TAKIPNO = mpr.TakipNo;
                pv.HASTABASNO = mpr.HastaBasvuruNo;
                pv.ILISKILITAKIPNO = mpr.RelatedFollowUpNo;
                pv.TEDAVITURU = mpr.TreatmentStyle;
                pv.TAKIPTURU = mpr.ProvisionType;

                session.Update(pv);
                transaction.Commit();
            }
        }
        public static void UpdatePatientVisitRecordWithMedulaProvision(ISession asession, User user, PatientVisitRecord pvr, MedulaProvisionResult mpr)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                pvr.BRANSKODU = mpr.BranchCode;
                pvr.HASTABASNO = mpr.HastaBasvuruNo;
                pvr.ILISKILITAKIPNO = mpr.RelatedFollowUpNo;
                pvr.TEDAVITIPI = mpr.TreatmentType;
                pvr.TAKIPTIPI = mpr.FollowUpType;
                pvr.TEDAVITURU = mpr.TreatmentStyle;
                pvr.SEVKTAKIPNO = mpr.TakipNo;
                pvr.TAKIPTURU = mpr.ProvisionType;

                session.Update(pvr);
                transaction.Commit();
            }
        }

        #region New Key Generators
        public static string GetNewPatientNo()
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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
                            && pvd.SATISF != 0
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
                    .And(d => d.SATISF != 0)
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
                    && pvd.ADET != 0 && pvd.SATISF != 0
                    orderby pv.VisitNo descending
                    select pv
                    )
                    .Distinct<PatientVisit>()
                    .ToList<PatientVisit>();
            return result;
        }

        public static IList<PatientVisitDetail> GetPatientVisitDetailsForInvoice(ISession Session, IList<PatientVisit> pvs)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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
                                                        && pvd.ADET != 0 && pvd.SATISF != 0
                                                    join pv in session.Query<PatientVisit>() on pvd.PatientVisit equals pv
                                                    //orderby pvd.PatientVisit.VisitNo descending, pvd.DetailNo ascending
                                                    select pvd
                                                    )
                                                    .Distinct<PatientVisitDetail>()
                                                    .ToList<PatientVisitDetail>();
                return result;
            }
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

        public static void AddNewInvoice(ISession Session, User user, Patient patient, IList<PatientVisitDetail> pvds, 
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, double advancePaymentUsed, string tellerInvoiceNo)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                string newInvoiceNo = LookUpServices.GetNewInvoiceNo();

                UpdateAdvancePaymentRecords(session, transaction, user, patient, advancePaymentUsed);

                InsertNewAdvancePaymentForInvoice(session, transaction, user, patient,
                    pvds[0].PatientVisit, paymentType, POSType, cashPayment,
                    tellerInvoiceNo, newInvoiceNo);

                InsertNewInvoice(session, transaction, user, patient,
                    pvds, paymentType, POSType, 
                    productTotal, VATTotal, invoiceTotal, discountTotal, VATPercent, cashPayment, 
                    tellerInvoiceNo, "");
                transaction.Commit();
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
        public static void UpdateAdvancePaymentRecords(ISession session, ITransaction transaction, User user, Patient patient, 
            double advancePaymentUsed)
        {
            if (advancePaymentUsed == 0)
                return;

            double remainingAdvancePayment = advancePaymentUsed;

            IList<AdvancePayment> aps = GetPatientAdvancePaymentsForInvoice(session, patient);
            for (int i = 0; i < aps.Count && remainingAdvancePayment > 0; i++)
            {
                AdvancePayment ap = aps[i];
                double usedPayment = Math.Min(remainingAdvancePayment, ap.RemainingAmount);
                ap.KULLANILAN += usedPayment;
                remainingAdvancePayment -= usedPayment;
                session.Update(ap);

                AdvancePaymentUsed apu = new AdvancePaymentUsed();
                apu.AdvancePayment = ap;
                apu.TARIH = DateTime.Today;
                apu.TUTAR = usedPayment;
                apu.USER_ID = user.USER_ID;
                apu.DATE_CREATE = DateTime.Today;
                session.Save(apu);
            }
        }

        public static void InsertNewAdvancePaymentForInvoice(ISession session, ITransaction transaction, User user, 
            Patient patient, PatientVisit pv,
            string paymentType, string POSType, 
            double cashPayment, string tellerInvoiceNo, string invoiceNo)
        {
            string makNo = LookUpServices.GetNewVoucherNo();
            string apNo = LookUpServices.GetNewAdvancePaymentNo();

            AdvancePayment ap = new AdvancePayment();
            ap.AV_ID = Convert.ToDouble(apNo);
            ap.PatientVisit = pv;
            ap.TARIH = DateTime.Today;
            ap.TUTAR = cashPayment;
            ap.KULLANILAN = cashPayment;
            ap.ODEMESEKLI = paymentType;
            ap.POSNO = POSType;
            ap.MAKNO = makNo;
            ap.HESAPKODU = null;
            ap.ALTHESAPKODU = null;
            ap.USER_ID = user.USER_ID;
            ap.DATE_CREATE = DateTime.Now;

            session.Save(ap);

            AdvancePaymentUsed apu = new AdvancePaymentUsed();
            apu.AdvancePayment = ap;
            apu.TARIH = DateTime.Today;
            apu.FATURANO = invoiceNo;
            apu.TUTAR = cashPayment;
            apu.USER_ID = user.USER_ID;
            apu.DATE_CREATE = DateTime.Now;

            session.Save(apu);

            CashDeskRecord cdr = new CashDeskRecord();
            cdr.MAKNO = makNo;
            cdr.KNR = patient.PatientNo;
            cdr.SNR = pv.VisitNo;
            cdr.TARIH = DateTime.Today;
            cdr.MAKBUZNO = "F-" + tellerInvoiceNo;
            cdr.MAKBUZTIPI = "A";
            cdr.ODEMESEKLI = paymentType[0];
            cdr.POSNO = POSType;
            cdr.TUTAR = cashPayment;
            cdr.BORCALACAK = 'B';
            cdr.FATURANO = invoiceNo;
            cdr.VEZNE = user.VEZNE;
            cdr.HESAPKODU = null;
            cdr.ALTHESAPKODU = null;
            cdr.USER_ID = user.USER_ID;
            cdr.DATE_CREATE = DateTime.Now;

            session.Save(cdr);

        }

        public static void InsertNewInvoice(ISession session, ITransaction transaction, User user,
            Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, string tellerInvoiceNo, string invoiceNo)
        {
            string makNo = LookUpServices.GetNewVoucherNo();

            Invoice invoice = new Invoice();
            invoice.KNR = patient.PatientNo;
            invoice.FATURA_ID = invoiceNo;
            invoice.SLNR = tellerInvoiceNo;
            invoice.FATURANO = tellerInvoiceNo;
            invoice.FATURATARIHI = DateTime.Now;
            invoice.HIZMETTUTARI = productTotal;
            invoice.INDIRIM = discountTotal;
            invoice.KDVTUTARI = VATTotal;
            invoice.YUVARLAMA = 0;
            invoice.FATURATUTARI = invoiceTotal;
            invoice.KDVORANI = VATPercent.ToString();
            invoice.NAME = patient.FullName;
            invoice.FATURATIPI = "H";
            invoice.FAK = "K";
            invoice.ZHLKZ = "N";
            invoice.PSG = "";
            invoice.ISODENDI = "1";
            invoice.MAKNO = makNo;
            invoice.VEZNE = user.VEZNE;
            invoice.USER_ID = user.USER_ID;
            invoice.DATE_CREATE = DateTime.Now;

            session.Save(invoice);

            foreach (PatientVisitDetail pvd in pvds)
            {
                pvd.MAKNO = makNo;
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
                                                 where
                                                        dpp.TANIM == pvd.TANIM &&
                                                        dpp.GRUP == pvd.GRUP &&
                                                        dpp.CODE == pvd.CODE &&
                                                        dpp.ARZT == pvd.Doctor2
                                                 select dpp)
                                                 .FirstOrDefault();

                }
            }
        }
        #endregion

        public static void AddNewVoucher(ISession Session, User user, Patient patient, IList<PatientVisitDetail> pvds,
        string paymentType, string POSType,
        double cashPayment, string tellerVoucherNo)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
//                string newInvoiceNo = LookUpServices.GetNewInvoiceNo();

                //UpdateAdvancePaymentRecords(session, transaction, user, patient, advancePaymentUsed);

                //InsertNewAdvancePaymentForInvoice(session, transaction, user, patient,
                //    pvds[0].PatientVisit, paymentType, POSType, cashPayment,
                //    tellerInvoiceNo, newInvoiceNo);

                //InsertNewInvoice(session, transaction, user, patient,
                //    pvds, paymentType, POSType,
                //    productTotal, VATTotal, invoiceTotal, discountTotal, VATPercent, cashPayment,
                //    tellerInvoiceNo, "");
                transaction.Commit();
            }
        }

    }

}
