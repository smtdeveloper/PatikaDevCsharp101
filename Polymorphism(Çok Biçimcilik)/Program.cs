using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Çok_Biçimcilik_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism(Çok Biçimcilik)
            //    Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor
            //    Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız.
            //    Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır
            //    Bunu da virtual ve override anahtar kelimeleri sağlar.


            //            Virtual metot tanımı:



            //public virtual void UyaranlaraTepki()
            //        {
            //            Console.WriteLine("Canlılar uyaranlara tepki verir.");
            //        }


            //        Alt sınıf içerisinde override metot kullanımı:



            //public override void UyaranlaraTepki()
            //        {
            //            base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
            //            Console.WriteLine("Bitkiler güneşe tepki verir.");
            //        }


            // Sealed base'de kullanırsa miras alan hiç bir sınıf override yapamaz.

            // sytax
            // public sealed class canlılar { }

        }
    }
}
