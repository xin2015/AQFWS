using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQFWS.AirQualityRecords
{
    public class AirQualityIndexRecord : AirQualityRecord
    {
        public virtual decimal? AQI { get; set; }

        public virtual string AQIType { get; set; }

        protected AirQualityIndexRecord()
        {

        }

        public AirQualityIndexRecord(Guid id) : base(id)
        {

        }
    }
}
