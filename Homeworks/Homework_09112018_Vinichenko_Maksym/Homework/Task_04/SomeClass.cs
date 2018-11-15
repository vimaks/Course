using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class SomeClass
    {
        public void VoidWithoutParameters()
        {
            Console.WriteLine("Void without parameters");
        }

        public int IntWithBoolParameters(bool parameter1, bool parameter2, bool parameter3, bool parameter4, bool parameter5, bool parameter6)
        {
            Console.WriteLine("IntWithBoolParameters");
            return 6;
        }

        public void VoidWithArrayOfInt(int[] array, params int[] i)
        {
            Console.WriteLine("VoidWithArrayOfInt");
        }

        public void VoidWithParamsLong(out long l)
        {
            l = 1;
            Console.WriteLine("VoidWithParamsLong");
        }

        public void VoidWithParamsShort (ref short s)
        {
            Console.WriteLine("VoidWithParamsShort");
        }

        public Object ObjectWithParams(object o, int i, string s = "", double d = 1, bool b = true)
        {
            Console.WriteLine("ObjectWithParams");
            return o; 
        }
        public void SomeOverload(int i)
        {
            SomeOverload(i);
            Console.WriteLine($"SomeOverload1 int = {i}");
        }
        public void SomeOverload(int i, string s = "en-US")
        {
            Console.WriteLine($"SomeOverload2 int = {i}, sring = {s}");
        }

    }
}
