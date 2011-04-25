using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data.Mappings.StoredProcedure
{
    public class DailyTellerReportRecordMap : ClassMap<DailyTellerReportRecord>
    {
        public DailyTellerReportRecordMap()
        {
            Table("sp_GetDailyTellerReport");

            Id(x => x.RowNumber).Column("RowNumber");

            Map(x => x.Date).Column("TARIH");
            Map(x => x.Description).Column("HNEREYEODENDI");
            Map(x => x.TellerVoucherNo).Column("MAKBUZNO");
            Map(x => x.PaymentType).Column("ODEMESEKLI");
            Map(x => x.Payment).Column("TUTAR");
            Map(x => x.RecordType).Column("BORCALACAK");
            Map(x => x.USER_ID).Column("USER_ID");
            Map(x => x.Aciklama).Column("ACIKLAMA");
            Map(x => x.GirenTutar).Column("GIRENTUTAR");
            Map(x => x.CikanTutar).Column("CIKANTUTAR");
            Map(x => x.PatientFirstName).Column("HASTAADI");
            Map(x => x.PatientLastName).Column("HASTASOYADI");
            Map(x => x.PatientNo).Column("KNR");
            Map(x => x.TCID).Column("TCKIMLIKNO");
        }
    }
}
