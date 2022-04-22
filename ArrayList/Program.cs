using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // ATAMA
            ArrayList liste = new ArrayList();
            liste.Add("Eslem");
            liste.Add(5);
            liste.Add(true);
            liste.Add('A');

            // ERİŞİM
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("**** Add Range ****");
             string[] renkler = {"kırmızı", "sarı", "yeşil"};

            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };

            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("**** Sort ****");
            liste.Sort();   // compile time'da hata vermez ama runtime'da patlar. ArrayList'in sorunu budur. farkli tipte herseyi alinca sort'larken elmayla armut kiyaslar gibi olur

            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9));   // BinarySearch kullanmak icin once siralayip sonra kullanmak gerekiyor

            //Reverse 
            Console.WriteLine("**** Reverse ****");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("**** Clear ****");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
