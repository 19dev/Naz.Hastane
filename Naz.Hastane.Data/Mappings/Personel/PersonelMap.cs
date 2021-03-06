using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class PersonelMap : ClassMap<Personel> 
	{
		public PersonelMap() {
			Table("tblPersonel");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PersonelNo).Column("PersonelNo").Length(50);
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

			Map(x => x.EvAdresi).Column("EvAdresi").Length(255);
			Map(x => x.Telefon).Column("Telefon").Length(50);
			Map(x => x.EvTelefonu).Column("EvTelefonu").Length(50);
			Map(x => x.CepTelefonu).Column("CepTelefonu").Length(50);

			References(x => x.PersonelUnvani).Column("PersonelUnvaniID");
			References(x => x.HastaneBolumu).Column("HastaneBolumuID");

			Map(x => x.IsRetired).Column("IsRetired").Length(1);
			Map(x => x.HasUnion).Column("HasUnion").Length(1);
			References(x => x.KanGrubu).Column("KanGrubu");
			Map(x => x.IseGirisTarihi).Column("IseGirisTarihi");
			Map(x => x.SigortaNo).Column("SigortaNo").Length(50);
			Map(x => x.VergiNo).Column("VergiNo").Length(50);
			Map(x => x.AyrilisTarihi).Column("AyrilisTarihi");
			Map(x => x.Aciklama).Column("Aciklama").Length(50);
			Map(x => x.Email).Column("Email").Length(50);
			Map(x => x.Mahalle).Column("Mahalle").Length(50);
			Map(x => x.Ilce).Column("Ilce").Length(50);
			Map(x => x.Il).Column("Il").Length(50);

			HasMany(x => x.PersonelEgitims).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelHastaneBolumus).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelHizmetIciEgitims).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelIzins).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelRapors).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelSertifikas).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelUnvans).KeyColumn("PersonelID").Inverse();
			HasMany(x => x.PersonelYabanciDils).KeyColumn("PersonelID").Inverse();

		}
	}
}
