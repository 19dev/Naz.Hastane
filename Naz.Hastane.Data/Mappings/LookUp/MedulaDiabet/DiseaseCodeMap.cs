using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class DiseaseCodeMap : ClassMap<DiseaseCode>
    {
        public DiseaseCodeMap()
        {
            Table("tlkpMedulaDiabetDiseaseCode");

            Id(x => x.ID);
            Map(x => x.Value).Length(255);
            Map(x => x.Code);
        }
    }
}
