using System;
using System.Collections.Generic;
using System.Linq;
using Naz.Hastane.Data.Entities;
using NHibernate;
using NHibernate.Linq;

namespace Naz.Hastane.Data.Services
{
    public static class MedulaReportServices
    {
        public static IList<MedulaDiabetReport> GetUnSentMedulaDiabetReports(DateTime startDate, DateTime endDate)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetUnSentMedulaDiabetReports(session, startDate, endDate);
        }
        public static IList<MedulaDiabetReport> GetUnSentMedulaDiabetReports(ISession session, DateTime startDate, DateTime endDate)
        {
            return GetMedulaDiabetReports(session, startDate, endDate, "0");
        }

        public static IList<MedulaDiabetReport> GetSentMedulaDiabetReports(DateTime startDate, DateTime endDate)
        {
            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
                return GetSentMedulaDiabetReports(session, startDate, endDate);
        }
        public static IList<MedulaDiabetReport> GetSentMedulaDiabetReports(ISession session, DateTime startDate, DateTime endDate)
        {
            return GetMedulaDiabetReports(session, startDate, endDate, "1");
        }

        public static IList<MedulaDiabetReport> GetMedulaDiabetReports(ISession session, DateTime startDate, DateTime endDate, string sentUnSent)
        {
            //MedulaDiabetReport mdr = null;
            //PatientVisit pv = null;
            //Patient patient = null;

            //IList<object> result = session.QueryOver<MedulaDiabetReport>(() => mdr)
            //    .Where(x => x.IsSent == sentUnSent)
            //    .JoinQueryOver<PatientVisit>(x => x.PatientVisit, () => pv)
            //    .JoinQueryOver<Patient>(() => pv.Patient, () => patient)
            //    .Where(() => pv.VisitDate >= startDate && pv.VisitDate < endDate.AddDays(1))
            //    .SelectList(list => list
            //        .Select(() => patient.FirstName)
            //        .Select(() => patient.LastName)
            //        .Select(() => pv.VisitNo)
            //        .Select(() => pv.VisitDate))
            //    .List<object[]>()
            //    .Select(properties => new
            //    {
            //        FirstName = (string)properties[0],
            //        LastName = (string)properties[1],
            //        VisitNo = (string)properties[2],
            //        VisitDate = (DateTime?)properties[3]
            //    })
            //    .Distinct()
            //    .ToList<object>();
            //return result;

            return (from report in session.Query<MedulaDiabetReport>()
                    where report.IsSent == sentUnSent
                    join patientVisit in session.Query<PatientVisit>()
                        on report.PatientVisit equals patientVisit
                    where patientVisit.VisitDate >= startDate
                    select report).ToList();
        }

    }
}
