using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<ILogger>().To<Logger>().InSingletonScope();
            kernel.Bind<IDatabase>().To<Database>().InTransientScope();

            IDatabase dataBase = kernel.Get<IDatabase>();
            dataBase.Execute("test string");
        }
    }
}
