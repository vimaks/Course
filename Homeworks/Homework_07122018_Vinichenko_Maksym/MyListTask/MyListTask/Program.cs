using System;
using System.Collections.Generic;

namespace MyListTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Clear();
            list.Add(1);
            list.Add(12);
            list.Add(21);
            bool b = list.Contains(12);

            List<int> testList1 = new List<int>();
            int[] testList2 = new int[100];
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(1);
            list.CopyTo(testList2, 5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //testList1.Remove(1);
            list.Remove(12);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            testList1.RemoveAt(2);
            list.RemoveAt(1);
            testList1.Add(44);
            testList1.Add(46);
            testList1.Insert(2, 12);
            list.Add(2);
            list.Add(1);
            list.Add(44);
            list.Add(46);
            list.Insert(2, 12);

        }
    }
}
