using System;
using System.Collections;

namespace CollectionsTask
{
    public class FibonacciGenerator : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int i = 0;
            int j = 1;
            int tmp = 1;
            while (tmp < 2000000)
            {
                yield return tmp;
                tmp = i + j;
                i = j;
                j = tmp;
            }
        }
    }
}
