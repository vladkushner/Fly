using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly.Core.Interfaces
{
    public interface IDbContext<T>
    {
        IEnumerable<T> Get();
        T Get(int id);
        bool Remove(int id);
        bool Add(T obj);
        bool Update(T obj);
    }
}
