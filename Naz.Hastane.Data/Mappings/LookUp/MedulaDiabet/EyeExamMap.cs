using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class EyeExamMap : ClassMap<EyeExam>
    {
        public EyeExamMap()
        {
            Table("tlkpMedulaDiabetEyeExam");

            Id(x => x.ID);
            Map(x => x.Value).Length(255);
        }
    }
}
