using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities
{
    public class SystemSettingMap : SubclassMap<SystemSetting>
    {
        public SystemSettingMap()
        {
            DiscriminatorValue("00");
        }
    }
}
