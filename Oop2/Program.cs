using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ömer Kurtbey)
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "165152";
            musteri1.Adi = "Ömer";
            musteri1.Soyadi = "Kurtbey";
            musteri1.TcNo = "6315641";
            musteri1.Id = 34;

            //Adıyaman Pazarı
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 02;
            musteri2.MusteriNo = "65412";
            musteri2.SirketAdi = "Adıyaman Pazarı";
            musteri2.VergiNo = "5456845";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
