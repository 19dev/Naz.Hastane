using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class DoctorMap : ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Table("tlkpvDoctor");

            Id(x => x.Code).Column("SLB").Length(10);

            Map(x => x.ID0).Column("SLK").Length(2);
            Map(x => x.Value).Column("SLT").Length(150);

            References(x => x.Service).Column("SLXX").Not.LazyLoad();
            Map(x => x.QueueNo).Column("SLX");
            Map(x => x.LicenseNo).Column("SLVV").Length(100);
        }
    }
}
