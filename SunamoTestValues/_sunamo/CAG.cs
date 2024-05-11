using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoTestValues._sunamo;
internal class CAG
{
    internal static List<T> ToList<T>(params T[] v)
    {
        return new List<T>(v);
    }
}
