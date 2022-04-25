using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using burger;

namespace burger
{
    public class metot
    {
        public static int kaçGünYaşamış(DateTime girdi)
        {
            return Convert.ToInt32((DateTime.Today - girdi).TotalDays);
        }

        public static string burçBul(DateTime doğumtarihi)
        {
            string sonuc = "";
            if ((doğumtarihi.Month == 1 && doğumtarihi.Day >= 21) || (doğumtarihi.Month == 2 && doğumtarihi.Day <= 18))
            {
                sonuc = "Kova";
            }
            else if (doğumtarihi.Month == 2 && doğumtarihi.Day >= 19 || doğumtarihi.Month == 3 && doğumtarihi.Day <= 20)
            {
                sonuc = "Balık";
            }
            else if (doğumtarihi.Month == 3 && doğumtarihi.Day >= 21 || doğumtarihi.Month == 4 && doğumtarihi.Day <= 20)
            {
                sonuc = "Koç";
            }
            else if ((doğumtarihi.Month == 4 && doğumtarihi.Day >= 21) || (doğumtarihi.Month == 5 && doğumtarihi.Day <= 20))
            {
                sonuc = "Boğa";
            }
            else if ((doğumtarihi.Month == 5 && doğumtarihi.Day >= 21) || (doğumtarihi.Month == 6 && doğumtarihi.Day <= 21))
            {
                sonuc = "İkizler";
            }
            else if ((doğumtarihi.Month == 6 && doğumtarihi.Day >= 22) || (doğumtarihi.Month == 7 && doğumtarihi.Day <= 22))
            {
                sonuc = "Yengeç";
            }
            else if ((doğumtarihi.Month == 7 && doğumtarihi.Day >= 23) || (doğumtarihi.Month == 8 && doğumtarihi.Day <= 22))
            {
                sonuc = "Aslan";
            }
            else if ((doğumtarihi.Month == 8 && doğumtarihi.Day >= 23) || (doğumtarihi.Month == 9 && doğumtarihi.Day <= 22))
            {
                sonuc = "Başak";
            }
            else if ((doğumtarihi.Month == 9 && doğumtarihi.Day >= 23) || (doğumtarihi.Month == 10 && doğumtarihi.Day <= 23))
            {
                sonuc = "Terazi";
            }
            else if ((doğumtarihi.Month == 10 && doğumtarihi.Day >= 24) || (doğumtarihi.Month == 11 && doğumtarihi.Day <= 22))
            {
                sonuc = "Akrep";
            }
            else if ((doğumtarihi.Month == 11 && doğumtarihi.Day >= 23) || (doğumtarihi.Month == 12 && doğumtarihi.Day <= 21))
            {
                sonuc = "Yay";
            }
            else
            {
                sonuc = "Oğlak";
            }

            return sonuc;
        }
        public static double ibs(int kilo)
        {
            double sonuc = 0;
            double ibs = 2.222;
            sonuc = kilo * ibs;
            return sonuc;
        }
        public static double inç(int boy)
        {
            double sonuc = 0;
            double inç = 0.393700787;
            sonuc = boy * inç;
            return sonuc;

        }


        public static string vücutDurumu(decimal kitleendeksi)
        {
            string sonuc = "";
            if (kitleendeksi < 18.5m)
            {
                sonuc = "Zayıf";
            }
            else if (kitleendeksi<24.9m)
            {
                sonuc = "Normal Kilolu";
            }
            else if (kitleendeksi<29.9m)
            {
                sonuc = "Fazla Kilolu";
            }
            else if (kitleendeksi<34.9m)
            {
                sonuc = "1. Derece Obezite";
            }
            else if (kitleendeksi < 40m)
            {
                sonuc = "2. Derece Obezite";
            }
            else if (kitleendeksi < 50m)
            {
                sonuc = "3. Derece Obezite";
            }
            else if (kitleendeksi<60m)
            {
                sonuc = "Süper Obezite";
            }
            else
            {
                sonuc = "Süper Süper Obezite";
            }
            return sonuc;

        }


        public static string kanBağış(string kangrubu)
        {
            string sonuc = "";
            if (kangrubu == "A")
            {
                sonuc = "A ve 0 grupları kan verebilir.";
            }
            else if (kangrubu=="B")
            {
                sonuc = "B ve 0 grupları kan verebilir.";
            }
            else if (kangrubu == "0")
            {
                sonuc = "sadece 0 grupları kan verebilir.";
            }
            else
            {
                sonuc = "Tüm gruplar kan verebilir.";
            }
            return sonuc;
        }
        //public static List<string> kanBağış(string kangrubu)
        //{
        //   
        //    foreach ( item in collection)
        //    {

        //    }
        //    if (kangrubu=="A")
        //    {
        //        sonuc.Add()
        //    }
        //}

        //METHOD OVERLOAD

        public static int Toplama(params int[] sayılar)  // parametreleri çoklamak için kullanılır. Bu sadece intler içindir.
        {
            int Toplam = 0;
            foreach (int sayı in sayılar)
            {
                Toplam += sayı;
            }
            return Toplam;
        }
        public static Object Toplama(params Object[] sayılar)  // parametreleri çoklamak için kullanılır. Bu her tür için kullanılabilir. 
        {
            double Toplam = 0;
            foreach (var sayı in sayılar)
            {
                Toplam +=Convert.ToInt32( sayı);
            }
            return Toplam;
        }


    }
}