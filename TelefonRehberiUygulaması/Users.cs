using System.Collections.Generic;

namespace TelefonRehberiUygulaması
{
    public class Users
    {
        public List<Person> person = new List<Person>();
        public void User()
        {
            person.Add(new Person("Samet", "Akca", "5555555"));
            person.Add(new Person("Eslem", "Betül", "4444444"));
            person.Add(new Person("Leyla", "asa", "3333333"));
         

        }
    }
}
