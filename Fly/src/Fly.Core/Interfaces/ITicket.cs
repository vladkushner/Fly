using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly.Core.Interfaces
{
    public interface ITicket
    {
        int IdTicket { get; set; }
        int IdPlan { get; set; }
        int IdUser { get; set; }
        decimal Cost { get; set; }
        bool Paid { get; set; }

    }
}
