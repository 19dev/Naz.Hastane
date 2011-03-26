using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class PatientRelationMap : SubclassMap<PatientRelation>
    {
        public PatientRelationMap()
        {
            DiscriminatorValue("10");
        }
    }
}
