using System.Collections.Generic;

namespace Fly.Dal.EF
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get ; set ; }
        public string Password { get ; set ; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
