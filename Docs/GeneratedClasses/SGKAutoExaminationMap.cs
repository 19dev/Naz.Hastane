using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class SGKAutoExaminationMap : ClassMap<SGKAutoExamination> {
        
        public SGKAutoExaminationMap() {
			Table("SGKAutoExamination");
			LazyLoad();
			CompositeId().KeyProperty(x => x.SERVISKODU).KeyProperty(x => x.TANIM).KeyProperty(x => x.GRUP).KeyProperty(x => x.CODE);
			Map(x => x.KATILIM).Column("KATILIM").Length(50);
			Map(x => x.AYKATILIM).Column("AYKATILIM").Length(50);
        }
    }
}
