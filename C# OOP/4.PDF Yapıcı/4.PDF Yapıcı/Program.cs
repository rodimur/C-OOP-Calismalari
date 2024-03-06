using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PDF_Yapıcı
{
    class oyuncu
    {
        private string ad;
        private string mevki;
        private int savunma;
        private int atak;
        private int topSurme;
        private double deger;


        public void setAd(string adi)
        {
            ad = adi;
        }
        public void setMevki(string mevkisi)
        {
            mevki = mevkisi;
        }
        public void setYetenek(int sav, int atk, int ts)
        {
            savunma = sav;
            atak = atk;
            topSurme = ts;
            degerBelirle();
        }
        public void calis(string konu)
        {
            if (konu == "savunma") savunma += 1;
            if (konu == "atak") atak += 1;
            if (konu == "topSurme") savunma += 1;
            degerBelirle();
        }

        #region metotlar
        #endregion
    }

    class Futbol
    {
        static void Main(string[] args)
        {
            oyuncu oyuncu1 = new oyuncu(); //1.nesne üretiliyor
            oyuncu oyuncu2 = new oyuncu(); //2.nesne üretiliyor

            oyuncu1.setAd("Emir");
            oyuncu1.setMevki("Santrafor");
            oyuncu1.setYetenek(45, 79, 81);

            oyuncu2.setAd("Kerem");
            oyuncu2.setMevki("Stoper");
            oyuncu2.setYetenek(85, 59, 55);

            Console.WriteLine("Oyuncu degeri:" + oyuncu1.getDeger() + " M$");
            oyuncu1.calis("atak");

            Console.WriteLine("Oyuncu degeri:" + oyuncu1.getDeger() + " M$");

            Console.ReadKey();

        }
    }
}
