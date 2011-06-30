using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities 
{
    
    public class PersonelIzin 
    {
        public PersonelIzin() { }
        public virtual int ID { get; set; }
        public virtual int PersonelID { get; set; }
        public virtual string BaslangicTarihi { get; set; }
        public virtual string BitisTarihi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
