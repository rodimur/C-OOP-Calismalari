using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme1
{
    class oyuncu
    {
        public string ad;
        public string mevki;
        public int savunma;
        public int atak;
        public int topSurme;
        public double deger;

    }

    class Futbol
    {
        static void Main(string[] args)
        {
            oyuncu oyuncu1 = new oyuncu();//1. nesne üretiliyor
            oyuncu oyuncu2 = new oyuncu(); //2. nesne üretiliyor

            // 1. nesne özellikleri giriliyor
            oyuncu1.ad = "Emir";
            oyuncu1.mevki = "Santrafor";
            oyuncu1.savunma = 45;
            oyuncu1.atak = 79;
            oyuncu1.topSurme = 81;

            // 2.nesne özellikleri girliyor
            oyuncu2.ad = "Kerem";
            oyuncu2.mevki = "Stoper";
            oyuncu2.savunma = 85;
            oyuncu2.atak = 59;
            oyuncu2.topSurme = 55;


            // nesnelerden özellik değerleri okunup ortalama hesaplanıyor
            Console.WriteLine("Oyuncuların ortalama top sürme kabiliyeti" + (oyuncu1.topSurme + oyuncu2.topSurme) / 2);
            Console.ReadKey();
        }


    }

}
