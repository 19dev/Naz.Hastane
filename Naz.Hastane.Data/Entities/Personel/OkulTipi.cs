using System.ComponentModel;
using Naz.Hastane.Data.Entities.LookUp;

namespace Naz.Hastane.Data.Entities
{
    /// <remarks>tlkpOkulTipi</remarks>
    [Description("Okul Tipi Tanımı")]
    public class OkulTipi : LookUpIdValue
    {
        public virtual int Rank { get; set; }
    }
}
