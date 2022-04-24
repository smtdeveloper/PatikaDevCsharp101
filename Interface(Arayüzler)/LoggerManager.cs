using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Arayüzler_
{
    public class LoggerManager : ILogger
    {
        public ILogger _logger;

        public LoggerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLogger()
        {
            _logger.WriteLogger();
        }
    }
}
