using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Database : IDatabase
    {
        public ILogger logger { get; set; }

        public Database(ILogger lg)
        {
            logger = lg;
        }
        public void Execute(string query)
        {      
            logger.Log(query);
        }

        public ILogger GetLogger()
        {
            return logger;
        }

    }
}
