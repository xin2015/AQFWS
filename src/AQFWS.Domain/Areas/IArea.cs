using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQFWS.Areas
{
    public interface IArea
    {
        string Code { get; set; }
        AreaType Type { get; set; }
    }
}
