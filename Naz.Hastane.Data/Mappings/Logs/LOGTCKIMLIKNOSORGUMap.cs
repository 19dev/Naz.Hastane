using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.Logs;

namespace Naz.Hastane.Data.Mappings.Logs
{
    public class LOGTCKIMLIKNOSORGUMap : ClassMap<LOGTCKIMLIKNOSORGU> 
    {
        public LOGTCKIMLIKNOSORGUMap() 
        {
			Table("LOGTCKIMLIKNOSORGU");
			Id(x => x.SIRA).Column("SIRA").GeneratedBy.Identity();

            Map(x => x.TCKIMLIKNO).Column("TCKIMLIKNO").Length(50);
			Map(x => x.HASTAADI).Column("HASTAADI").Length(50);
			Map(x => x.HASTASOYADI).Column("HASTASOYADI").Length(50);
			Map(x => x.TARIH).Column("TARIH");
			Map(x => x.TCUSERID).Column("TCUSERID").Length(50);
        }
    }
}
