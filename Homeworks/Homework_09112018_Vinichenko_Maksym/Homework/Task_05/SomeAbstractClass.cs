using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    public abstract class SomeAbstractClass
    {
        public SomeAbstractClass()
        {
            Console.WriteLine("Constructor SomeAbstractClass no parameter");
        }

        public SomeAbstractClass(int i)
        {
            Console.WriteLine("Constructor SomeAbstractClass with int");
        }

    }
}
