using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
    
    public class MEDRAPORDOKTORMap : ClassMap<MEDRAPORDOKTOR> 
    {
        
        public MEDRAPORDOKTORMap() {

            Table("MEDRAPORDOKTOR");
            
            Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");

            References(x => x.PatientVisit).Columns("KNR", "SNR");
            //Map(x => x.KNR).Column("KNR").Length(6);
            //Map(x => x.SNR).Column("SNR").Length(3);
            Map(x => x.DRAD).Column("DRAD").Length(50);
            Map(x => x.DRSOYAD).Column("DRSOYAD").Length(50);
            Map(x => x.BRANS).Column("BRANS").Length(10);
            Map(x => x.TESCILNO).Column("TESCILNO").Length(20);
            Map(x => x.TIPI).Column("TIPI").Length(10);
        }
    }
}
