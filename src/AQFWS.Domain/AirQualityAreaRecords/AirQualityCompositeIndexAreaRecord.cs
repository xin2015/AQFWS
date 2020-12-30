using AQFWS.AirQualityRecords;
using AQFWS.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQFWS.AirQualityAreaRecords
{
    public class AirQualityCompositeIndexAreaRecord : AirQualityCompositeIndexRecord
    {
        public virtual AreaType AreaType { get; set; }

        protected AirQualityCompositeIndexAreaRecord()
        {

        }

        public AirQualityCompositeIndexAreaRecord(Guid id) : base(id)
        {

        }
    }
}
