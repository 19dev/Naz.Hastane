using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.Special
{
    public class RoomMap : ClassMap<Room>
    {
        public RoomMap()
        {
            Table("ODALAR");

            Id(x => x.ODANO).Column("ODANO").Length(10);

            Map(x => x.DTELNO).Column("DTELNO").Length(4); //0
            Map(x => x.DURUM).Column("DURUM").Length(1); //0
            Map(x => x.HIZMETKODU).Column("HIZMETKODU").Length(20); //1
            Map(x => x.KAT).Column("KAT").Length(2); //1
            Map(x => x.KNR).Column("KNR").Length(6); //1
            Map(x => x.OZELNOT).Column("OZELNOT").Length(50); //1
            Map(x => x.SERVIS).Column("SERVIS").Length(2); //0
            Map(x => x.SNR).Column("SNR").Length(3); //1
        }
    }
}
