using System;
namespace Naz.Hastane.Data.Entities 
{
    public class PersonelHastaneBolumu : PersonelDetail
    {
        public virtual HastaneBolumu HastaneBolumu { get; set; }
        public virtual DateTime BaslangicTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
