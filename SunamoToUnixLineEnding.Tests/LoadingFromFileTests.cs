using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoToUnixLineEnding.Tests;
public class LoadingFromFileTests
{
    public void DoTest()
    {
        var bp = @"D:\_Test\PlatformIndependentNuGetPackages\SunamoToUnixLineEnding\";
        var n = bp + @"n.txt";
        var rn = bp + @"rn.txt";

        List<string> l = ["a", "c"];
        File.WriteAllText(n, string.Join("\n", l));
        File.WriteAllText(rn, string.Join("\r\n", l));

        var n2 = File.ReadAllLines(n);
        var rn2 = File.ReadAllLines(rn);

        var n3 = File.ReadAllText(n);
        var rn3 = File.ReadAllText(rn);
    }
}
