using SunamoHtml.Html;
using System.Text;
using TextCopy;

namespace SunamoHtml.Tests;

public class HtmlAgilityHelperTests
{
    [Fact]
    public void PairsDdDtTest()
    {
        var input = @"<div class=""b-definition-columns mb-0"">
			<dl>
	<dt>Číslo zakázky</dt>
	<dd>IDNES-01994</dd>
	<dt>Cena</dt>
	<dd>
		4 700 000 Kč
				<a href=""http://www.finmarket.cz/hypoteky/srovnani/?utm_source=reality.idnes&amp;utm_medium=text&amp;utm_campaign=hypoteka&amp;realty_value=4700000"" target=""_blank"" id=""kalkulacka-button-atribut"" rel=""nofollow"" class=""b-detail__mortgage font-sm no-print"" data-hypobrand=""Partners"">
					
			<span class=""icon icon--calculator color-blue"">
				<svg class=""icon__svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
					<use xlink:href=""/ui/image/extend/icons/icons.svg#icon-calculator"" x=""0"" y=""0"" width=""100%"" height=""100%""></use>
				</svg>
			</span>
		
					Spočítat hypotéku
				</a>
	</dd>




				

					<dt>Konstrukce budovy</dt>
					<dd>cihlová</dd>

					<dt>Stav budovy</dt>
					<dd>dobrý stav</dd>


					<dt>Poloha domu</dt>
					<dd>samostatný</dd>






					<dt>Plocha pozemku</dt>
					<dd>281 m<sup>2</sup></dd>


					<dt>Užitná plocha</dt>
					<dd>63 m<sup>2</sup></dd>

					<dt>Plocha zahrady</dt>
					<dd>163 m<sup>2</sup></dd>




					<dt>Sklep</dt>
					<dd>
			<span class=""icon icon--check"">
				<svg class=""icon__svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
					<use xlink:href=""/ui/image/extend/icons/icons.svg#icon-check"" x=""0"" y=""0"" width=""100%"" height=""100%""></use>
				</svg>
			</span>
		</dd>





					<dt>Parkování</dt>
					<dd>parkování na ulici</dd>





					<dt>Plyn</dt>
					<dd>zaveden</dd>

					<dt>Topení</dt>
					<dd>ústřední - elektrické</dd>

					<dt>Elektřina</dt>
					<dd>230V, zavedena</dd>

					<dt>Voda</dt>
					<dd>veřejný</dd>

					<dt>Odpad</dt>
					<dd>veřejná kanalizace</dd>

					<dt>Vybavení domu</dt>
					<dd>částečně zařízený</dd>





					<dt>PENB</dt>
						<dd>G</dd>






			</dl>

</div>";


        var hd = HtmlAgilityHelper.CreateHtmlDocument();
        hd.LoadHtml(input);

        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("<span class=\"icon icon--check\">", "✓");

        var pairs = HtmlAgilityHelper.PairsDdDt(hd.DocumentNode, true, dict);
    }

    [Fact]
    public async Task NodesWithAttrTest()
    {
        var d = await File.ReadAllTextAsync(@"D:\_Test\PlatformIndependentNuGetPackages\SunamoHtml\NodesWithAttrTest.html");

        var hd = HtmlAgilityHelper.CreateHtmlDocument();
        hd.LoadHtml(d);

        var c_products__list = HtmlAgilityHelper.NodeWithAttr(hd.DocumentNode, true, "div", "class", "c-products__list grid");

        var grid__cells = HtmlAgilityHelper.NodesWithAttr(c_products__list, false, "div", "class", "grid__cell", true);

        Assert.Equal(23, grid__cells.Count);
    }

    [Fact]
    public void Test1()
    {
        var hd = HtmlAgilityHelper.CreateHtmlDocument();
        //hd.Load(@"D:\_Test\PlatformIndependentNuGetPackages\SunamoHtml\a.html");
        hd.Load(@"E:\vs\Projects\_tests\CompareTwoFiles\CompareTwoFiles\html\2.html");

        var adsParent = hd.DocumentNode.FirstChild; //HtmlAgilityHelper.NodeWithAttr(hd.DocumentNode, true, "div", "class", "row inzlist");



        var ads = HtmlAgilityHelper.NodesWithAttr(adsParent, false, "div", "class", "col-xs-12", false);

        List<string> s = new();
        StringBuilder sb = new();

        var i = 0;
        foreach (var item in ads)
        {
            var wrapperInz = HtmlAgilityHelper.NodeWithAttr(item, false, "div", "class", "poh0", true);

            if (wrapperInz == null)
            {
                Console.WriteLine("wrapperInz == null");
                continue;
            }

            var button = HtmlAgilityHelper.NodeWithAttr(wrapperInz, true, "div", "class", "inz-but clearfix", false);
            var anchor = HtmlAgilityHelper.Node(button, true, "a");

            if (anchor == null)
            {
                Console.WriteLine("Ad was skipped");
                // zatím nevím proč se tak děje
                continue;
            }

            var hrefUserDetail = "https://www.seznamka.cz" + HtmlAssistant.GetValueOfAttribute("href", anchor).TrimStart('.');


            s.Add(hrefUserDetail);
            sb.AppendLine(hrefUserDetail);
            i++;
        }

        ClipboardService.SetText(sb.ToString());
    }
}