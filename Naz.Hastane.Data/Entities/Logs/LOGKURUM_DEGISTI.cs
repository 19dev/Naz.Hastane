
namespace Naz.Hastane.Data.Entities.Logs 
{
    
    public class LOGKURUM_DEGISTI
    {
        public LOGKURUM_DEGISTI() { }
        public virtual decimal KD_ID { get; set; }

        public virtual string KNR { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual string EPSG { get; set; }
        public virtual string YPSG { get; set; }
        public virtual double OHASTATOP { get; set; }
        public virtual double EHASTATOP { get; set; }
        public virtual double EKURUMTOP { get; set; }
        public virtual double YHASTATOP { get; set; }
        public virtual double YKURUMTOP { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
    }
}
