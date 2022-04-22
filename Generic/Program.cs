using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collection.Generic


            List<int> sayilar = new List<int>();
            sayilar.Add(20);
            sayilar.Add(10);
            sayilar.Add(15);
            sayilar.Add(18);

            List<string> renkler = new List<string>();
            renkler.Add("turuncu");
            renkler.Add("Mavi");
            renkler.Add("siyah");
            renkler.Add("Sari");
            renkler.Add("yesil");

            //Count
            Console.WriteLine(sayilar.Count);
            Console.WriteLine(renkler.Count);

            // Foreach ve List.Foreach ile veri erişim

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            renkler.ForEach(r => Console.WriteLine(r));

            // Listeden eleman silme
            Console.WriteLine("Listeden eleman silme");

            renkler.Remove("siyah");
            sayilar.Remove(15);

            renkler.RemoveAt(1);
            sayilar.RemoveAt(0);

            sayilar.ForEach(s => Console.WriteLine(s));
            renkler.ForEach(r => Console.WriteLine(r));

            // Liste arama yapma
            if (sayilar.Contains(10))
                Console.WriteLine("Liste'de 10 var");

            // Eleman ile index'e erişim
            Console.WriteLine(renkler.BinarySearch("turuncu"));


            // Diziyi list'e çevirme

            string[] hayvanlarDizisi = { "kedi", "kuş", "köpek" };
            List<string> hayvanlarListesi = new List<string>(hayvanlarDizisi);

            // Listeyi temizleme
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Korkut";
            kullanici1.Soyisim = "Kutluata";
            kullanici1.Yas = 49;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Okan";
            kullanici2.Soyisim = "Aydin";
            kullanici2.Yas = 38;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar
            {
                Isim = "Yigit",
                Soyisim = "Gursoy",
                Yas = 10
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi: " + kullanici.Isim);
                Console.WriteLine("Kullanici Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yasi: " + kullanici.Yas);
            }

            yeniListe.Clear();


            Console.ReadKey();


        }

        public class Kullanicilar
        {
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }   // encapsulation islemi 
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
