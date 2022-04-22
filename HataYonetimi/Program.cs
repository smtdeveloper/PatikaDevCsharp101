using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sayı : " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
                Console.WriteLine("Lütfen bir sayi girin !");

            }
            finally
            {
                Console.WriteLine("İYİ GÜNLER :)");
            }

            // 2. örnek
            try
            {
                int a = int.Parse(null);
                int b = int.Parse("sa");
                int c = int.Parse("12345678910");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("HATA : Boş değer girdiniz ! " + ex);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("HATA : Yanlıs formatda değer girdiniz" + ex);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("HATA : Çok yüsek veya çok düşük değer girdiniz " + ex);
            }

        }
    }
}
