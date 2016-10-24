using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_Checker
{
    class Zaklad
    {
        static int zakladyLP = 0;
        private int zakladNR;
        private int[] typy;
        private string zakladstr;

        public int[] Typy
        {
            get
            {
                return typy;
            }

            set
            {
                typy = value;
            }
        }

        public int ZakladNR
        {
            get
            {
                return zakladNR;
            }

            set
            {
                zakladNR = value;
            }
        }

        public static int ZakladyLP
        {
            get
            {
                return zakladyLP;
            }

            set
            {
                zakladyLP = value;
            }
        }

        public string Zakladstr
        {
            get
            {
                return zakladstr;
            }

            set
            {
                zakladstr = value;
            }
        }

        public Zaklad(string zaklad)
        {
            typy = new int[6];
            ZakladyLP++;
            ZakladNR = ZakladyLP;
            this.Zakladstr = zaklad;
            for(int i=0;i<6;i++)
            {
                typy[i] = int.Parse(zaklad.Substring(i * 3, 2));
            }
        }

    }
}
