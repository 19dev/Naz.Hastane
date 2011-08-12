namespace Naz.Hastane.Data.Entities 
{
    public class PersonelYabanciDil 
    {
        public virtual int ID { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual YabanciDil YabanciDil { get; set; }
    }
}
