using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class ClassForIDisposable : IDisposable
    {
        public ClassForIDisposable()
            {
            Console.WriteLine("I'm being constructed");
            }
        public void Dispose()
        {
            Console.WriteLine("I'm being disposed");
        }
    }
}
