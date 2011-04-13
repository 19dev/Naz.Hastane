using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Mappings.LookUp;

namespace Naz.Hastane.Data.Entities.Special
{
    public class SystemSettingMap : ClassMap<SystemSetting>
    {
        public SystemSettingMap()
        {
            Table("tlkpvSystemSetting");

            Id(x => x.Code).Column("SLB").Length(10);

            Map(x => x.ID0).Column("SLK").Length(2);
            Map(x => x.Value).Column("SLT").Length(150);
        }
    }
}
