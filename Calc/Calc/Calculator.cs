using System;
using System.Linq;
using System.IO;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace Calc
{
    public class Calculator
    {
      
        delegate double DelMethod(double x, double y);

        private DelMethod delegat;

        private SyntaxTree tree;

        public Calculator(string expression)
        {
            this.tree = CSharpSyntaxTree.ParseText(@"using System;
                namespace Calc
                {
                    class Pars
                    {
                        public double ret(double x, double y)
                        {
                            return " + expression + @";
                        }
                    }
                }
                ");

            var compilation = CSharpCompilation.Create("pars", 
                new[] { tree }, 
                new[] { MetadataReference.CreateFromFile(typeof(object).Assembly.Location) },
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            var mem = new MemoryStream();
            EmitResult result = compilation.Emit(mem);

            if (!result.Success)
            {
                foreach (Diagnostic item in result.Diagnostics)
                {
                    Console.Error.WriteLine("{0}: {1}",  item.Id,  item.GetMessage());
                }
                return;
            }
            mem.Seek(0, SeekOrigin.Begin);
            Assembly assembly = Assembly.Load(mem.ToArray());

            Type type = assembly.GetType("Calc.Pars");
            ConstructorInfo constInfo = type.GetConstructors().First();

            var instance = constInfo.Invoke(null);
            MethodInfo method = type.GetMethod("ret");
            delegat = (DelMethod)method.CreateDelegate(typeof(DelMethod), instance);
        }

        public double Calculate(double x, double y)
        {
            return delegat(x, y);
        }
            
    }

    
}