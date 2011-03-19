using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class FunctionGroupTypeMap : ClassMap<FunctionGroupType>
    {
        public FunctionGroupTypeMap()
        {
            Table("tlkpAnaIslemTipi");

            Id(x => x.ID);
            Map(x => x.Value).Column("strName").Length(255);
        }
    }
}
