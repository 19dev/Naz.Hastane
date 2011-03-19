using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class VATMap : SubclassMap<VAT>
    {
        public VATMap()
        {
            DiscriminatorValue("02");
        }
    }
}
