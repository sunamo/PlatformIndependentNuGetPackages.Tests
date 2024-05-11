

using Xunit;

namespace SunamoDevCode.Tests;

public class CSharpGeneratorTests
{
    [Fact]
    public void XmlDocSummaryTest()
    {
        CSharpGenerator csg = new CSharpGenerator();
        csg.xmlDoc.SummaryStart();
        csg.xmlDoc.Raw("ABC" + Environment.NewLine + "DEF");
        csg.xmlDoc.SummaryEnd();
        var ts = csg.ToString();
    }
}
