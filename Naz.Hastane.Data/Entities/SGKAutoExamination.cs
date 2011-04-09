using Naz.Hastane.Data.Entities.LookUp.Special;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities {
    public enum PatientContributionValues
    {
        [Description("0")]
        NoContribution,
        [Description("1")]
        Contribution
    }

    public class SGKAutoExamination {
        public virtual Service Service { get; set; }
        public virtual Product Product { get; set; }
        /// <summary>
        /// KATILIM
        /// </summary>
        public virtual string Contribution { get; set; }
        public virtual string AYKATILIM { get; set; }

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
