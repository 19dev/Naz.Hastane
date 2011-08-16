using System.ComponentModel;

namespace Naz.Hastane.Data.Entities
{
    public class IDBase
    {
        public virtual int ID { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            IDBase p = obj as IDBase;
            if (p == null)
                return false;
            return (this.ID == p.ID);
        }
    }
}
