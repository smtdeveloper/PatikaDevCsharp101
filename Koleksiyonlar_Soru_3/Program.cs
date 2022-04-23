using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Bir cümle giriniz : ");
            string cumle = Console.ReadLine();
            ArrayList sesliHarfler = new ArrayList();
            char[] sabitSesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] harfler = new char[cumle.Length];
            harfler = cumle.ToCharArray();
            foreach (var harf in harfler)
            {
                foreach (var sabitSesli in sabitSesliHarfler)
                {
                    if (harf == sabitSesli)
                    {
                        sesliHarfler.Add(harf);
                    }
                }

            }

            Console.WriteLine("Cümledeki Sesli Harfler ; ");
            foreach (var item in sesliHarfler)
            {
                Console.Write(  item + ", ");
            }
            Console.ReadLine();
        }
    }
}
