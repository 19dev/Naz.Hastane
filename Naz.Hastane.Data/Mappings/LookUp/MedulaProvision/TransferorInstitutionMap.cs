using System;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class TransferorInstitutionMap : ClassMap<TransferorInstitution>
    {
        public TransferorInstitutionMap()
        {
            Table("tlkpMedulaProvisionTransferorInstitution");

            Id(x => x.ID);
            Map(x => x.Value).Length(500);
            Map(x => x.Code);
        }
    }
}
