namespace RunnerCsproj;

internal class Program
{
    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        CsprojHelperTests d = new CsprojHelperTests();
        await d.PropertyGroupItemContentTest();
    }
}
