using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class ProductOtherNameMap : ClassMap<ProductOtherName>
    {
        public ProductOtherNameMap()
        {
            Table("HIZMET_DIGER_AD");

            CompositeId()
                .KeyProperty(x => x.TANIM, "TANIM") //.Length(2); //0
                .KeyProperty(x => x.GRUP, "GRUP") //.Length(3); //0
                .KeyProperty(x => x.CODE, "CODE") //.Length(15); //0;
                .KeyProperty(x => x.FIYLIST, "FIYLIST"); //.Length(2); //0;

            Map(x => x.NAME1).Column("NAME1").Length(100); //0
        }
    }
}
