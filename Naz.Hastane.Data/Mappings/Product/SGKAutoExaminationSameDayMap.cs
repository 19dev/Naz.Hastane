using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{


    public class SGKAutoExaminationSameDayMap : ClassMap<SGKAutoExaminationSameDay>
    {

        public SGKAutoExaminationSameDayMap()
        {
            Table("OTOMATIK_MUAYENELER2");

            CompositeId()
                .KeyReference(x => x.Service, "SERVISKODU")
                .KeyReference(x => x.Product, "TANIM", "GRUP", "CODE");

            Map(x => x.Contribution).Column("KATILIM").Length(50);
            Map(x => x.AYKATILIM).Column("AYKATILIM").Length(50);
        }
    }
}
