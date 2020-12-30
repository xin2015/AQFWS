using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQFWS.AirQualityRecords
{
    public class AirQualityCompositeIndexRecord : AirQualityRecord
    {
        public virtual decimal? AQCI { get; set; }

        public virtual decimal Count { get; set; }

        public virtual decimal ValidCount { get; set; }

        public virtual decimal NonExceedenceCount { get; set; }

        protected AirQualityCompositeIndexRecord()
        {

        }

        public AirQualityCompositeIndexRecord(Guid id) : base(id)
        {

        }
    }
}
