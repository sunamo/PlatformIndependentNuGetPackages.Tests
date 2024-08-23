

public partial class RoslynLearn
{

    /*
    csc /r:"E:\vs\Projects\PlatformIndependentNuGetPackages\dll\netstandard.dll" /r:"E:\vs\Projects\PlatformIndependentNuGetPackages\dll\System.Runtime.dll" /r:"E:\vs\Projects\PlatformIndependentNuGetPackages\dll\Microsoft.CodeAnalysis.dll" /r:"E:\vs\Projects\PlatformIndependentNuGetPackages\dll\Microsoft.CodeAnalysis.CSharp.dll" /out:roslyn.dll 1CreateRoslynSyntaxTree.cs
    */



    [Fact]
    public void _1CreateRoslynSyntaxTree()
    {
        var tree = CSharpSyntaxTree.ParseText(@"
            public class MyClass
            {
                public void MyMethod()
                {
                }
            }");

        var syntaxRoot = tree.GetRoot();
        var MyClass = syntaxRoot.DescendantNodes().OfType<ClassDeclarationSyntax>().First();
        var MyMethod = syntaxRoot.DescendantNodes().OfType<MethodDeclarationSyntax>().First();

        ////DebugLogger.Instance.WriteLine(MyClass.Identifier.ToString());
        ////DebugLogger.Instance.WriteLine(MyMethod.Identifier.ToString());
    }


}
