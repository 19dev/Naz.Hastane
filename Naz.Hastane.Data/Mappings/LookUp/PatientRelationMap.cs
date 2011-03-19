using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class PatientRelationMap : SubclassMap<PatientRelation>
    {
        public PatientRelationMap()
        {
            DiscriminatorValue("10");
        }
    }
}
