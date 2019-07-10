using System.Data.Entity;

namespace Fly.Dal.EF
{
    public class EFDbContext<T> : DbContext where T : class
    {
        public EFDbContext()
            : base("DbConnection")
        { }

        private DbSet<T> Entities { get; set; }
    }
}
