using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWritable;
using FirstClassNamespace;
using SecondClassNamespace;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsoleWritable someIConsoleWriteble;
            someIConsoleWriteble = new FirstClass();
            someIConsoleWriteble.WriteConsole();
            someIConsoleWriteble = new SecondClass();
            someIConsoleWriteble.WriteConsole();

            Console.ReadLine();
        }
    }
}
