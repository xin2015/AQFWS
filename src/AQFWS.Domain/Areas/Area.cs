using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AQFWS.Areas
{
    public class Area : AuditedAggregateRoot<Guid>
    {
        public Guid ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public AreaType Type { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool IsEnabled { get; set; }
    }
}
