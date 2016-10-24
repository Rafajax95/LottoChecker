using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Lotto_Checker
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] yellowball;   // wyniki losowanie lotto
        int[] blueball;     // wyniki losowania lotto+
        string date;        // data losowania
        Zaklady zaklady;    // obiekt zakladow przechowujacy liste zakladow czyli liste tablic typowanych liczb


        private void Form1_Load(object sender, EventArgs e)
        {

            zaklady = Zaklady.wczytaj_zaklady(); //wczytanie zapisanych zakladow uzytkownika
            foreach (Zaklad zaklad in zaklady.Myzaklady) zakladyCLB.Items.Add(zaklad.Zakladstr); //wrzucenie listy do checkedlistboxa


        }

        private void downloadBT_Click(object sender, EventArgs e)//pobranie wynikow losowan z internetu
        {
            if (!backgroundWorker1.IsBusy) //zabezpiecza przed wyjatkiem wystepujacym przy podwojnym kliknieciu na przycisk
            {
                infoLB1.Text = "Czekaj...";
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void zatwierdzBT_Click(object sender, EventArgs e)//zapisanie do yellowball i blueball/mozliwe gdy blad pobrania z internetu)
        {

            if (wynikiMSK.MaskCompleted && wynikiplusMSK.MaskCompleted)
            {
                yellowball = new int[6];
                blueball = new int[6];
                infoLB1.Text = "";
                zatwierdzBT.Visible = false;
                string bufor1 = wynikiMSK.Text;
                string bufor2 = wynikiplusMSK.Text;
                for (int i = 0; i < 6; i++)
                {
                    yellowball[i] = int.Parse(bufor1.Substring(i * 3, 2));
                    blueball[i] = int.Parse(bufor2.Substring(i * 3, 2));
                }
                infoLB1.Text = "Zatwierdzono liczby!";
            }
            else infoLB1.Text = "Wypełnij strukture!";

        }

        private void dodajzakladBT_Click(object sender, EventArgs e) //wyswietla zestaw do wprowadzenia nowego zakladu uzytkownika
        {
            dodajBT.Visible = true;
            nowyzakladMSK.Visible = true;
            cofnijBT.Visible = true;
        }

        private void sprawdzzaznaczoneBT_Click(object sender, EventArgs e)//wykonuje sprawdzenie czy nastapila wygrana
        {
            wynikiTB.Text = "";
            try
            {
                int lbiteracji = zakladyCLB.CheckedItems.Count;
                int[] cowlotku = new int[lbiteracji];
                int[] cowlotkuplus = new int[lbiteracji];


                for (int j = 0; j < lbiteracji; j++)
                {
                    for (int i = 0; i < zaklady.Myzaklady.Count; i++)
                    {
                        if (zakladyCLB.CheckedItems.Count <= 0) break;
                        if (zaklady.Myzaklady[i].Zakladstr == zakladyCLB.CheckedItems[0].ToString())
                        {
                            zakladyCLB.SetItemChecked(zakladyCLB.Items.IndexOf(zakladyCLB.CheckedItems[0]), false);
                            cowlotku[j] = Zaklady.porownaj(zaklady.Myzaklady[i].Typy, yellowball);
                            cowlotkuplus[j] = Zaklady.porownaj(zaklady.Myzaklady[i].Typy, blueball);
                            if (cowlotku[j] >= 0)
                            {
                                wynikiTB.Text += ("W zestawie " + zaklady.Myzaklady[i].Zakladstr + " masz " + cowlotku[j] + " w lotto." + "\n");
                            }
                            if (cowlotkuplus[j] >= 0)
                            {
                                wynikiTB.Text += ("W zestawie " + zaklady.Myzaklady[i].Zakladstr + " masz " + cowlotkuplus[j] + " w lotto+." + "\n");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void usunzaznaczoneBT_Click(object sender, EventArgs e)//usuwa zaznaczone zaklady z checkedlistboxa
        {
            if (zakladyCLB.CheckedItems.Count > 0)
            {
                int lbiteracji = zakladyCLB.CheckedItems.Count;
                for (int j = 0; j < lbiteracji; j++)
                {
                    for (int i = 0; i < zaklady.Myzaklady.Count; i++)
                    {
                        if (zaklady.Myzaklady[i].Zakladstr == zakladyCLB.CheckedItems[0].ToString())
                        {
                            zaklady.Myzaklady.RemoveAt(i);
                            break;
                        }
                    }

                    zakladyCLB.Items.Remove(zakladyCLB.CheckedItems[0]);
                    Zaklady.zapisz_zaklady(zaklady);
                }

            }


        }

        private void dodajBT_Click(object sender, EventArgs e)//dodaje nowy zaklad z formularza wyswietlanego przez dodajzakladBT
        {
            if (nowyzakladMSK.MaskCompleted)
            {
                Zaklad bufor = new Zaklad(nowyzakladMSK.Text);
                bool rob = true;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = i + 1; j < 6; j++)
                    {
                        if (bufor.Typy[i] == bufor.Typy[j])
                        {
                            rob = false;
                            infoLB3.Text = "Powtórzenie w liczbach!";
                            break;
                        }
                    }


                }
                if (rob == true)
                {
                    zaklady.Myzaklady.Add(bufor);
                    nowyzakladMSK.Visible = false;
                    dodajBT.Visible = false;
                    cofnijBT.Visible = false;
                    zakladyCLB.Items.Add(nowyzakladMSK.Text);
                    Zaklady.zapisz_zaklady(zaklady);
                    infoLB3.Text = "";
                    nowyzakladMSK.Text = "";
                }

            }
            else
            {
                infoLB3.Text = "Wypełnij całą strukturę lub cofnij dodawanie!";
            }
        }

        private void cofnijBT_Click(object sender, EventArgs e)//zamyka formularz wywolywany przez dodajzakladBT bez wprowadzenia zmian
        {
            infoLB3.Text = "";
            dodajBT.Visible = false;
            nowyzakladMSK.Visible = false;
            cofnijBT.Visible = false;
            nowyzakladMSK.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Zaklady.zapisz_zaklady(zaklady);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)//asynchroniczne pobranie informacji z internetu
        {
            try
            {
                Get_lotto.get_lotto(ref yellowball, ref blueball, ref date); //pobranie informacji o losowaniu z internetu
            }
            catch
            {
                //problemy wylapane beda w bloku try w metodzie RunWorkerCopleted
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)//obsluga pobranych danych
        {
            infoLB1.Text = "";
            zatwierdzBT.Visible = false;

            try
            {

                string bufor = "";

                foreach (int ball in yellowball)
                {
                    if (ball < 10) bufor += "0" + ball.ToString();
                    else bufor += ball.ToString();

                }
                wynikiMSK.Text = bufor;
                bufor = "";

                foreach (int ball in blueball)
                {
                    if (ball < 10) bufor += "0" + ball.ToString();
                    else bufor += ball.ToString();
                }
                wynikiplusMSK.Text = bufor;
                infoLB1.Text = "Data: " + date;
            }
            catch
            {
                infoLB1.Text = "Błąd pobierania! Spróbuj ponownie lub wprowadź wyniki ręcznie!";
                zatwierdzBT.Visible = true;
            }
        }

      

     
    }
}





