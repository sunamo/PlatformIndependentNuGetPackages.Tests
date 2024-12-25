namespace SunamoDevCode.Tests.SunamoSolutionsIndexer;
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
    public void Reload_AllProjectFoldersIsLoaded()
    {
        FoldersWithSolutionsInstance foldersWithSolutionsInstance = new(NullLogger.Instance, @"E:\vs\", null);


    }
}