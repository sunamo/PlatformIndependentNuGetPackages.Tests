namespace SunamoRoslyn2.Tests;

public class UnitTest1
{
    [Fact]
    public async Task InterfaceTest()
    {
        const string input = @"namespace Test;

interface A : C
{

}

interface C
{

}";

        var interfaces = await RoslynFromFile.Interfaces(input);

        var f = interfaces.First();
        var baseType = f.BaseList;
        var baseTypeS = f.BaseList.ToString();

        var t = baseType.Types.First().Type as Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax;
        var g = t.GetType();

        var d = ((dynamic)t).Identifier.Text;
        var d2 = t.Identifier.Text;
    }

    [Fact]
    public async Task DelegatesTest()
    {
        const string input = @"public delegate void VoidBool(bool b);

public delegate void VoidBoolNullable(bool? b);";

        var delegates = await RoslynFromFile.Delegates(input);

        var f = delegates[0];
        var p = f.Modifiers;
        // tohle je důležité že funguje
        var ts = f.ToString();
        var d = f.ReturnType;
        var id = f.Identifier;
        var g = f.ParameterList;



        var serializer = new SerializerBuilder()
    .WithNamingConvention(CamelCaseNamingConvention.Instance)
    .Build();

        //await File.WriteAllTextAsync(AppDomain.CurrentDomain.BaseDirectory + "DelegatesTest.txt",

        //    //Ambiguous match found for 'Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree+ParsedSyntaxTree Microsoft.CodeAnalysis.CSharp.CSharpParseOptions Options'.
        //    //serializer.Serialize(delegates)

        //    //    JsonConvert.SerializeObject(delegates, Formatting.Indented, new JsonSerializerSettings
        //    //{
        //    //    //ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        //    //    PreserveReferencesHandling = PreserveReferencesHandling.Objects
        //    //})

        //    //The type 'System.ReadOnlySpan`1[System.Byte]' of property 'Preamble' on type 'System.Text.Encoding' is invalid for serialization or deserialization because it is a pointer type, is a ref struct, or contains generic parameters that have not been replaced by specific types.
        //    //System.Text.Json.JsonSerializer.Serialize(delegates)
        //    );
    }
}
