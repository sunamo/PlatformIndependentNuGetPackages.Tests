
namespace RunnerDevCode;

using SunamoDevCode;
using SunamoDevCode.Args;
using SunamoDevCode.SunamoCSharp;
using SunamoDevCode.Tests;
using SunamoDevCode.Tests.Helpers;
using SunamoDevCode.Tests.Services;
using SunamoDevCode.Tests.SunamoSolutionsIndexer;
using SunamoDevCode.Tests.SunamoSolutionsIndexer.Data.SolutionFolderNs;

internal class Program
{
    const string pinp = @"E:\vs\Projects\PlatformIndependentNuGetPackages\";

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        await Task.Delay(1);

        //GlobalUsingsInstanceTests t = new GlobalUsingsInstanceTests();
        //await t.GlobalUsingsInstance_Test();

        //TFCsFormatTests tFCsFormatTests = new TFCsFormatTests();
        //await tFCsFormatTests.WriteAllLinesTest2();

        //FoldersWithSolutionsTests foldersWithSolutionsInstanceTests = new();
        //foldersWithSolutionsInstanceTests.ReloadTest();

        //AddOrEditNamespaceServiceTests t = new AddOrEditNamespaceServiceTests();
        //await t.AddOrEditNamespaceForSingleFileAndSaveTest();

        //FoldersWithSolutionsTests t = new FoldersWithSolutionsTests();
        //t.ReloadTest();
        //t.InsertIntoFwssTest();

        //SolutionFolderTests t = new();
        //t.ExeToReleaseTest();

        var t = new CSharpHelperTests();
        t.RemoveCommentsKeepLinesTest();
        //await t.IsEmptyCommentedOrOnlyWithNamespaceTest();

        //var d = FSGetFilesDC.GetFilesDC(pinp, "XlfKeys.cs", SearchOption.AllDirectories, new GetFilesDCArgs { OnlyIn_Sunamo = true });

        //foreach (var item in d)
        //{
        //    var l = (await File.ReadAllLinesAsync(item)).ToList();
        //    CSharpHelper.SetValuesAsNamesToConsts(l);
        //    await File.WriteAllLinesAsync(item, l);
        //}
    }
}