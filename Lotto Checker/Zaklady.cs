using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_Checker
{
    class Zaklady
    {
        private List<Zaklad> myzaklady;



        public Zaklady(List<Zaklad> myzaklady)
        {
            this.Myzaklady = myzaklady;
        }

        public List<Zaklad> Myzaklady
        {
            get
            {
                return myzaklady;
            }

            set
            {
                myzaklady = value;
            }
        }

        public static Zaklady wczytaj_zaklady()
        {
            List<Zaklad> bufor1 = new List<Zaklad>();
            FileStream fs = new FileStream("zaklady.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                bufor1.Add(new Zaklad(sr.ReadLine()));
            }
            sr.Close();
            return new Zaklady(bufor1);
        }

        public static void zapisz_zaklady(Zaklady zaklady)
        {
            FileStream fs = new FileStream("zaklady.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Zaklad zaklad in zaklady.Myzaklady) sw.WriteLine(zaklad.Zakladstr);
            sw.Close();
        }

       public static int porownaj(int[] tablica1, int[] tablica2)
        {

            int takiesame = 0;
            foreach (int wart1 in tablica1)
            {
                foreach (int wart2 in tablica2)
                {
                    if (wart1 == wart2) takiesame++;
                }
            }

            return takiesame;
        }
    }
}
