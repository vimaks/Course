using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new SomeClass();
            Console.WriteLine($"Y = {c.Y} Z = {c.Z}");
            c.Y = 1;
            c.Z = 2;

            Console.WriteLine($"Y = {c.Y} Z = {c.Z}");
            Console.WriteLine($"U = {c.U} V = {c.V}");
            Console.ReadLine();
        }
    }
}
