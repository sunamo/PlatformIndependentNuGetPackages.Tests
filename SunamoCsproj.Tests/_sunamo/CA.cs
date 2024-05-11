using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoCsproj.Tests._sunamo;
internal class CA
{
    public static List<string> Trim(List<string> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            l[i] = l[i].Trim();
        }

        return l;
    }
}
