using System;
using System.Collections.Generic;
using System.Linq;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

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

        public static void SavePatient(Patient patient)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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

            patient.InsuranceCompany = ""; //PSG SGK: SGK
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
        public static Patient GetNewSGKPatient()
        {
            Patient patient = GetNewPatient();
            patient.InsuranceCompany = "SGK";
            patient.PatientContribution = 'T';
            patient.InsuranceType = "1";
            patient.TransferorInstitution = "1";

            return patient;
        }

        public static void AddSGKPolyclinic(ISession session, Patient patient, Doctor doctor)
        {
            if (patient == null || doctor == null)
                return;

            using (ITransaction transaction = session.BeginTransaction())
            {
                InsuranceCompany ic = session.Get<InsuranceCompany>("SGK");

                float doctorQueueNo = GetDoctorQueueNo(session, doctor);

                PatientVisit pv = AddNewPatientVisit(session, patient, doctor, ic);

                foreach (SGKAutoExamination sa in doctor.Service.SGKAutoExaminations)
                {
                    PatientVisitDetail pvd = new PatientVisitDetail();

                    pvd.DetailNo = GetNewPatientVisitDetailNo(session, pv);

                    pvd.TARIH = DateTime.Now;

                    pvd.TANIM = sa.Product.TANIM;
                    pvd.GRUP = sa.Product.GRUP;
                    pvd.CODE = sa.Product.CODE;
                    pvd.NAME1 = sa.Product.NAME1;

                    pvd.KDV = 0;
                    pvd.ADET = 1;
                    pvd.SATISF = 0;
                    pvd.KSATISF = 0;
                    pvd.PSG = pv.PSG;
                    pvd.Doctor = doctor.ID;
                    pvd.Doctor2 = doctor.ID;
                    pvd.HZLNO = 0;

                    pv.USER_ID = "Aydin";
                    pv.DATE_CREATE = DateTime.Now;

                    pv.AddPatientVisitDetail(pvd);
                    session.Save(pvd);
                }
                transaction.Commit();
            }

        }

        public static float GetDoctorQueueNo(ISession session, Doctor doctor)
        {
            // Get No QueueNo for the Doctor, If new date reset the number
            SystemSetting ss = session.Get<SystemSetting>("TARİH");
            string today = DateTime.Now.ToString("dd/MM/yyyy");
            if (today != ss.Value)
            {
                ss.Value = today;
                doctor.QueueNo = 0;
                session.Save(ss);
            }
            doctor.QueueNo += 1;
            session.Save(doctor);

            return doctor.QueueNo;
        }

        public static PatientVisit AddNewPatientVisit(ISession session, Patient patient, Doctor doctor, InsuranceCompany ic)
        {
            ic.SIRAID += 1;
            session.Save(ic);            double companyVisitNo = ic.SIRAID;

            PatientVisit pv = new PatientVisit();
            pv.VisitNo = GetNewPatientVisitNo(session, patient);
            pv.VisitDate = DateTime.Now;
            pv.TransferValidityPeriod = (short)ic.SEVKGECSURE;
            pv.Doctor = doctor.ID;
            pv.Servis = doctor.Service.ID;
            pv.QueueNo = doctor.QueueNo.ToString("d");
            pv.VisitType = "P";
            pv.SIRAID = ic.SIRAID;
            pv.HZLNO = 0;
            pv.ProvisionNo = "";
            pv.USER_ID = "Aydin";
            pv.SupportInsCompany = "";
            pv.PSG = ic.PSG;
            pv.DATE_CREATE = DateTime.Now;

            patient.AddPatientVisit(pv);
            session.Save(pv);

            return pv;
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
            string a = session.QueryOver<PatientVisit>()
                .Where(x => x.Patient == patient)
                .Select(
                    Projections
                        .ProjectionList()
                        .Add(Projections.Min<PatientVisit>(x => x.VisitNo)))
                .List<string>().First();

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

        public static IList<Patient> GetPatientsForInvoice()
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                IList<Patient> result = session.QueryOver<Patient>()
                    .JoinQueryOver<PatientVisit>(x => x.PatientVisits)
                    .JoinQueryOver<PatientVisitDetail>(x => x.PatientVisitDetails)
                        .Where(d => d.MAKNO == null && d.AMAKNO == null)
                        .And(d => d.ADET != 0)
                        .And(d => d.SATISF != 0)
                        .And(d => d.TARIH >= new DateTime(2011, 3, 1))
                    .List<Patient>().Distinct<Patient>().ToList<Patient>();
                return result;
            }
        }

        public static IList<object> GetPatientVisitsForInvoice()
        {
            Patient patient = null;
            PatientVisit pv = null;
            PatientVisitDetail pvd = null;

            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
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
        }
        public static IList<PatientVisit> GetPatientVisitsForInvoice(Patient patient)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                IList<PatientVisit> result = session.QueryOver<PatientVisit>()
                    .Where(x => x.Patient == patient)
                    .JoinQueryOver<PatientVisitDetail>(x => x.PatientVisitDetails)
                        .Where(d => d.MAKNO == null && d.AMAKNO == null)
                        .And(d => d.ADET != 0)
                        .And(d => d.SATISF != 0)
                    .List().Distinct().ToList();
                return result;
            }
        }

        public static IList<PatientVisitDetail> GetPatientVisitDetailsForInvoice(PatientVisit pv)
        {
            using (IStatelessSession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenStatelessSession())
            {
                IList<PatientVisitDetail> result = session.QueryOver<PatientVisitDetail>()
                    .Where(d => d.PatientVisit == pv && d.MAKNO == null && d.AMAKNO == null)
                    .And(d => d.ADET != 0)
                    .And(d => d.SATISF != 0)
                    .List().Distinct().ToList();
                return result;
            }
        }

    }

}
