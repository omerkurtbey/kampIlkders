using System;

namespace ClassMetotDemo
{
    class Musteri
    {
        static void Main(string[] args)
        {
            MusteriBilgileri musteri1 = new MusteriBilgileri();
            musteri1.Id = "6546841351";
            musteri1.MusteriAdi = "Ahmet Kurt";
            musteri1.MusteriYasi = 28;
            musteri1.HesapBakiyesi = 1500;

            MusteriBilgileri musteri2 = new MusteriBilgileri();
            musteri2.Id = "4894154196";
            musteri2.MusteriAdi = "Berk Uysal";
            musteri2.MusteriYasi = 27;
            musteri2.HesapBakiyesi = 5000;

            MusteriBilgileri musteri3 = new MusteriBilgileri();
            musteri3.Id = "546545651";
            musteri3.MusteriAdi = "Emre Cevahir Korkmaz";
            musteri3.MusteriYasi = 29;
            musteri3.HesapBakiyesi = 500;

            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekleme(musteri1);
            MusteriManager.Listeleme(musteri2);
            MusteriManager.Silme(musteri3);
        }
        
            
        
    }
}
