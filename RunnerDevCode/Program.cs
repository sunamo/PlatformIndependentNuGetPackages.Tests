
namespace RunnerDevCode;
using SunamoDevCode;
using SunamoDevCode.Args;
using SunamoDevCode.SunamoCSharp;
using SunamoDevCode.Tests;
using SunamoDevCode.Tests.Helpers;

internal class Program
{
    const string pinp = @"E:\vs\Projects\PlatformIndependentNuGetPackages\";

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        //GlobalUsingsInstanceTests t = new GlobalUsingsInstanceTests();
        //await t.GlobalUsingsInstance_Test();

        TFCsFormatTests tFCsFormatTests = new TFCsFormatTests();
        await tFCsFormatTests.WriteAllLinesTest();

        //FoldersWithSolutionsInstanceTests t = new FoldersWithSolutionsInstanceTests();
        //t.ReloadTest();

        //var t = new CSharpHelperTests();
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