using System;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    [Description("Kullanıcı Tanımları")]
    public class User
    {
        [Description("Kullanıcı Adı")]
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual string USER_PASS { get; set; } // USER_PASS; length(10); 0

        [Description("Grubu")]
        public virtual string USER_GRUP { get; set; } // USER_GRUP; length(2); 1

        [Description("Vezne")]
        public virtual string VEZNE { get; set; } // VEZNE; length(2); 1 Hangi Vezne No
        [Description("Doktor")]
        public virtual string ARZT { get; set; } // ARZT; length(4); 1 Doktor ID
        [Description("Meşgul")]
        public virtual string ISBUSY { get; set; } // ISBUSY; length(1); 0 T/F Şu anda kullanıyor mu?
        [Description("Son Erişim")]
        public virtual string LASTACCESS { get; set; } // LASTACCESS; length(10); 0 Son Kullanılan PC MAC Adres
        [Description("Rapor Ekrana")]
        public virtual string PR2WIN { get; set; } // PR2WIN; length(1); 0  Raporlar Ekrana mı gelsin?
        public virtual string STARTOBJ { get; set; } // STARTOBJ; length(100); 0 Açılış Ekranı
        public virtual DateTime TARIH { get; set; } // TARIH; length(8); 0
        public virtual string TERM_PASS { get; set; } // TERM_PASS; length(10); 1

        [Description("Program")]
        public virtual string REV { get; set; } // REV; length(4); 1 Program Versiyonu

        public virtual string TESTER { get; set; } // TESTER; length(1); 0 Hepsi F
        public virtual string INDIRIMYUZDE { get; set; } // INDIRIMYUZDE; length(5); 1 Boş
        public virtual DateTime? DATE_CREATED { get; set; } // DATE_CREATED; length(8); 1 Boş
        public virtual DateTime? DATE_UPDATED { get; set; } // DATE_UPDATED; length(8); 1 Boş
    }
}
