
using SunamoExceptions;

namespace RunnerExceptions;

internal class Program
{
    static void Main(string[] args)
    {
        AAA();

    }

    private static void AAA()
    {
        ThrowEx.Custom("Něco se posralo");
    }
}
