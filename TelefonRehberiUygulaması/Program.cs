using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonManager personManager = new PersonManager();
            Arayuz arayuz = new Arayuz();
            arayuz.Process();
            string number = Console.ReadLine();
            while (true)
            {
                if (number == "1")
                {
                    personManager.PersonAdd();
                    break;
                }
                else if (number == "2")
                {

                    personManager.PersonDelete();
                    break;
                }
                else if (number == "3")
                {
                    personManager.PersonUpdate();
                    break;
                }
                else if (number == "4")
                {
                    personManager.GuideSearch();
                    break;
                }
                else if (number == "5")
                {
                    personManager.PersonSearch();
                    break;
                }
                else if (number == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem");
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
