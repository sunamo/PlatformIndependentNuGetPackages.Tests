namespace RunnerRoslyn;
using SunamoRoslyn.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        RoslynCommentServiceTests t = new();
        t.RemoveCommentsTest();
    }
}