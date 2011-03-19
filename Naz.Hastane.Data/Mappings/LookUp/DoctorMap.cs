using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class DoctorMap : SubclassMap<Doctor>
    {
        public DoctorMap()
        {
            DiscriminatorValue("07" );

            References(x => x.Service).Column("SLXX");
        }
    }
}
