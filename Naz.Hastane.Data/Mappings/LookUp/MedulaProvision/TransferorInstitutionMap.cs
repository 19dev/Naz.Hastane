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

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
            Map(x => x.Code).Column("Code").Length(255);
        }
    }
}
