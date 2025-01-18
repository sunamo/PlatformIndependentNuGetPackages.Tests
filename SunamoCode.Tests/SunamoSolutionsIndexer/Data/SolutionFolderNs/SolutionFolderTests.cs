using SunamoDevCode.SunamoSolutionsIndexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoDevCode.Tests.SunamoSolutionsIndexer.Data.SolutionFolderNs;
public class SolutionFolderTests : TestsBase
{


    [Fact]
    public void ExeToReleaseTest()
    {
        var appWithoutProjectDistinction = "ConsoleApp1";
        var projectDistinction = "";

        FoldersWithSolutions.InsertIntoFwss(logger, @"E:\vs", null);

        var app = SolutionsIndexerHelper.SolutionWithName(appWithoutProjectDistinction);
        app.ExeToRelease(app, projectDistinction, true);


    }
}
