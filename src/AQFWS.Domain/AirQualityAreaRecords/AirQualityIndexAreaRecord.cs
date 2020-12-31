using AQFWS.AirQualityRecords;
using AQFWS.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQFWS.AirQualityAreaRecords
{
    public class AirQualityIndexAreaRecord : AirQualityIndexRecord, IArea
    {
        public virtual AreaType Type { get; set; }

        protected AirQualityIndexAreaRecord()
        {

        }

        public AirQualityIndexAreaRecord(Guid id) : base(id)
        {

        }
    }
}
