using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            string deger;

            deger = (dolarDun < dolarBugun) ? "Artış oku." : "Azalış oku.";

            Console.WriteLine(deger);



            int gunler = 6;
            switch (gunler)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("HAFTADA 7 GÜN VARDIR. :D");
                    break;
            }


            
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Merhaba Dünya");
                i++;
            }
            Console.ReadKey();

        }
    }
}