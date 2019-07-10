using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly.Core.Interfaces
{
    public interface IUser
    {
        int IdUser { get; set; }
        int Name { get; set; }
        int Password { get; set; }
    }
}
