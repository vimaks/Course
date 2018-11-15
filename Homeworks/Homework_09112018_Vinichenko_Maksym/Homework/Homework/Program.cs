using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c1 = new ClassForIDisposable())
            {

            }
            Console.ReadLine();
        }
    }
}
