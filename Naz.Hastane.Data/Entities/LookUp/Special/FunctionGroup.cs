namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    public class FunctionGroup : OldLookUpBase
    {
        public virtual string FunctionGroupCode { get; set; }   // null:, 0:, 1:Laboratuar, 2:, 3: Ameliyatlar, 5: Muayeneler, SGK Katılım, 6:Yatak
        public virtual FunctionGroupType FunctionGroupType { get; set; }
    }
}
