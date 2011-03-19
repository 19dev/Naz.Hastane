using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class DoctorPoolMap : ClassMap<DoctorPool>
    {
        public DoctorPoolMap()
        {
            Table("DOKTORLAR_HAVUZ");

            Id(x => x.HAVUZ_ID).Column("HAVUZ_ID").Length(6);

            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.HAVUZ_ID).Column("HAVUZ_ID").Length(4); //0
            Map(x => x.HKNR).Column("HKNR").Length(6); //0
            Map(x => x.ISODENDI).Column("ISODENDI").Length(1); //0
            Map(x => x.KNR).Column("KNR").Length(6); //0
            Map(x => x.PAY).Column("PAY").Length(8); //0
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
        }
    }
}
