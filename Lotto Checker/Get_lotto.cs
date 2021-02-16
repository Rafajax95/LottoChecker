using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Lotto_Checker
{
    static class Get_lotto
    {
        static private HtmlWeb web;
        static private HtmlAgilityPack.HtmlDocument document;

		static private string yellowBallsXPath = @"(//div[@class='recent-result-item Lotto'])[1]//div[@class='scoreline-item circle']";
		static private string blueBallsXPath = @"(//div[@class='recent-result-item LottoPlus'])[1]//div[@class='scoreline-item circle']";

		public static void get_lotto(ref int[] yellowball, ref int[] blueball, ref string date)
		{
			web = new HtmlWeb();
			document = web.Load("http://www.lotto.pl/lotto/wyniki-i-wygrane/ostatnie-wyniki");
			yellowball = ExtractBallsFromGivenXPath(yellowBallsXPath).ToArray();
			blueball = ExtractBallsFromGivenXPath(blueBallsXPath).ToArray();
			date = document.DocumentNode.SelectSingleNode("(//div[@class='game-main-header'])[1]//p[@class='sg__desc-title']").InnerText;
		}

		private static List<int> ExtractBallsFromGivenXPath(string xpath)
		{
			return document
				.DocumentNode
				.SelectNodes(xpath)
				.Select(x => x.InnerText)
				.Select(x => Regex.Match(x, @"\d+"))
				.Select(x => int.Parse(x.Value))
				.ToList();
		}
	}
}
