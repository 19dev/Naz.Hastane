using System.ComponentModel;
using Naz.Hastane.Data.Entities.LookUp;

namespace Naz.Hastane.Data.Entities
{
    /// <remarks>tlkpQueueStatusType</remarks>
    [Description("Hasta Muayene Durumu Tanımı")]
    public class QueueStatus : IDValueBase
    {
        public static readonly char Waiting = '1';
        public static readonly char Finished = '2';
        public static readonly char NoShow = '3';
        public static readonly char InExam = '4';
        public virtual char Code { get; set; }
    }
}
