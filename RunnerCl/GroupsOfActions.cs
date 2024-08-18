
namespace RunnerCl;
using RunnerCl._sunamo;
using SunamoCl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static bool perform
    {
        get => CL.perform;
    }

    static async Task<Dictionary<string, object>> Dating()
    {
        var actions = DatingActions();

        if (perform)
        {
#if ASYNC
            await
#endif
            CL.PerformActionAsync(actions);
        }

        return actions;
    }

    public static Dictionary<string, object> m(Dictionary<string, Action> actions, Dictionary<string, Func<Task>> actionsAsync)
    {
        Dictionary<string, Action> actions2 = new Dictionary<string, Action>();
        Dictionary<string, Func<Task>> actionsAsync2 = new Dictionary<string, Func<Task>>();

        foreach (var item in actions)
        {
            actions2.Add(item.Key, (dynamic)item.Value);
        }

        foreach (var item in actionsAsync)
        {
            actionsAsync2.Add(item.Key, (dynamic)item.Value);
        }

        return AsyncHelper.MergeDictionaries(actions2, actionsAsync2);
    }
}