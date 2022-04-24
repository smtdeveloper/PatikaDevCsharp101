using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Arayüzler_
{
    public class DataBaseLogger : ILogger
    {
        public void WriteLogger()
        {
            Console.WriteLine("Data base loglandı.");
        }
    }
}
