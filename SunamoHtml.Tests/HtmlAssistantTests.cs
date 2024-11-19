using SunamoHtml.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoHtml.Tests;
public class HtmlAssistantTests
{
    [Fact]
    public void InnerTextDecodeTrimTest()
    {
        var d = HtmlAssistant.InnerTextDecodeTrim("chaty/chalupy 66 m² s pozemkem 1 489 m²");
    }
}
