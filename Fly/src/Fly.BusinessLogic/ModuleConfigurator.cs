using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly.BusinessLogic
{
    public static class ModuleConfigurator
    {
        public static void Configure()
        {

            Fly.Dal.ModuleConfigurator.Configure();
        }
    }
}
