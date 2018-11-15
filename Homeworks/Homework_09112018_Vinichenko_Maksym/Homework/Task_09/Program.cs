using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"X = {Singleton.getInstance().X} Y = {Singleton.getInstance().Y}");

            Singleton.getInstance().X = 1;
            Singleton.getInstance().Y = 2;

            Console.WriteLine($"X = {Singleton.getInstance().X} Y = {Singleton.getInstance().Y}");

            //Singleton NewInstance = new Singleton();
            Console.ReadLine();

        }
    }
}
