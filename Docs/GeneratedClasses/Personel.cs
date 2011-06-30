using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class Personel {
        public Personel() { }
        public virtual int ID { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual long Cinsiyet { get; set; }
        public virtual int KanGrubu { get; set; }
        public virtual string EvAdresi { get; set; }
        public virtual string Mahalle { get; set; }
        public virtual string Ilce { get; set; }
        public virtual string EvTelefonu { get; set; }
        public virtual string CepTelefonu { get; set; }
        public virtual string PersonelNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string GirisTarihi { get; set; }
        public virtual string CikisTarihi { get; set; }
    }
}
