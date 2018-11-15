using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    public class SomeClass : SomeAbstractClass
    {
        public SomeClass()
            : base()
        {
            Console.WriteLine("Constructor SomeClass no parameter");
        }

        public SomeClass(int i)
            : this()
        {
            
            Console.WriteLine("Constructor SomeClass with int");
        }

        public SomeClass(string s, int i)
            : base(5)
        {
            Console.WriteLine("Constructor SomeClass with string and int");
        }
    }
}
