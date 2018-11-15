using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new SomeClass();
            var c2 = new SomeClass(5);
            var c3 = new SomeClass("qwerty", 1);
            Console.ReadLine();

        }
    }
}
