using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naz.Hastane.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Naz.Hastane.Data.Entities.LookUp;
using Naz.Hastane.Medula.HastaKabulIslemleri;

namespace Naz.Hastane.Data.Services
{
    public static class PatientServices
    {
        public static Patient GetByNo(string aPatientNo)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return session.Get<Patient>(aPatientNo);
        }

        public static Patient GetByTCId(string aTCID)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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

        public static void AddSGKPolyclinic(Patient patient, Doctor doctor)
        {
            if (patient == null || doctor == null)
                return;

            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                InsuranceCompany ic = session.Get<InsuranceCompany>("SGK");
                ic.SIRAID += 1;
                session.Save(ic);

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

                PatientVisit pv = new PatientVisit();
                pv.VisitNo = GetNewPatientVisitNo(patient, session);
                pv.Doctor = doctor.ID;
                pv.SIRAID = doctor.QueueNo;
                pv.Servis = doctor.Service.ID;
                pv.VisitDate = DateTime.Now;
                pv.TransferValidityPeriod = (short)ic.SEVKGECSURE;
                pv.VisitType = "P";
                pv.HZLNO = 1;
                pv.PSG = "SGK";
                pv.USER_ID = "Aydin";
                pv.DATE_CREATE = DateTime.Now;

                patient.AddPatientVisit(pv);
                session.Save(pv);

                foreach (SGKAutoExamination sa in doctor.Service.SGKAutoExaminations)
                {
                    PatientVisitDetail pvd = new PatientVisitDetail();

                    pvd.DetailNo = GetNewPatientVisitDetailNo(pv);

                    //pvd.TARIH = DateTime.Now;

                    //pvd.TANIM = sa.Product.TANIM;
                    //pvd.GRUP = sa.Product.GRUP;
                    //pvd.CODE = sa.Product.CODE;
                    //pvd.NAME1 = sa.Product.NAME1;

                    //pvd.KDV = 0;
                    //pvd.ADET = 1;
                    //pvd.SATISF = 0;
                    //pvd.KSATISF = 0;
                    //pvd.PSG = pv.PSG;
                    //pvd.Doctor = doctor.ID;
                    //pvd.Doctor2 = doctor.ID;
                    //pvd.HZLNO = 0;

                    pv.USER_ID = "Aydin";
                    pv.DATE_CREATE = DateTime.Now;

                    //pv.AddPatientVisitDetail(pvd);
                    //session.Save(pvd);
                }
            }


        }

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
                return GetNewPatientVisitNo(patient, session);
        }
        public static string GetNewPatientVisitNo(Patient patient, ISession session)
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
                return GetNewPatientVisitDetailNo(pv, session);
        }
        public static double GetNewPatientVisitDetailNo(PatientVisit pv, ISession session)
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
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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

        public static IList<object[]> GetPatientVisitsForInvoice()
        {
            Patient patient = null;

            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            {
                var result = (List<object[]>)session.QueryOver<PatientVisit>()
                    .Fetch(x => x.Patient).Eager
                    .JoinAlias(x => x.Patient, () => patient)
                    .JoinQueryOver<PatientVisitDetail>(x => x.PatientVisitDetails)
                        .Where(d => d.MAKNO == null && d.AMAKNO == null)
                        .And(d => d.ADET != 0)
                        .And(d => d.SATISF != 0)
                        .And(d => d.TARIH >= new DateTime(2011, 3, 1))
                    .SelectList(list => list
                        .Select(() => patient.FirstName)
                        .Select(() => patient.LastName)
                        .Select(x => x.VisitNo)
                        .Select(x => x.VisitDate)
                        .Select(x => x.ExitDate)
                        .Select(x => x.PatientTotal))
                    //.Select(x => x.Patient.FirstName,
                    //        x => x.Patient.LastName,
                    //        x => x.VisitNo,
                    //        x => x.VisitDate,
                    //        x => x.ExitDate,
                    //        x => x.PatientTotal)
                    .List<object[]>()
                    .Select(properties => new {
                        PatientFirstName = (string)properties[0],
                        PatientLastName = (string)properties[1],
                        VisitNo = (string)properties[2],
                        VisitDate = (DateTime?)properties[3],
                        ExitDate = (DateTime?)properties[4],
                        PatientTotal = (double)properties[5],
                    });
                return result;
            }
        }

        public static IList<PatientVisit> GetPatientVisitsForInvoice(Patient patient)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
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
