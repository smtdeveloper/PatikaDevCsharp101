using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfKavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirleyiciler

            //1.Public : Her yerden erişilebilir.
            //2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //3.Internal : Sadece bulunduğu proje içerisinden erişilebilir
            //4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            Calisan calisan = new Calisan();

            calisan.name = "Samet";
            calisan.Lastname = "Akca";
            calisan.No = 186029045;
            calisan.Departman = "Backend";

            calisan.CalisanInfo();

            Console.WriteLine(" --- ");

            Calisan calisan2 = new Calisan();
            calisan2.name = "Deniz";
            calisan2.Lastname = "arda";
            calisan2.No = 186029046;
            calisan2.Departman = "Frontend";

            calisan2.CalisanInfo();
            Console.WriteLine(" --- ");

            Personel personel1 = new Personel();
            personel1.KimlikNo = "123467941";
            personel1.Ad = "Eslem";
            personel1.SoyAd = "Akca";
            personel1.PersonelNo = 5;
            personel1.Bolum = "Tasarım";

            personel1.personelInfo();
            Console.WriteLine(" --- ");

            Personel personel2 = new Personel("126458545","Ali","Veli",55,"Satış");
            personel2.personelInfo();
            Console.WriteLine(" --- ");

            Personel personel3 = new Personel("ahmet","as");
            personel3.personelInfo();
            Console.WriteLine(" --- ");

            Console.ReadLine();
        }

    }

    class Calisan
    {
        public string name { get; set; }
        public string Lastname { get; set; }    
        public int No { get; set; }
        public string Departman { get; set; }
    
        public void CalisanInfo()
        {
            Console.WriteLine("Çalışanın Adı : {0}",name);
            Console.WriteLine("Çalışanın Soyadı : {0}",Lastname);
            Console.WriteLine("Çalışanın No : {0}",No);
            Console.WriteLine("Çalışanın Departmanı : {0}",Departman);

        }

    }


    class Personel
    {
        public string KimlikNo { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int PersonelNo { get; set; }
        public string Bolum { get; set; }

        public Personel(string kimlikNo, string ad, string soyAd, int personelNo, string bolum)
        {
            this.KimlikNo = kimlikNo;
            this.Ad = ad;
            this.SoyAd = soyAd;
            this.PersonelNo = personelNo;
            this.Bolum = bolum;
        }
        public Personel(string ad, string soyAd)
        {
            this.KimlikNo = ad;
            this.Ad = soyAd;
        }

        public Personel()
        {
           
        }

        public void personelInfo()
        {
            Console.WriteLine("Çalışanın No : {0}", KimlikNo);
            Console.WriteLine("Çalışanın Adı : {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}", SoyAd);
            Console.WriteLine("Çalışanın No : {0}", PersonelNo);
            Console.WriteLine("Çalışanın Departmanı : {0}", Bolum);
        }
    }

}
