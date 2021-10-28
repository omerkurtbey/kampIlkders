using System;

namespace kampIlkders
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip Güvenliği
            //Do not repeat yourself - kendini tekrar etme
            //değer tutucu

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısmı = true;

            if (sistemeGirisYapmısmı==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

            double dolarDun = 7.45;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }
        }
    }
}
