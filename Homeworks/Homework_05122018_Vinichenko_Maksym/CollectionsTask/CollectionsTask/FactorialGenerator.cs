using System;
using System.Collections;

namespace CollectionsTask
{
    public class FactorialGenerator : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int i = 1;
            int tmp = 1;
            while (tmp < 2000000)
            {
                tmp = i * tmp;
                i++;
                yield return tmp;
            }
        }
    }
}
