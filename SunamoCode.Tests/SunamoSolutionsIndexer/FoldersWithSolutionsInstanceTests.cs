namespace SunamoDevCode.Tests.SunamoSolutionsIndexer;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using SunamoDevCode.SunamoSolutionsIndexer;
using SunamoPaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FoldersWithSolutionsTests
{
    ILogger logger = NullLogger.Instance;

    [Fact]
    public void InsertIntoFwssTest()
    {
        FoldersWithSolutions.InsertIntoFwss(logger, DefaultPaths.eVs, null);
    }

    [Fact]
    public void Reload_AllProjectFoldersIsLoaded()
    {
        FoldersWithSolutions foldersWithSolutionsInstance = new(NullLogger.Instance, @"E:\vs\", null);


    }

    [Fact]
    public void ReloadTest()
    {
        var p = @"E:\vs\";

        //DefaultPaths.eVs = p;
        FoldersWithSolutions.PairProjectFolderWithEnum(NullLogger.Instance, p);
        FoldersWithSolutions d = new FoldersWithSolutions(NullLogger.Instance, p, null, false);
        d.Reload(NullLogger.Instance, p, null, false);
        var slns = d.Solutions(Enums.RepositoryLocal.Vs17);
        //d.Reload()
    }
}