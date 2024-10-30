using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoExceptions.Tests;
public class ThrowExTests
{
    [Fact]
    public void IsNullOrWhitespaceTest()
    {
        string? a = "a";
        var b = ThrowEx.IsNullOrWhitespace("a", a);

        a = null;
        var b2 = ThrowEx.IsNullOrWhitespace("a", a);
    }
}
