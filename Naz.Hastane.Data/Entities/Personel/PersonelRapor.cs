using System;
namespace Naz.Hastane.Data.Entities 
{
    public class PersonelRapor : PersonelDetail
    {
        public virtual DateTime BaslangicTarihi { get; set; }
        public virtual DateTime BitisTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
