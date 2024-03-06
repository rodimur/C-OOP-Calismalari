using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PDF_Özellik_Metotları
{
    class oyuncu
    {
        private string ad;
        private string mevki;
        private int savunma;
        private int atak;
        private int topSurme;
        private double deger;


        public oyuncu(string adi, string mevkisi)
        {
            ad = adi;
            mevki = mevkisi;
        }

        public int Atak //Burası property metodu. Parantez kullanılmaz

        {
            set
            {
                if (value < 25)
                    atak = 25;
                else 
                    atak = value;
                degerBelirle();
            }
            get
            {
                return atak;
            }
        }
        public void setYetenek(int sav , int atk, int ts)
        {
            savunma = sav;
            atak = atk;
            topSurme = ts;
            degerBelirle();
        }
    }

    class Futbol
    {
        static void Main(string[] args)
        {
            oyuncu oyuncu1 = new oyuncu("Emir", "Santrafor");
            oyuncu1.setYetenek(45, 79, 81);
            Console.WriteLine("Oyuncu atak yeteneği" + oyuncu1.Atak);

            Console.WriteLine("Atak Değeri Girin:");
            int atk = int.Parse(Console.ReadLine());//burası farklı
            oyuncu1.Atak = atk;
            Console.WriteLine("Oyuncu atak yeteneği :" + oyuncu1.Atak);

            Console.ReadKey();
        }
    }
}
