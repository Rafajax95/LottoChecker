using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Lotto_Checker
{
    static class Get_lotto
    {
        static private HtmlWeb web;
        static private HtmlAgilityPack.HtmlDocument document;

        public static void get_lotto(ref int[] yellowball, ref int[] blueball, ref string date)
        {
            web = new HtmlWeb();
            document = web.Load("http://www.lotto.pl/lotto/wyniki-i-wygrane/ostatnie-wyniki");
            string data = document.DocumentNode.OuterHtml;
            int[] yellowpos = new int[6];
            int[] bluepos = new int[6];
            int datepos = data.IndexOf("</td><td>") + 22;
            date = data.Substring(datepos, 20);
            date = date.Remove(date.IndexOf("<"));

            yellowball = new int[6];
            blueball = new int[6];
            int lotto_pos = data.IndexOf("sortrosnaco");
            int plus_pos = data.IndexOf("lottoPlus sortrosnaco");

            for (int i = 0; i < 6; i++)
            {
                yellowpos[i] = data.IndexOf("<span>", lotto_pos) +6;
                lotto_pos = yellowpos[i] + 1;
                bluepos[i] = data.IndexOf("<span>", plus_pos) +6;
                plus_pos = bluepos[i] + 1;
            }



            for (int i = 0; i < 6; i++)
            {
                try
                {
                    yellowball[i] = int.Parse(data[yellowpos[i]].ToString() + data[yellowpos[i] + 1].ToString());
                }
                catch
                {

                    yellowball[i] = int.Parse(data[yellowpos[i]].ToString());
                }
                try
                {
                    blueball[i] = int.Parse(data[bluepos[i]].ToString() + data[bluepos[i] + 1].ToString());
                }
                catch
                {
                    blueball[i] = int.Parse(data[bluepos[i]].ToString());
                }

            }
        }
    }
}
