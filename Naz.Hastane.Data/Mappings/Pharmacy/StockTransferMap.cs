using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class StockTransferMap : ClassMap<StockTransfer> 
	{
		public StockTransferMap() 
		{
			Table("SHARK");
			LazyLoad();
			Id(x => x.SH_ID).Column("SH_ID").GeneratedBy.Identity();
			Map(x => x.AKOD).Column("AKOD").Not.Nullable().Length(2);
			Map(x => x.TANIM).Column("TANIM").Not.Nullable().Length(2);
			Map(x => x.GRUP).Column("GRUP").Not.Nullable().Length(3);
			Map(x => x.CODE).Column("CODE").Not.Nullable().Length(15);
			Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.FIRMA).Column("FIRMA").Not.Nullable().Length(1);
			Map(x => x.EVRAKNO).Column("EVRAKNO").Length(10);
			Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(50);
			Map(x => x.G_C).Column("G_C").Not.Nullable().Length(1);
			Map(x => x.ADET).Column("ADET").Not.Nullable();
			Map(x => x.BIRIMF).Column("BIRIMF").Not.Nullable();
			Map(x => x.TUTAR).Column("TUTAR").Not.Nullable();
			Map(x => x.SERVIS).Column("SERVIS").Length(2);
			Map(x => x.ARZT).Column("ARZT").Length(4);
			Map(x => x.DURUM).Column("DURUM").Length(1);
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
			Map(x => x.KALAN).Column("KALAN");
			Map(x => x.MIADTARIHI).Column("MIADTARIHI");
		}
	}
}
