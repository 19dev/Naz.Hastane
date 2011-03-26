using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    [Description("İşlem Grubu")]
    public class FunctionGroup : OldLookUpBase
    {
        [Description("İşlem Grubu Kodu")]
        public virtual string FunctionGroupCode { get; set; }   // null:, 0:, 1:Laboratuar, 2:, 3: Ameliyatlar, 5: Muayeneler, SGK Katılım, 6:Yatak
        public virtual FunctionGroupType FunctionGroupType { get; set; }
    }
}
