using System.ComponentModel;

namespace Naz.Hastane.Data.Entities
{
    public class IDValueBase : IDBase
    {
        [Description("Değer")]
        public virtual string Value { get; set; }
    }
}
