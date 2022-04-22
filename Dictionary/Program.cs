using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(5, "Eslem");
            dic.Add(3, "Samet");
            dic.Add(99, "sa");

            // Dizilerde erişim
            Console.WriteLine(dic[5]);

            Console.WriteLine(" ");

            foreach (var item in dic)
                Console.WriteLine(item);

            //Count
            
            Console.WriteLine("Adet : " + dic.Count);

            //ContainsKey & ContainsValue
            Console.WriteLine(dic.ContainsKey(3));
            Console.WriteLine(dic.ContainsValue("sa"));

            //Remove

            dic.Remove(99);

            // key & value

            foreach (var item in dic)
                Console.WriteLine(item.Key);

            foreach (var item in dic)
                Console.WriteLine(item.Value);
        }
    }
}
