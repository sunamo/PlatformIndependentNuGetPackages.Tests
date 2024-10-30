
using SunamoExceptions;
using SunamoExceptions.Tests;

namespace RunnerExceptions;

internal class Program
{
    static void Main(string[] args)
    {
        ThrowExTests t = new();
        t.IsNullOrWhitespaceTest();

        Console.WriteLine("Finished");
        Console.ReadLine();
    }
}
