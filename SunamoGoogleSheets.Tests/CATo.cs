using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoGoogleSheets.Tests;
public class CATo
{
    public static List<T> To<T>(params T[] t)
    {
        return t.ToList();
    }
}
