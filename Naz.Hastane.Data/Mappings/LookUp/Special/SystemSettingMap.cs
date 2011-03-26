using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities.Special
{
    public class SystemSettingMap : SubclassMap<SystemSetting>
    {
        public SystemSettingMap()
        {
            DiscriminatorValue("00");
        }
    }
}
