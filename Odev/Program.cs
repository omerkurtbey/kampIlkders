   using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "big size jeans";
            urun1.Firma = "Camelot Jeans";
            urun1.Fiyat = 22;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Normal Jeans";
            urun2.Firma = "racunlar Jeans";
            urun2.Fiyat = 20;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Normal Jeans";
            urun3.Firma = "Dossi Dossi Jeans";
            urun3.Fiyat = 20;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + ": " + urunler[i].Firma + ":" + urunler[i].Fiyat);
            }
            Console.WriteLine("for bitti");
            foreach (var Urun in urunler)
            {
                Console.WriteLine(Urun.UrunAdi + ":" + Urun.Firma + " : " + Urun.Fiyat);
            }
            Console.WriteLine("foreach bitti");

            { int i = 0;
            while (i < urunler.Length)
            {
                Console.WriteLine(urunler[i].UrunAdi + ":" + urunler[i].Firma + ":" + urunler[i].Fiyat);
                i++;
            }
            }
            
            Console.WriteLine("while bitti");
          

        }
        class Urun
        {
            public string UrunAdi { get; set; }
            public string Firma { get; set; }
            public int Fiyat { get; set; }
        }

    }
}