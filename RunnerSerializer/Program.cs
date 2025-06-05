using SunamoSerializer.Tests;

namespace RunnerSerializer;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        SFTests t = new();
        t.PrepareToSerializationTest();
    }
}
