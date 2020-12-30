using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace AQFWS.AirQualityRecords
{
    public class AirQualityRecord : Entity<Guid>
    {
        public virtual DateTime Time { get; set; }

        public virtual string Code { get; set; }

        public virtual decimal? SO2 { get; set; }

        public virtual decimal? NO2 { get; set; }

        public virtual decimal? CO { get; set; }

        public virtual decimal? O3 { get; set; }

        public virtual decimal? PM10 { get; set; }

        public virtual decimal? PM25 { get; set; }

        public virtual string PrimaryPollutant { get; set; }

        protected AirQualityRecord()
        {

        }

        public AirQualityRecord(Guid id) : base(id)
        {

        }
    }
}
