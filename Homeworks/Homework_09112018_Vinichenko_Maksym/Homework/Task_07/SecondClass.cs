using ConsoleWritable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClassNamespace
{
    class SecondClass : IConsoleWritable
    {
        public void WriteConsole()
        {
            Console.WriteLine("Second class writes");
        }
    }
}
