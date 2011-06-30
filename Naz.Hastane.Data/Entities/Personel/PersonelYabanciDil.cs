using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities 
{
    
    public class PersonelYabanciDil 
    {
        public PersonelYabanciDil() { }
        public virtual int ID { get; set; }
        public virtual int PersonelID { get; set; }
        public virtual int YabanciDilID { get; set; }
    }
}
