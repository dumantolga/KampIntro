using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Veritabanına loglandı");
    }
    }
}
