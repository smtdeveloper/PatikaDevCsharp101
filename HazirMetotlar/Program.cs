using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken =  "selam herkese ben samet akca" ;
            string degisken2 =  "selam herkese" ;

            //Length
            int karakretSayısı = degisken.Length;

            Console.WriteLine(karakretSayısı);

            // ToUpper - ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat - SONUNA string ekler
            Console.WriteLine(String.Concat(degisken, " İYİ GÜNLER  "));

            // Compare
            Console.WriteLine(degisken.CompareTo(degisken2)); //eşitse sıfır döndürür, eşit segilse boyutlarına göre 1 ya da -1 döndüür.  //  0, 1, -1 durumlar
            Console.WriteLine(String.Compare(degisken, degisken2, true));  // true büyük kücük harf duyarsız olur
            Console.WriteLine(String.Compare(degisken, degisken2, false)); // false  büyük kücük harf duyarlı olur


            //Contains
            Console.WriteLine(degisken.Contains(degisken2));  
            Console.WriteLine(degisken.EndsWith("akca"));
            Console.WriteLine(degisken.StartsWith("selam"));

            //IndexOf

            Console.WriteLine(degisken.IndexOf("C#"));
            Console.WriteLine(degisken.IndexOf("SMTcoder"));
            Console.WriteLine(degisken.LastIndexOf("a"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("samet", "SMTcoder"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4));

            Console.ReadKey();


            // Datetime ve Math Sınıfları

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));
            // DateTime format
            Console.WriteLine(DateTime.Now.ToString("dd"));   // 16
            Console.WriteLine(DateTime.Now.ToString("ddd"));  // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));   // 04
            Console.WriteLine(DateTime.Now.ToString("MMM"));  // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

            Console.WriteLine(DateTime.Now.ToString("yy"));   // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));  // 2022


            Console.WriteLine("******MATH kutuphanesi*******");
            // MATH kutuphansi
            Console.WriteLine(Math.Abs(-25)); // 25

            Console.WriteLine(Math.Sin(10)); // 25
            Console.WriteLine(Math.Cos(10)); // 25
            Console.WriteLine(Math.Tan(10)); // 25

            Console.WriteLine(Math.Ceiling(22.3)); // 23   kusurat degerinden bagimsiz olarak en yakin ust tamsayiya yuvarlar
            Console.WriteLine(Math.Round(22.3));   // 22   kusurat degerine gore asagi veya yukari
            Console.WriteLine(Math.Round(22.7));   // 23
            Console.WriteLine(Math.Floor(22.7));   // 22   kusurat degerinden bagimsiz olarak en yakin alt tam sayiya yuvarlar

            Console.WriteLine(Math.Max(2, 6)); // iki sayinin en buyugunu
            Console.WriteLine(Math.Min(2, 6)); // iki sayinin en kucugunu

            Console.WriteLine(Math.Pow(2, 6)); // 2^6 verir yani 64
            Console.WriteLine(Math.Sqrt(9));  // kare kokunu verir yani 3
            Console.WriteLine(Math.Log(9));  // 9'un e tabanindaki logaritmik karsiligini verir
            Console.WriteLine(Math.Exp(3));  // e uzeri 3'u verir
            Console.WriteLine(Math.Log10(10));  // 10 sayisinin logaritma 10 tabanindaki karsiligini verir

        }
    }
}
