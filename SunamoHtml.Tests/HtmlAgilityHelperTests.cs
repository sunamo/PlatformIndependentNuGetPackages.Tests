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
}