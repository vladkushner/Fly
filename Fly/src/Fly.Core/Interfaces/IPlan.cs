using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly.Core.Interfaces
{
    public interface IPlan
    {
        int IdPlan { get; set; }
        int AirportFrom { get; set; }
        int AirportTo { get; set; }
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

    }
}
