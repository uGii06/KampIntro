using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++) Döngülerde bir bir artar.
            //for (int i = 1; i <= 10; i=i+1) Farklı yazım şeklidir. Bir bir artar.
            //for (int i = 1; i <= 10; i=i+2) Döngülerde ikişer ikişer artar.
            //for (int i = 1; i <= 10; i+=2) Farklı yazım şeklidir. İkişer ikişer artar.

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            Console.WriteLine("");
            //array - Dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kurs","Java","Python","C#"}; 

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("For Bitti.");
            Console.WriteLine("");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");

            

        }   
         

    }
}
