using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data.Mappings.StoredProcedure
{
    public class PatientBalanceRecordMap : ClassMap<PatientBalanceRecord>
    {
        public PatientBalanceRecordMap()
        {
            Table("sp_GetPatientBalance");

            Id(x => x.RowNumber).Column("RowNumber");

            Map(x => x.Date).Column("TARIH");
            Map(x => x.Type).Column("TIP");
            Map(x => x.Borc).Column("BORC");
            Map(x => x.Alacak).Column("ALACAK");
        }
    }
}
