using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class NationalityMap : SubclassMap<Nationality>
    {
        public NationalityMap()
        {
            DiscriminatorValue("51");
        }
    }
}
