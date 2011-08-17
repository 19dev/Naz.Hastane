using System;
namespace Naz.Hastane.Data.Entities
{
    public class PersonelUnvan : PersonelDetail
    {
        public virtual Unvan Unvan { get; set; }
        public virtual DateTime? BaslangicTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
