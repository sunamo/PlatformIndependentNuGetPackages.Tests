namespace RunnerCsproj;
using SunamoCsproj.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        CsprojInstanceTests d = new();
        //d.PropertyGroupItemContentTest();
        //d.AddRemoveNoWarnTest2();

        //d.AddRemoveNoWarnTestWorker(@"E:\vs\Projects\LearnCsharp\LearnSwagger\LearnSwagger.csproj");

        var item = @"E:\vs\Projects\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj";
        var cs = new SunamoCsproj.CsprojInstance(item);

        cs.AddRemoveDefineConstant(false, "CA1822");

        cs.Save();
    }
}