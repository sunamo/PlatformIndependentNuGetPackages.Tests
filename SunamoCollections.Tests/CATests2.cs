using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoCollections.Tests;
internal class CATests2
{
    [Fact]
    public void DivideByPercentTest()
    {
        List<int> a = TestData._0To95;
        var actual = CA.DivideByPercent<int>(a, 10);

        Assert.Equal(TestData._0To95By10, actual);
    }
}
