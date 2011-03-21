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

        public static void AddSGKPolyclinic(Patient patient, Doctor doctor, ProvizyonCevapDVO provizyonCevapDVO)
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
                SystemSetting ss = session.Get<SystemSetting>("TARIH");
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

                //PatientVisitDetail pvd = new PatientVisitDetail();
                //pv.AddPatientVisitDetail(pvd);
                //pvd.DetailNo = LookUpServices.GetNewPatientVisitDetailNo(pv);
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
            var ss = session
                .CreateQuery("SELECT MIN(VisitNo) FROM PatientVisit as visit WHERE visit.Patient.PatientNo =" + patient.PatientNo)
                .List();
            int id = 1000;
            if (ss[0] != null)
                id = Convert.ToInt32(ss[0].ToString());
            id -= 1;
            return id.ToString();
        }

        public static double GetNewPatientVisitDetailNo(PatientVisit pv)
        {
            using (ISession session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetNewPatientVisitDetailNo(pv, session);
        }
        public static double GetNewPatientVisitDetailNo(PatientVisit pv, ISession session)
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
        #endregion

    }
}
