using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class ProductOtherCodeMap : ClassMap<ProductOtherCode>
    {
        public ProductOtherCodeMap()
        {
            Table("HIZMET_DIGER_KOD");

            CompositeId()
                .KeyProperty(x => x.TANIM, "TANIM") //.Length(2); //0
                .KeyProperty(x => x.GRUP, "GRUP") //.Length(3); //0
                .KeyProperty(x => x.CODE, "CODE") //.Length(15); //0;
                .KeyProperty(x => x.FIYLIST, "FIYLIST"); //.Length(2); //0;

            Map(x => x.BUT).Column("BUT").Length(1); //1
            Map(x => x.CODE1).Column("CODE1").Length(15); //0
        }
    }
}
