using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Pozitif bir sayı giriniz");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Dizini {0} Elemanını giriniz : ", i + 1);
                sayiDizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in sayiDizi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("Cift : " +  item );
                }
            }

            //2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine(" bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            int[] dizi2 = new int[n];

            Console.WriteLine(" bir sayı giriniz");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("lütfen {0}. sayıyı giriniz", i + 1);
                dizi2[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in dizi2)
            {
                if (m % i == 0)
                {
                    Console.WriteLine(i);
                }
                else if (m == i)
                {
                    Console.WriteLine(i);
                }
            }


            //3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("lütfen bir sayı giriniz");
            int adet = int.Parse(Console.ReadLine());
            string[] dizi3 = new string[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("lütfen {0}. kelimeyi giriniz", i + 1);
                dizi3[i] = Console.ReadLine();
            }

            for (int i = adet - 1; i >= 0; i--)
            {
                Console.WriteLine(dizi3[i]);
            }

            //4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            string[] kelimeler;
            Console.WriteLine("lütfen bir cümle giriniz");
            string cümle = Console.ReadLine();
            kelimeler = cümle.Split(" ");

            Console.WriteLine("cümlede {0} kelime var", kelimeler.Length);
            Console.WriteLine("cümlede {0} tane harf var", cümle.Length);
        }
    }
}
