using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Logger : ILogger
    { 
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
