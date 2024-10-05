
namespace RunnerCl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    private static void AddToAllActions(string v, Dictionary<string, Action> actions, Dictionary<string, Func<Task>> actionsAsync)
    {
        Dictionary<string, Action> actions2 = new Dictionary<string, Action>();
        Dictionary<string, Func<Task>> actionsAsync2 = new Dictionary<string, Func<Task>>();

        foreach (var item in actions)
        {
            actions2.Add(item.Key, (Action)(dynamic)item.Value);
        }

        foreach (var item in actionsAsync)
        {
            actionsAsync2.Add(item.Key, (Func<Task>)(dynamic)item.Value);
        }

        p.AddToAllActions(v, actions2, actionsAsync2);
    }

    static Dictionary<string, object> DatingActions()
    {
        Dictionary<string, Action> actions = new Dictionary<string, Action>();
        Dictionary<string, Func<Task>> actionsAsync = new Dictionary<string, Func<Task>>();
        actions.Add("None", delegate { });
        actions.Add("Executables of all browsers", WriteTest);
        actions.Add("Test Test1 Test2 (search list)", WriteTest);
        actions.Add("TestTest2Host", WriteTest);

        // Už nebude potřeba. v AskUser mi to získá znovu actions a actionsAsync dle typů ve value
        //AddToAllActions("Dating", actions, actionsAsync);
        return m(actions, actionsAsync);
    }

    static void WriteTest()
    {
        Console.WriteLine("Test!");
    }
}