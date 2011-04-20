using Naz.Hastane.Data.Entities.LookUp.Special;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities
{
    public class SGKAutoExaminationSameDay : SGKAutoExaminationBase
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            SGKAutoExamination ae = obj as SGKAutoExamination;
            if (ae == null)
                return false;
            if (this.Service == ae.Service && this.Product == ae.Product)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.Service ? 0 : this.Service.GetHashCode());
            hash += (null == this.Product ? 0 : this.Product.GetHashCode());

            return hash;
        }
    }
}
