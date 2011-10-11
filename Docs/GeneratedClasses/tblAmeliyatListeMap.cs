using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class tblAmeliyatListeMap : ClassMap<tblAmeliyatListe> {
        
        public tblAmeliyatListeMap() {
			Table("tblAmeliyatListe");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.Tarih).Column("Tarih");
			Map(x => x.Oda).Column("Oda").Length(50);
			Map(x => x.Hasta).Column("Hasta").Length(50);
			Map(x => x.Doktor).Column("Doktor").Length(50);
			Map(x => x.AmeliyatAdi).Column("AmeliyatAdi").Length(50);
			Map(x => x.Durum).Column("Durum");
			Map(x => x.BaslangicSaati).Column("BaslangicSaati");
			Map(x => x.BitisSaati).Column("BitisSaati");
        }
    }
}
