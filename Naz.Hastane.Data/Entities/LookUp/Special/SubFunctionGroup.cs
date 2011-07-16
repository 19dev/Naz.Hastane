using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    /// <remarks>tlkpvSubFunctionGroup</remarks>
    [Description("Alt İşlem Grubu")]
    public class SubFunctionGroup : OldLookUpBase
    {
        [Description("Ana GrupTipi")]
        public virtual string TanimCode { get; set; }
        [Description("Grup Tipi")]
        public virtual string GrupCode { get; set; } 
    }
}
