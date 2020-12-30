using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AQFWS.Stations
{
    public class Station : AuditedAggregateRoot<Guid>
    {
        public Guid AreaId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public StationType Type { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool IsCompared { get; set; }
        public bool IsEnabled { get; set; }
    }
}
