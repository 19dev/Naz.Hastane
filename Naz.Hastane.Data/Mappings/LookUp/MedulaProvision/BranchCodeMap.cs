using System;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class BranchCodeMap : ClassMap<BranchCode>
    {
        public BranchCodeMap()
        {
            Table("tlkpMedulaProvisionBranchCode");

            Id(x => x.ID);
            Map(x => x.Value).Length(500);
            Map(x => x.Code);
        }
    }
}
