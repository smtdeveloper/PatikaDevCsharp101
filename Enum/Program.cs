using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Days.Salı);
            Console.WriteLine((int)Days.Pazar);




            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarı çıkmak için havanın ısınmasını bekleyin.");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Çok sıcak bir gün.");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }


            Console.ReadLine(); 


        }

    }

    enum Days
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumatesi,
        Pazar

    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30

    };

}
