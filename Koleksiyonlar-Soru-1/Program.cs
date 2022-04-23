using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


            int sayi = 0;
            ArrayList allList = new ArrayList();

            Console.WriteLine("20 adet pozitif sayı giriniz :  ");

            int count = 0;
            while (count < 20)
            {
                Console.WriteLine($"{count + 1}.sayıyı giriniz : ");
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi > 0)
                    {
                        count++;
                        allList.Add(sayi);
                    }
                    else // negatif degerse uyarı veriyor
                    {
                        Console.WriteLine("Negatif değer girdiniz, lütfen pozitif değer giriniz.");
                    }
                }
                catch (Exception) // sayı dışında başka karakter girerse uyarı veriyor
                {

                    Console.WriteLine("lütfen pozitif sayı değer giriniz.");
                }
            }

            ArrayList primeList = new ArrayList();
            ArrayList notPrimeList = new ArrayList();

            bool status = false;
            foreach (int item in allList)
            {
                status = false;
                for (int x = 2; x <= item / 2; x++)//Aldığımız sayı asal mı degil mi bulmak için bir döngü tanımlıyoruz ve o sayının yarısı kadar döngü dönüyor.
                {
                    if (item % x == 0)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == true || item == 1)
                    notPrimeList.Add(item);
                else
                    primeList.Add(item);
            }

            int average = 0;
            primeList.Sort();// sıralama
            Console.WriteLine("\n *** Asal Sayılar *** ");
            foreach (int item in primeList)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal sayı dizisinin eleman sayısı: {primeList.Count} - Ortalama: {average / primeList.Count}\n");



            notPrimeList.Sort();// sıralama
            average = 0;
            Console.WriteLine("\n *** Asal Olmayan Sayılar *** ");
            foreach (int item in notPrimeList)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal olmayan sayı dizisinin eleman sayısı: {notPrimeList.Count} - Ortalama: {average / notPrimeList.Count}");

            Console.ReadKey();

        }
    }
}
