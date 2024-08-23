
namespace SunamoDevCode.Tests;
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
        FoldersWithSolutions.PairProjectFolderWithEnum(p);
        FoldersWithSolutionsInstance d = new FoldersWithSolutionsInstance(p, null, false);
        d.Reload(p, null, false);
        var slns = d.Solutions(Enums.RepositoryLocal.Vs17);
        //d.Reload()
    }
}
