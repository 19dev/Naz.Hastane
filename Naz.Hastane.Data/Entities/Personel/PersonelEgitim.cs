using System;
namespace Naz.Hastane.Data.Entities 
{
    public class PersonelEgitim 
    {
        public virtual int ID { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual OkulTipi OkulTipi { get; set; }
        public virtual string OkulAdi { get; set; }
        public virtual DateTime? BaslangicTarihi { get; set; }
        public virtual DateTime? BitisTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
