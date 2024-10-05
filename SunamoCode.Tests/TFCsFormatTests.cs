using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoDevCode.Tests;
public class TFCsFormatTests
{
    [Fact]
    public async Task WriteAllLinesTest()
    {
        const string path = @"E:\vs\Projects\LearnOcelot\Ocelot\samples\Administration\Program.cs";
        var l = await File.ReadAllLinesAsync(path);
        await TFCsFormat.WriteAllLines(path, l);


    }
}
