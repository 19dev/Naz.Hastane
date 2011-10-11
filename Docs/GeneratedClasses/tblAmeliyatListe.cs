using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class tblAmeliyatListe {
        public tblAmeliyatListe() { }
        public virtual int ID { get; set; }
        public virtual string Tarih { get; set; }
        public virtual string Oda { get; set; }
        public virtual string Hasta { get; set; }
        public virtual string Doktor { get; set; }
        public virtual string AmeliyatAdi { get; set; }
        public virtual System.Nullable<int> Durum { get; set; }
        public virtual System.Nullable<System.DateTime> BaslangicSaati { get; set; }
        public virtual System.Nullable<System.DateTime> BitisSaati { get; set; }
    }
}
