using System.ComponentModel;

namespace Naz.Hastane.Data.Entities
{
    [Description("Etken Madde Bilgisi")]
    public class EffectiveSubstance 
    {
        [Description("Kod")]
        public virtual string Code { get; set; }
        [Description("Açýklama")]
        public virtual string Value { get; set; }
        [Description("Ýçerik")]
        public virtual string ICERIK { get; set; }
        [Description("Form")]
        public virtual string FORM { get; set; }
        [Description("Miktar")]
        public virtual string MIKTAR { get; set; }
    }
}
