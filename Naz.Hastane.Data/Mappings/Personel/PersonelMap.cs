using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{    
    
    public class PersonelMap : ClassMap<Personel> 
    {
        
        public PersonelMap() 
        {
            Table("tblPersonel");
            LazyLoad();
            Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            Map(x => x.Ad).Column("Ad").Not.Nullable().Length(50);
            Map(x => x.Soyad).Column("Soyad").Not.Nullable().Length(50);
            Map(x => x.TCID).Column("TCID").Not.Nullable().Length(15);
            Map(x => x.Cinsiyet).Column("Cinsiyet").Not.Nullable().Length(1);
            Map(x => x.KanGrubu).Column("KanGrubu").Not.Nullable();
            Map(x => x.EvAdresi).Column("EvAdresi").Not.Nullable().Length(255);
            Map(x => x.Mahalle).Column("Mahalle").Not.Nullable().Length(50);
            Map(x => x.Ilce).Column("Ilce").Not.Nullable().Length(50);
            Map(x => x.Il).Column("Il").Not.Nullable().Length(50);
            Map(x => x.EvTelefonu).Column("EvTelefonu").Not.Nullable().Length(50);
            Map(x => x.CepTelefonu).Column("CepTelefonu").Not.Nullable().Length(50);
            Map(x => x.PersonelNo).Column("PersonelNo").Not.Nullable().Length(50);
            Map(x => x.Email).Column("Email").Length(50);
            Map(x => x.GirisTarihi).Column("GirisTarihi").Not.Nullable();
            Map(x => x.CikisTarihi).Column("CikisTarihi");
        }
    }
}
