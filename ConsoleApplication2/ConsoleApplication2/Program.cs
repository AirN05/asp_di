using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryIoc;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Container();
            c.Register<IDatabase>();
           // IDatabase db = c.Resolve<IDatabase>;
        }
    }
}
