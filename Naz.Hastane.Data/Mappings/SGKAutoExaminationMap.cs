using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings {
    
    
    public class SGKAutoExaminationMap : ClassMap<SGKAutoExamination> {
        
        public SGKAutoExaminationMap() {
			Table("OTOMATIK_MUAYENELER");

            CompositeId()
                .KeyReference(x => x.Service, "SERVISKODU")
                .KeyReference(x => x.Product, "TANIM", "GRUP", "CODE");

			Map(x => x.KATILIM).Column("KATILIM").Length(50);
			Map(x => x.AYKATILIM).Column("AYKATILIM").Length(50);
        }
    }
}
