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


        }
    }
}
