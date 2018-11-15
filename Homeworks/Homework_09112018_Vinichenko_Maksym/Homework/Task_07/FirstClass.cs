using ConsoleWritable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleWritable;

namespace FirstClassNamespace
{
    public class FirstClass : IConsoleWritable
    {
        public void WriteConsole()
        {
            Console.WriteLine("First class writes");
        }
    }
}
