using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    [Flags]
    internal enum SecurityLevel
    {
        none=0,
        guest=2,
        developer=4,
        secertary=8,
        DBA=16,


    }
}
