﻿using System;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class FollowUpTypeMap : ClassMap<FollowUpType>
    {
        public FollowUpTypeMap()
        {
            Table("tlkpFollowUpType");

            Id(x => x.ID);
            Map(x => x.Value).Length(500);
            Map(x => x.Code);
        }
    }
}