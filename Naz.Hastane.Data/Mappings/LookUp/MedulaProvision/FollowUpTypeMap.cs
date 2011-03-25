using System;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class FollowUpTypeMap : ClassMap<FollowUpType>
    {
        public FollowUpTypeMap()
        {
            Table("tlkpMedulaProvisionFollowUpType");

            Id(x => x.ID);
            Map(x => x.Value).Length(500);
            Map(x => x.Code);
        }
    }
}
