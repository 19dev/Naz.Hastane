﻿using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class SubFunctionGroupMap : ClassMap<SubFunctionGroup>
    {
        public SubFunctionGroupMap()
        {
            Table("tlkpvSubFunctionGroup");

            Id(x => x.Code).Column("SLB").Length(10);

            Map(x => x.ID0).Column("SLK").Length(2);
            Map(x => x.Value).Column("SLT").Length(150);

            Map(x => x.TanimCode).Column("TANIMCODE").ReadOnly();
            Map(x => x.GrupCode).Column("GRUPCODE").ReadOnly();
        }
    }
}
