
namespace Naz.Hastane.Data.Entities.Logs 
{
    
    public class LOGTCKIMLIKNOSORGU 
    {
        public LOGTCKIMLIKNOSORGU() { }
    
        public virtual int SIRA { get; set; }
        public virtual string TCKIMLIKNO { get; set; }
        public virtual string HASTAADI { get; set; }
        public virtual string HASTASOYADI { get; set; }
        public virtual System.Nullable<System.DateTime> TARIH { get; set; }
        public virtual string TCUSERID { get; set; }
    }
}
