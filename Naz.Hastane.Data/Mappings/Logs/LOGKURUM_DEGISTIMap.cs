using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.Logs;

namespace Naz.Hastane.Data.Mappings.Logs 
{
    public class LOGKURUM_DEGISTIMap : ClassMap<LOGKURUM_DEGISTI> 
    {
        public LOGKURUM_DEGISTIMap() 
        {
			Table("LOGKURUM_DEGISTI");

            Id(x => x.KD_ID).GeneratedBy.Assigned().Column("KD_ID");
			
            Map(x => x.KNR).Column("KNR").Not.Nullable().Length(6);
			Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.EPSG).Column("EPSG").Not.Nullable().Length(6);
			Map(x => x.YPSG).Column("YPSG").Not.Nullable().Length(6);
			Map(x => x.OHASTATOP).Column("OHASTATOP").Not.Nullable();
			Map(x => x.EHASTATOP).Column("EHASTATOP").Not.Nullable();
			Map(x => x.EKURUMTOP).Column("EKURUMTOP").Not.Nullable();
			Map(x => x.YHASTATOP).Column("YHASTATOP").Not.Nullable();
			Map(x => x.YKURUMTOP).Column("YKURUMTOP").Not.Nullable();
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
        }
    }
}
