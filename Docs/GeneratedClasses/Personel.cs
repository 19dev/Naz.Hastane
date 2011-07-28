using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class Personel {
        public Personel() { }
        public virtual int ID { get; set; }
        public virtual string PersonelNo { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual string AdiSoyadi { get; set; }
        public virtual string TCID { get; set; }
        public virtual string BabaAdi { get; set; }
        public virtual string AnaAdi { get; set; }
        public virtual string DogumYeri { get; set; }
        public virtual string DogumTarihi { get; set; }
        public virtual string Uyrugu { get; set; }
        public virtual string KimlikTuru { get; set; }
        public virtual string KimlikNo { get; set; }
        public virtual string DogumIli { get; set; }
        public virtual string DogumIlcesi { get; set; }
        public virtual string DogumMahalleKoy { get; set; }
        public virtual string DogumCilt { get; set; }
        public virtual System.Nullable<int> DogumAileSiraNo { get; set; }
        public virtual string DogumSiraNo { get; set; }
        public virtual string Cinsiyeti { get; set; }
        public virtual string MedeniHali { get; set; }
        public virtual string Unvani { get; set; }
        public virtual string Bolumu { get; set; }
        public virtual string EvAdresi { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string EvTelefonu { get; set; }
        public virtual string CepTelefonu { get; set; }
        public virtual string Emekli { get; set; }
        public virtual string Sendikali { get; set; }
        public virtual string KanGrubu { get; set; }
        public virtual string IseGirisTarihi { get; set; }
        public virtual string SigortaNo { get; set; }
        public virtual string VergiNo { get; set; }
        public virtual string AyrilisTarihi { get; set; }
        public virtual string CalistigiBolum { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual string Email { get; set; }
        public virtual string Mahalle { get; set; }
        public virtual string Ilce { get; set; }
        public virtual string Il { get; set; }
    }
}
