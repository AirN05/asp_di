using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Composition;

namespace ConsoleApplication1
{
    [Export(typeof(ILogger))]
    public class Logger : ILogger
    {
        private string logPath = @"%TEMP%\test.log";
   
        public void Log(string message)
        {
            if (!File.Exists(logPath))
            {
                File.Create(logPath);
            }
            StreamWriter sw =  File.AppendText(logPath);
            sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") +  " " + message);
            sw.Close();
            
        }

    }
}
