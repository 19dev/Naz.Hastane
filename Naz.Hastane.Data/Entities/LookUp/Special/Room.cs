namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    public class Room
    {
        public virtual string DTELNO { get; set; } // DTELNO; length(4); 0
        public virtual string DURUM { get; set; } // DURUM; length(1); 0
        public virtual string HIZMETKODU { get; set; } // HIZMETKODU; length(20); 1
        public virtual string KAT { get; set; } // KAT; length(2); 1
        public virtual string KNR { get; set; } // KNR; length(6); 1
        public virtual string ODANO { get; set; } // ODANO; length(10); 0
        public virtual string OZELNOT { get; set; } // OZELNOT; length(50); 1
        public virtual string SERVIS { get; set; } // SERVIS; length(2); 0
        public virtual string SNR { get; set; } // SNR; length(3); 1
    }
}
