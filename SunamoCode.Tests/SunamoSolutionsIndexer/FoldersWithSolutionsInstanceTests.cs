using SunamoDevCode.SunamoSolutionsIndexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoDevCode.Tests.SunamoSolutionsIndexer;
public class FoldersWithSolutionsInstanceTests
{
    [Fact]
    public void Reload_AllProjectFoldersIsLoaded()
    {
        FoldersWithSolutionsInstance foldersWithSolutionsInstance = new(@"E:\vs\", null);


    }
}
