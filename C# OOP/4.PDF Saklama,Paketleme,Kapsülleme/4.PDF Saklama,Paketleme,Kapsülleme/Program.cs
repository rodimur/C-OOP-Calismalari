using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PDF_Saklama_Paketleme_Kapsülleme
{
    class oyuncu
    {
        private string ad;
        private string mevki;
        private int savunma;
        private int atak;
        private int topSurme;
        private double deger;
        

        public void setAd(string adi)//yapıcının tek farkı setad yerine class ın ismini veriyosun 
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
        public void calis(string konu)//burası private değeri metod ile değiştirme
        {
            if (konu == "savunma") savunma += 1;
            if (konu == "atak") atak += 1;
            if (konu == "topSurme") savunma += 1;
            degerBelirle();
        }
        public void degerBelirle()
        {
            deger = savunma * 0.3 + atak * 0.4 + topSurme * 0.5;

        }

        public double getDeger ()
        {
            return deger;
        }
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



















