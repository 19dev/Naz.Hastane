namespace Naz.Hastane.Data.Entities 
{
    public class PersonelYabanciDil : PersonelDetail
    {
        public virtual YabanciDil YabanciDil { get; set; }
        public virtual YabanciDilDerecesi OkumaDerecesi { get; set; }
        public virtual YabanciDilDerecesi YazmaDerecesi { get; set; }
        public virtual YabanciDilDerecesi KonusmaDerecesi { get; set; }
        public virtual string Aciklama { get; set; }
    }
}
