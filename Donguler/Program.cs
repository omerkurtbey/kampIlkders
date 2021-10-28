using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "java";

            //array - dizi- []

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya Başlangıç için temel kurs","java","python"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
