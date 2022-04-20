using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizilerde tanımlama 
            string[] colors = new string[5];

            string[] animals = { "dog", "Tigger", "Cat" };

            int[] dizi;
            dizi = new int[8];

            // Dizilere değer atama ve erişim

            colors[0] = "red";

            string birHayvan =  animals[0];

            int birSayi = dizi[1] = 5;

            Console.WriteLine(birHayvan);
            Console.WriteLine(birSayi);
            Console.WriteLine(animals[1]);

            // Döngülerde dizi kullanımı

            Console.Write("Dizinin eleman sayısını giriniz : ");
            int diziUzunluğu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunluğu];
            
            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Dizini {0} Elemanını giriniz : " , i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine()); 
            }


            double toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Dizinin Ortalaması :  " + toplam/diziUzunluğu);
            
            
          


        }
    }
}
