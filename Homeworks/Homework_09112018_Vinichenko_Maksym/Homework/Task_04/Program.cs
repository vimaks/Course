using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new SomeClass();
            int[] array = new int[3] { 1, 2, 3 };
            long l;
            short s = 1;
            object o = c1;
            c1.VoidWithoutParameters();
            c1.IntWithBoolParameters(parameter2: true, parameter6: false, parameter1: true, parameter4: true, parameter3: false, parameter5: true);
            c1.VoidWithArrayOfInt(array, 3,2,1);
            c1.VoidWithParamsLong(out l);
            c1.VoidWithParamsShort(ref s);
            c1.ObjectWithParams(o, 3, d: 44, b: false);
            c1.SomeOverload(5);
            Console.ReadLine();
        }
    }
}
