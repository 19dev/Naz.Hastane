using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class LabDefinitionNormalMap : ClassMap<LabDefinitionNormal> {
        
        public LabDefinitionNormalMap() {
			Table("LabDefinitionNormal");
			LazyLoad();
			CompositeId();
			Map(x => x.TANIM).Column("TANIM").Not.Nullable().Length(2);
			Map(x => x.GRUP).Column("GRUP").Not.Nullable().Length(3);
			Map(x => x.CODE).Column("CODE").Not.Nullable().Length(15);
			Map(x => x.IND).Column("IND").Not.Nullable();
			Map(x => x.SIRA).Column("SIRA");
			Map(x => x.CINSIYET).Column("CINSIYET").Length(1);
			Map(x => x.DMY).Column("DMY").Length(1);
			Map(x => x.DMY1).Column("DMY1");
			Map(x => x.DMY2).Column("DMY2");
			Map(x => x.NORMAL1).Column("NORMAL1").Length(25);
			Map(x => x.NORMAL2).Column("NORMAL2").Length(25);
			Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(50);
			Map(x => x.PANIK1).Column("PANIK1").Length(25);
			Map(x => x.PANIK2).Column("PANIK2").Length(25);
        }
    }
}
