namespace Naz.Hastane.Data.Entities 
{
    public class PersonelEgitim 
    {
        public virtual int ID { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual int OkulTipiID { get; set; }
        public virtual string BaslangicTarihi { get; set; }
        public virtual string BitisTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
