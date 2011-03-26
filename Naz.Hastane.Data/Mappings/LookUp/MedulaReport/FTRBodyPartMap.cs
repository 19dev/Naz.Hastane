using Naz.Hastane.Data.Entities.LookUp.MedulaReport;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.MedulaReport
{
    public class FTRBodyPartMap : ClassMap<FTRBodyPart>
    {
        public FTRBodyPartMap()
        {
            Table("tlkpMedulaReportFTRBodyPart");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
            Map(x => x.Code).Column("Code").Length(255);
        }
    }
}
