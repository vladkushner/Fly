using System;
using System.Collections.Generic;

namespace Fly.Dal.EF
{
    public class Plan
    {
        public int Id { get ; set ; }
        public int AirportFromId { get; set; }
        public int AirportToId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public Airport AirportFrom { get; set; }
        public Airport AirportTo { get; set; }
        //TODO resolve collections on Airport class side. 
    }
}
