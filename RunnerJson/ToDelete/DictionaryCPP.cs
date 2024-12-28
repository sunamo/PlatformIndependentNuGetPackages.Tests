using SunamoJson;
using SunamoJson.Args;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerJson.ToDelete;
public class DictionaryCPP : Dictionary<string, CPP>//, ISerialization2
{
    const string fileNameWithoutExt = "DictionaryCPP";
    public async Task Load()
    {

        var dict = await SerializerHelperJson.ReadFromJsonFile<DictionaryCPP>(Path, new() { TwoSingleToBackslash = true });
        foreach (var item in dict)
        {
            Add(item.Key, item.Value);
        }
    }

    public async Task Save()
    {
        var keysWithOk = this.Where(d => d.Value.allOk).Select(d => d.Key);

        foreach (var item in keysWithOk)
        {
            Remove(item);
        }

        var path = await SerializerHelperJson.WriteToJsonFile(Path, this, new WriteToJsonFileArgs { Append = false, Formatting = Newtonsoft.Json.Formatting.Indented, TwoBackslashToSingle = true });
    }

    /// <summary>
    /// radši txt než json - ten obsahuje \\ v cestách které když zkopíruji, nikde ty dvě zpětné lomítka nevezmou
    /// druhá možnost je ve vscode nastavit obsah souboru z json na txt
    /// </summary>
    public static string Path => @"D:\\OneDrive\\sunamo\\AllProjectsSearch\\Other\\DictionaryCPP.txt";
}