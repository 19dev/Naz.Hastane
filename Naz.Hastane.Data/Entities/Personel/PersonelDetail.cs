using System.ComponentModel;
using Naz.Hastane.Data.Entities.LookUp;

namespace Naz.Hastane.Data.Entities
{
    public class PersonelDetail : IDBase
    {
        public virtual Personel Personel { get; set; }
    }
}
