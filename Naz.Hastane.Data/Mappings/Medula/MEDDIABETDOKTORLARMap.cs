using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
    
    
    public class MEDDIABETDOKTORLARMap : ClassMap<MEDDIABETDOKTORLAR> 
    {
        
        public MEDDIABETDOKTORLARMap() {

            Table("MEDDIABETDOKTORLAR");
            
            Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");

            References(x => x.PatientVisit).Columns("KNR", "SNR");
            //Map(x => x.KNR).Column("KNR").Length(6);
            //Map(x => x.SNR).Column("SNR").Length(3);
            Map(x => x.DRTESCIL).Column("DRTESCIL").Length(20);
            Map(x => x.DRBRANS).Column("DRBRANS").Length(4);
            Map(x => x.DRDM).Column("DRDM").Length(1);
        }
    }
}
