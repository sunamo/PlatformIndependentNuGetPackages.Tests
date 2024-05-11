using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoFileIO.Tests;
public class CloudProvidersHelperTests
{
    [Fact]
    public void TestPropertiesValues()
    {
        Assert.Equal(@"D:\Drive\", CloudProvidersHelperSE.GDriveFolder);
    }
}
