using RunnerJson.ToDelete;

namespace RunnerJson;

internal class Program
{

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        DictionaryCPP d = new DictionaryCPP();
        await d.Load();

        Console.WriteLine("Hello, World!");
    }
}
