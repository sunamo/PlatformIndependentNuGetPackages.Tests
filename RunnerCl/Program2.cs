using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerCl;
partial class Program
{
    public static Task ProgramSharedCreatePathToFiles(Func<string, string, string> getFile)
    {
        return Task.CompletedTask;
    }

    static string GetFileString(string a, string b)
    {
        return "";
    }

    private static Dictionary<string, Func<Task<Dictionary<string, object>>>> AddGroupOfActions()
    {
        Dictionary<string, Func<Task<Dictionary<string, object>>>> groupsOfActions = new()
        {
            { "Dating", Dating }
        };

        return groupsOfActions;
    }
}
