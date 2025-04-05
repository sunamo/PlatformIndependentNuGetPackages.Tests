using SunamoDateTime.Tests;

namespace RunnerDateTime;

internal class Program
{
    static void Main(string[] args)
    {
        DTHelperGeneralTests t = new DTHelperGeneralTests();
        t.WeekOfYearFromDateTest();
    }
}
