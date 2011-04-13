using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class AdvancePaymentUsedMap : ClassMap<AdvancePaymentUsed> {
        
        public AdvancePaymentUsedMap() {
			Table("AVANSLAR_KULLANILAN");
			LazyLoad();

            CompositeId()
                .KeyReference(x => x.AdvancePayment, "AV_ID")
                //.KeyProperty(x => x.AV_ID)
                .KeyProperty(x => x.FATURANO);
			
            Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.TUTAR).Column("TUTAR").Not.Nullable();
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
        }
    }
}
