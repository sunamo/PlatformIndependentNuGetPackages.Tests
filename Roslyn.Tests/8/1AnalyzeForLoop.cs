

// Analyzuje konstrukci for a vypíše které proměnné se zapisují v a vně for
public partial class RoslynLearn
{
    [Fact]
    public void _1AnalyzeForLoop()
    {
        var tree = CSharpSyntaxTree.ParseText(@"
        public class Sample
        {
           public void Foo()
           {
                int[] outerArray = new int[10] { 0, 1, 2, 3, 4, 0, 1, 2, 3, 4};
                for (int index = 0; index < 10; index++)
                {
                     int[] innerArray = new int[10] { 0, 1, 2, 3, 4, 0, 1, 2, 3, 4 };
                     index = index + 2;
                     outerArray[index - 1] = 5;
                }
           }
        }");

        var Mscorlib = MetadataReference.CreateFromFile(typeof(Object).Assembly.Location);

        var compilation = CSharpCompilation.Create("MyCompilation",
            syntaxTrees: new[] { tree }, references: new[] { Mscorlib });
        var model = compilation.GetSemanticModel(tree);

        var forStatement = tree.GetRoot().DescendantNodes().OfType<ForStatementSyntax>().Single();
        DataFlowAnalysis result = model.AnalyzeDataFlow(forStatement);
        ImmutableArray<ISymbol> a = result.AlwaysAssigned;
        ImmutableArray<ISymbol> b = result.ReadInside;
        ImmutableArray<ISymbol> c = result.WrittenOutside;
        ImmutableArray<ISymbol> d = result.WrittenInside;
        ImmutableArray<ISymbol> e = result.VariablesDeclared;
        /*
        The DataFlowAnalysis object exposes a pretty rich API for uses to consume. It exposes information about unsafe addresses, local variables captured by anonymous methods and much more. 
        */
        ////DebugLogger.Instance.DumpObjects("AlwaysAssigned", a, DumpProvider.Reflection, "Name");
        ////DebugLogger.Instance.DumpObjects("ReadInside", b, DumpProvider.Reflection, "Name");
        ////DebugLogger.Instance.DumpObjects("WrittenOutside", c, DumpProvider.Reflection, "Name");
        ////DebugLogger.Instance.DumpObjects("WrittenInside", d, DumpProvider.Reflection, "Name");
        ////DebugLogger.Instance.DumpObjects("VariablesDeclared", e, DumpProvider.Reflection, "Name");
    }
}
