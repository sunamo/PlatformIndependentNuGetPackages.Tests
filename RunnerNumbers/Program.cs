using SunamoNumbers.Tests;

namespace RunnerNumbers;

internal class Program
{
    static void Main(string[] args)
    {
        NumberServiceTests t = new();
        t.ParseInterval();
    }
}
