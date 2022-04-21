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

            string birHayvan = animals[0];

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
                Console.Write("Dizini {0} Elemanını giriniz : ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }


            double toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Dizinin Ortalaması :  " + toplam / diziUzunluğu);

            Console.WriteLine("--------- 2.kısım : Array sınıf metotları ------");

            Console.WriteLine("Sayı dizisi");
            int[] sayiDizi = { 5, 3, 9, 45, 27, 325, 35, 56 };
            foreach (var sayi in sayiDizi)
                Console.WriteLine(sayi);

            Console.WriteLine("Sıralı dizi (Sort)");
            Array.Sort(sayiDizi);
            foreach (var sayi in sayiDizi)
                Console.WriteLine(sayi);

            Console.WriteLine("Sıfırlama dizi (Clear)");
            Array.Clear(sayiDizi,1,3);
            foreach (var sayi in sayiDizi)
                Console.WriteLine(sayi);

            Console.WriteLine("Aynalama dizi (Reverse)");
            Array.Reverse(sayiDizi);
            foreach (var sayi in sayiDizi)
                Console.WriteLine(sayi);

            Console.WriteLine("Eleman bulma dizi (IndexOf)"); // LastIndexOf Metodu: Kullanımı IndexOf gibidir. Dizi içerisinde aramaya sondan başlar.
            int sayiBulma = Array.IndexOf(sayiDizi,3);
            
                Console.WriteLine(sayiBulma);

            Console.WriteLine("Boyutlama dizi (Resize)");
            Array.Resize<int>(ref sayiDizi,9);
            sayiDizi[8] = 99;
            foreach (var sayi in sayiDizi)
                Console.WriteLine(sayi);


        }
    }
}
