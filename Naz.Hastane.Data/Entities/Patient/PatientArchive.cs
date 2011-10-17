using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class PatientArchive
    {
        public virtual int ID { get; set; }

        public virtual Patient Patient { get; set; } // KNR; length(6); 0
    
        public virtual string Yer { get; set; } // ORAN1; length(150); 1
        public virtual string Oda { get; set; } // ORAN2; length(150); 1
        public virtual string Raf { get; set; } // ORAN1; length(150); 1
        public virtual string Kutu { get; set; } // ORAN2; length(150); 1

        public virtual string USER_ID { get; set; } //USER_ID
        public virtual DateTime DATE_CREATE { get; set; } //DATE_CREATE
        public virtual string USER_ID_UPDATE { get; set; } //USER_ID_UPDATE
        public virtual DateTime? DATE_UPDATE { get; set; } //DATE_UPDATE
    }
}
