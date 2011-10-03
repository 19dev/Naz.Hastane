using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class LabTextMap : ClassMap<LabText> {
        
        public LabTextMap() {
			Table("LabText");
			LazyLoad();
			CompositeId().KeyProperty(x => x.KNR).KeyProperty(x => x.SNR).KeyProperty(x => x.TANIM).KeyProperty(x => x.GRUP).KeyProperty(x => x.CODE).KeyProperty(x => x.TARIH);
			Map(x => x.LABTEXT).Column("LABTEXT").Length(2147483647);
        }
    }
}
