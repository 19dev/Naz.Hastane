using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class FunctionGroupMap : SubclassMap<FunctionGroup>
    {
        public FunctionGroupMap()
        {
            DiscriminatorValue("01");       // tlkpAnaIslem

            Map(x => x.FunctionGroupCode)       .Column("SLX"); // float
            References(x => x.FunctionGroupType).Column("lngAnaIslemID");
        }
    }
}
