using SunamoDevCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoDevCode.Tests.Services;
public class AddOrEditNamespaceServiceTests
{
    [Fact]
    public async Task AddOrEditNamespaceForSingleFileAndSaveTest()
    {
        var addOrEditNamespaceService = new AddOrEditNamespaceService();
        var ns = await addOrEditNamespaceService.AddOrEditNamespaceForSingleFileAndSave(@"E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoDotNetZip\", "SunamoDotNetZip", @"E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoDotNetZip\Zlib\ZlibConstants.cs");

    }
}
