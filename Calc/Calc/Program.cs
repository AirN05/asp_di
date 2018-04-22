using System;

namespace Calc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");

            for (var i = 0; i < 100; i++)
            {
                Test();
            }
           
            Console.ReadLine();

    }

        public static void Test()
        {
            var result = new Calculator("Math.Pow( Math.PI + Math.Sin(x * 5 * y) + x + 8 , 2)")
                  .Calculate(3.7, 5.0);

            Console.WriteLine(result);
        }
    }
}