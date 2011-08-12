namespace Naz.Hastane.Data.Entities 
{
    public class PersonelHastaneBolumu 
    {
        public virtual int ID { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual HastaneBolumu HastaneBolumu { get; set; }
        public virtual string BaslangicTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
