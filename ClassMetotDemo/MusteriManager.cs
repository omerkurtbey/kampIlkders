using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme(MusteriBilgileri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Listeleme(MusteriBilgileri musteri)
        {
            Console.WriteLine(musteri.Id+":"+ musteri.MusteriAdi+":"+musteri.HesapBakiyesi);
        }
        public void Silme (MusteriBilgileri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }


        
    }
}
