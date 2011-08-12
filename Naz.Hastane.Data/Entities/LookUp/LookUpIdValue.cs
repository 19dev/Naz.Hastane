using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public class LookUpIdValue
    {
        public virtual int ID { get; set; }
        [Description("Değer")]
        public virtual string Value { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LookUpIdValue p = obj as LookUpIdValue;
            if (p == null)
                return false;
            return (this.ID == p.ID);
        }
    }
}
