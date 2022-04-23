using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise
            //nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.

            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Samet", "Akca", "Yazılım");
            Calisan calisan2 = new Calisan("Eslem", "Betül", "Tasarım");
            Calisan calisan3 = new Calisan("Leyla", "gumus", "Yazılım");
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işleminin sonucu : {0}", Islemler.Topla(100, 200));

            Console.WriteLine("Çıkarma işleminin sonucu : {0}", Islemler.Cikar(200, 100));

            Console.ReadKey();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}