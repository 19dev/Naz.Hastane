using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class ETKEN_MADDE {
        public ETKEN_MADDE() { }
        public virtual string KODU { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string ICERIK { get; set; }
        public virtual string FORM { get; set; }
        public virtual string MIKTAR { get; set; }
    }
}
