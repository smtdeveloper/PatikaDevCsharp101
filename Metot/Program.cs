﻿using System;

namespace Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geridonus_tipi metot_adi(parametreListesi/arguman)
            // {
            //     komutlar;
            //      return;
            // }
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            System.Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
            System.Console.WriteLine(Convert.ToString(sonuc2));
            System.Console.WriteLine(Convert.ToString(a + b));

            string sayi = "999";

            bool sonuc3 = int.TryParse(sayi, out int outSayi);
            if (sonuc3)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar2 instance = new Metotlar2();
            instance.Topla2(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme - Overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Fatih", "Hacıoğlu");

            //Metot İmzası
            //metot adı + parametre sayısı + parametre


            // Rekürsif Metotlar - öz yineleme
            // 3^4 = 3*3*3*3

            //FOR İLE
            int result = 1;
            for (int i = 1; i <= 4; i++)
            {
                result = result * 3;
            }
            Console.WriteLine( "For ile : " + result);

            // Metot ile
            Islemler instance2 =  new Islemler();
            Console.WriteLine( "Metot ile : " + instance2.Expo(3, 4));

            // Extension Metot
            string ifade3 = "Samet Akca Coder";
            Console.WriteLine(ifade3);

            bool BoslukVarMi = ifade3.CheckSpaces();
            Console.WriteLine(BoslukVarMi);
            if (BoslukVarMi)
            {
                Console.WriteLine(ifade3.RemoveSpaces());
            }

            Console.WriteLine(ifade3.MakeUpperCase());
            Console.WriteLine(ifade3.MakeLowerCase());




        }

       

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }



    }

    public static class Extension{

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {

            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {

            return param.ToLower();
        }

    }

    public class Islemler{

        public int Expo(int sayi, int üs)
        {

            if (üs < 2)
                return sayi;

            return Expo(sayi, üs-1)* sayi;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }

       

    }

    class Metotlar2
    {
        public void Topla2(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}