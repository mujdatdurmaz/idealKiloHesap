using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idealKiloHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boy = ");
            int boy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Doğum Yılı = ");
            int dYili = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cinsiyet(E/K) = ");
            string cinsiyet = Console.ReadLine();

            Console.Write("Kilo = ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            double k, ideal;

            if (cinsiyet == "E" || cinsiyet == "e") { k = 0.9; }
            else if (cinsiyet == "K" || cinsiyet == "k") { k = 0.8; }
            else { k = 0; }

            int yas = DateTime.Now.Year - dYili;
            ideal = (boy - 100 + yas / 10) * k;

            if (ideal == kilo)
                Console.WriteLine("Fitsiniz.." + "ideal kilo :" + ideal + "  " + "Sizin Kilonuz : " + kilo);
            else if (ideal < kilo)
                Console.WriteLine("Şişmansınız. Biraz kilo ver." + "ideal kilo :" + ideal + "  " + "Sizin Kilonuz : " + kilo);
            else
                Console.WriteLine("Zayıfsınız. Biraz kilo al." + "ideal kilo :" + ideal + "  " + "Sizin Kilonuz : " + kilo);

            Console.ReadKey();




        }
    }
}
