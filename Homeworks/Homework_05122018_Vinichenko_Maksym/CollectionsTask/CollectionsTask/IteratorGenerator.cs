using System;
using System.Collections;

namespace CollectionsTask
{
    public class IteratorGenerator : IEnumerable
    {
        public int N { get; set; }

        public IteratorGenerator(int n)
        {
            if (n > 0 && n % 2 == 0)
            {
                N = n;
            } else
            {
                Console.WriteLine("Number in constructor not positive number or not even number");
            }
        }

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i <= N)
            {
                yield return i++;
            }
        }
    }
}
