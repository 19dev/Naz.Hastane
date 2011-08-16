namespace Naz.Hastane.Data.Entities 
{
    public class PersonelHizmetIciEgitim : PersonelDetail
    {
        public virtual HizmetIciEgitim HizmetIciEgitim { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
