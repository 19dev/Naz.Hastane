using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class DoctorAccountDetail
    {
        public virtual DateTime BASLANGICTARIHI { get; set; } // BASLANGICTARIHI; length(8); 0
        public virtual DateTime BITISTARIHI { get; set; } // BITISTARIHI; length(8); 0
        public virtual int CARI_ID { get; set; } // CARI_ID; length(4); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual char ISODENDI { get; set; } // ISODENDI; length(1); 0
        public virtual string KNR { get; set; } // KNR; length(5); 0
        public virtual string ODEYEN { get; set; } // ODEYEN; length(20); 1
        public virtual DateTime TARIH { get; set; } // TARIH; length(8); 0
        public virtual double TUTAR { get; set; } // TUTAR; length(8); 0
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
    }
}
