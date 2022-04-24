using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Arayüzler_
{
    public class SmsLogger : ILogger
    {
        public void WriteLogger()
        {
            Console.WriteLine("SMS LOGLANDI");
        }
    }
}
