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

}
