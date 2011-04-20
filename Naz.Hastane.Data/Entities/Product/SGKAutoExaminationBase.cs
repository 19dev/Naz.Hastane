using Naz.Hastane.Data.Entities.LookUp.Special;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities
{
    public enum PatientContributionValues
    {
        [Description("0")]
        NoContribution,
        [Description("1")]
        Contribution
    }

    public class SGKAutoExaminationBase
    {
        public virtual Service Service { get; set; }
        public virtual Product Product { get; set; }
        /// <summary>
        /// KATILIM
        /// </summary>
        public virtual string Contribution { get; set; }
        public virtual string AYKATILIM { get; set; }
    }
}
