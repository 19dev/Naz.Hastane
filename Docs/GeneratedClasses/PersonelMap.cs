using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class PersonelMap : ClassMap<Personel> {
        
        public PersonelMap() {
			Table("Personel");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PersonelNo).Column("PersonelNo").Not.Nullable().Length(50);
			Map(x => x.Ad).Column("Ad").Not.Nullable().Length(50);
			Map(x => x.Soyad).Column("Soyad").Not.Nullable().Length(50);
			Map(x => x.AdiSoyadi).Column("AdiSoyadi").Length(50);
			Map(x => x.TCID).Column("TCID").Length(15);
			Map(x => x.BabaAdi).Column("BabaAdi").Length(50);
			Map(x => x.AnaAdi).Column("AnaAdi").Length(50);
			Map(x => x.DogumYeri).Column("DogumYeri").Length(50);
			Map(x => x.DogumTarihi).Column("DogumTarihi");
			Map(x => x.Uyrugu).Column("Uyrugu").Length(50);
			Map(x => x.KimlikTuru).Column("KimlikTuru").Length(50);
			Map(x => x.KimlikNo).Column("KimlikNo").Length(50);
			Map(x => x.DogumIli).Column("DogumIli").Length(50);
			Map(x => x.DogumIlcesi).Column("DogumIlcesi").Length(50);
			Map(x => x.DogumMahalleKoy).Column("DogumMahalleKoy").Length(50);
			Map(x => x.DogumCilt).Column("DogumCilt").Length(50);
			Map(x => x.DogumAileSiraNo).Column("DogumAileSiraNo");
			Map(x => x.DogumSiraNo).Column("DogumSiraNo").Length(50);
			Map(x => x.Cinsiyeti).Column("Cinsiyeti").Length(50);
			Map(x => x.MedeniHali).Column("MedeniHali").Length(50);
			Map(x => x.Unvani).Column("Unvani").Length(50);
			Map(x => x.Bolumu).Column("Bolumu").Length(50);
			Map(x => x.EvAdresi).Column("EvAdresi").Length(255);
			Map(x => x.Telefon).Column("Telefon").Length(50);
			Map(x => x.EvTelefonu).Column("EvTelefonu").Length(50);
			Map(x => x.CepTelefonu).Column("CepTelefonu").Length(50);
			Map(x => x.Emekli).Column("Emekli").Length(50);
			Map(x => x.Sendikali).Column("Sendikali").Length(50);
			Map(x => x.KanGrubu).Column("KanGrubu").Length(50);
			Map(x => x.IseGirisTarihi).Column("IseGirisTarihi");
			Map(x => x.SigortaNo).Column("SigortaNo").Length(50);
			Map(x => x.VergiNo).Column("VergiNo").Length(50);
			Map(x => x.AyrilisTarihi).Column("AyrilisTarihi");
			Map(x => x.CalistigiBolum).Column("CalistigiBolum").Length(50);
			Map(x => x.Aciklama).Column("Aciklama").Length(50);
			Map(x => x.Email).Column("Email").Length(50);
			Map(x => x.Mahalle).Column("Mahalle").Length(50);
			Map(x => x.Ilce).Column("Ilce").Length(50);
			Map(x => x.Il).Column("Il").Length(50);
        }
    }
}
