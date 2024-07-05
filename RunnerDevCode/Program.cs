namespace RunnerDevCode;

internal class Program
{
    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        GlobalUsingsInstanceTests t = new GlobalUsingsInstanceTests();
        await t.GlobalUsingsInstance_Test();
    }
}
