using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    internal interface IMemberOfFamily
    {
        string Name { get; }
        string LastName { get; }
        int Age { get; }

        string Earning(Father father);
    }
}
