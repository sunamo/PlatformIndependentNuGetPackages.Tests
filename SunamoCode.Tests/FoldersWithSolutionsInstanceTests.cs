namespace SunamoCode.Tests;
using Microsoft.Extensions.Logging.Abstractions;
using SunamoDevCode.SunamoSolutionsIndexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FoldersWithSolutionsInstanceTests
{
    [Fact]
    public void ReloadTest()
    {
        var p = @"E:\vs\";

        //DefaultPaths.eVs = p;
        FoldersWithSolutions.PairProjectFolderWithEnum(NullLogger.Instance, p);
        FoldersWithSolutionsInstance d = new FoldersWithSolutionsInstance(NullLogger.Instance, p, null, false);
        d.Reload(NullLogger.Instance, p, null, false);
        var slns = d.Solutions(Enums.RepositoryLocal.Vs17);
        //d.Reload()
    }
}