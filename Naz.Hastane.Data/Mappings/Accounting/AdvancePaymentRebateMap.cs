using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
	
	
	public class AdvancePaymentRebateMap : ClassMap<AdvancePaymentRebate> {
		
		public AdvancePaymentRebateMap() {
			Table("AVANSLAR_IADE");
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.AdvancePayment, "AV_ID")
				.KeyProperty(x => x.IADEMAKNO);
			
			Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.TUTAR).Column("TUTAR").Not.Nullable();
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
		}
	}
}
