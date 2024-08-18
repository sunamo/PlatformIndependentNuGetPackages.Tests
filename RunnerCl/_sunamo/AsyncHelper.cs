
namespace RunnerCl._sunamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class AsyncHelper
{
    public static Dictionary<string, object> MergeDictionaries(Dictionary<string, Action> potentiallyValid, Dictionary<string, Func<Task>> potentiallyValidAsync)
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>(potentiallyValid.Count + potentiallyValidAsync.Count);
        if (potentiallyValid != null)
        {
            foreach (KeyValuePair<string, Action> item in potentiallyValid)
            {
                dictionary.Add(item.Key, item.Value);
            }
        }

        if (potentiallyValidAsync != null)
        {
            foreach (KeyValuePair<string, Func<Task>> item2 in potentiallyValidAsync)
            {
                dictionary.Add(item2.Key, item2.Value);
            }
        }

        return dictionary;
    }

}