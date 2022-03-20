using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevCsharp101
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;             //1 byte
            sbyte c = 5;            //1 byte

            short s = 5;            //2 byte
            ushort us = 5;          //2 byte

            Int16 i16 = 2;          //2 byte
            int i = 2;              //4 byte
            Int32 i32 = 2;          //4 byte
            Int64 i64 = 2;          //8 byte

            uint ui = 2;            //4 byte
            long l = 4;             //8 byte
            ulong ul = 4;           //8 byte

            float f = 5;            //4 byte
            double d = 5;           //8 byte
            decimal de = 5;         //16 byte

            char ch = '2';          //2 byte
            string str = "samet";   //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "samet akca";
            string ad = "samet";
            string soyad = "Dikmedaş";
            string tamIsim = ad + " " + soyad;

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            bool bool1 = 10 < 2;

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



            //Atama ve işlemli atama
            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            else if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            int sonuc2 = sayi1 * sayi2;
            Console.WriteLine(sonuc2);

            int sonuc3 = sayi1 + sayi2;
            Console.WriteLine(sonuc3);

            int sonuc4 = sayi1++;
            Console.WriteLine(sonuc4);

            // % mod almak için kullanılır
            int sonuc5 = 20 % 3;
            Console.WriteLine(sonuc5);


            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit Conversion *****");
            byte aa = 5;
            sbyte bb = 30;
            short cc = 10;

            int dd = aa + bb + cc;
            Console.WriteLine("d: " + dd);

            long hh = dd;
            Console.WriteLine("h: " + hh);

            float ii = hh;
            Console.WriteLine("i: " + i);

            string e = "Zekeriye";
            char ff = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***** Explicit Conversion *****");

            int xx = 4;
            byte yy = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ***** ToString Methodu *****
            Console.WriteLine("***** ToString Methodu *****");
            int xxx = 6;
            string yyy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Convert
            Console.WriteLine("*****System.Covert sınıfı*****");
            string s1 = "10", s2 = "20";
            int sayi3, sayi4;
            int Toplam;

            sayi3 = Convert.ToInt32(s1);
            sayi4 = Convert.ToInt32(s2);

            Toplam = sayi3 + sayi4;
            Console.WriteLine("Toplam: " + Toplam);

            //Parse
            Console.WriteLine("***** Parse Methodu *****");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);

        }
    }
}
