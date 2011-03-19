using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class ServiceMap : SubclassMap<Service>
    {
        public ServiceMap()
        {
            DiscriminatorValue("17");

            Map(x => x.Type).Column("SLXX");
        }
    }
}
