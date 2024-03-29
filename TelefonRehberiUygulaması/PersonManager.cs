﻿using System;

namespace TelefonRehberiUygulaması
{
    public class PersonManager : Users
    {
        public void PersonAdd()
        {
            Console.WriteLine("İsminizi giriniz : ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Telefon numaranızı giriniz : ");
            string phoneNumber = Console.ReadLine();

            Person person = new Person(name, lastName, phoneNumber);

            Console.WriteLine("{0} telefon rehberine başarılı bir şekilde eklenmiştir.", person.Name);
        }

        public void PersonDelete()
        {
            User();
            Console.WriteLine("Lütfen silmek istediğiniz kişinin ismini veya soyadını yazınız:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < person.Count; i++)
            {
                if (search == person[i].Name || search == person[i].LastName)
                {
                    Console.WriteLine("Kullanıcı {0} silmek istediğinize eminmisiniz E/H", person[i].Phone);
                    var answer = Console.ReadLine();
                    kayitvarmi = true;

                    if (answer == "y")
                    {
                        Console.WriteLine("Kullanıcı Silme İşlemi Başarıyla Eklenmiştir.");
                    }
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı.");
            }
        }
        public void PersonUpdate()
        {
            User();
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin ismini veya soyadını giriniz : ");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < person.Count; i++)
            {
                if (search == person[i].Name || search == person[i].LastName)
                {
                    Console.WriteLine("Adı:{0}" +
                    "\nSoyadı:{1}" +
                    "\nNumarası:{2}" +
                    "\n**************", person[i].Name, person[i].LastName, person[i].Phone);
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı.");
            }

        }

        public void GuideSearch()
        {
            User();
            for (var i = 0; i < person.Count; i++)
            {
                Console.WriteLine("Adı:{0}" +
                "\nSoyadı:{1}" +
                "\nNumarası:{2}" +
                "\n**************", person[i].Name, person[i].LastName, person[i].Phone);
            }

        }

        public void PersonSearch()
        {
            User();
            Console.WriteLine("Kişi araması yapmak istediğiniz tipi seçiniz" +
                "\n**************************************" +
                "\n(1)İsim ve Soyadına göre arama" +
                "\n(2)Numaraya göre arama");
            var search = Console.ReadLine();
            if (search == "1")
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını veya soyadını giriniz : ");
                var answer = Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < person.Count; i++)
                {
                    if (answer == person[i].Name || answer == person[i].LastName)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", person[i].Name, person[i].LastName, person[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else if (search == "2")
            {
                Console.WriteLine("Lütfen numarayı girişi yapınız : ");
                var answer = Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < person.Count; i++)
                {
                    if (answer == person[i].Phone)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", person[i].Name, person[i].LastName, person[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz veye hatalı tuşlama yaptınız.");
            }
        }
    }
}
