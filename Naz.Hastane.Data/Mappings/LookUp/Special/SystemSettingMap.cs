using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Mappings.LookUp;

namespace Naz.Hastane.Data.Entities.Special
{
    public class SystemSettingMap : SubclassMap<SystemSetting>
    {
        public SystemSettingMap()
        {
            DiscriminatorValue(LookUpDiscriminators.SystemSettings.GetDescription());
        }
    }
}
