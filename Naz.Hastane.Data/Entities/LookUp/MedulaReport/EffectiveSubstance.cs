using System.ComponentModel;

namespace Naz.Hastane.Data.Entities
{
    [Description("Etken Madde Bilgisi")]
    public class EffectiveSubstance 
    {
        [Description("Kod")]
        public virtual string Code { get; set; }
        [Description("A��klama")]
        public virtual string Value { get; set; }
        [Description("��erik")]
        public virtual string ICERIK { get; set; }
        [Description("Form")]
        public virtual string FORM { get; set; }
        [Description("Miktar")]
        public virtual string MIKTAR { get; set; }
    }
}
