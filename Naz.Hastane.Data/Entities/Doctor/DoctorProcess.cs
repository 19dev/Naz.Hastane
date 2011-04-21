using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class DoctorProcess
    {
        public virtual string ACIKLAMA { get; set; } // ACIKLAMA; length(16); 0
        public virtual string ARZT { get; set; } // ARZT; length(4); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
        public virtual int DP_ID { get; set; } // DP_ID; length(9); 0
        public virtual string KNR { get; set; } // KNR; length(6); 0
        public virtual string SNR { get; set; } // SNR; length(3); 0
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1
    }
}
