using System.ComponentModel;
namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    /// <remarks>tlkpFunctionGroupType</remarks>
    [Description("İşlem Grubu Tipi")]
    public class FunctionGroupType
    {
        public virtual int ID { get; set; }
        [Description("Değer")]
        public virtual string Value { get; set; }
    }
}
