using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyListTask
{
    public class MyList<T> : IList<T>
    {
        private T[] array = new T[4];

        public T this[int index] {
            get { return array[index]; }
            set { array[index] = value; }
        }
        int lastIndex = 0;

        public int Count {
            get { return lastIndex; }
        }
        public bool IsReadOnly { get; }

        public void Add(T item)
        {
            if (lastIndex == array.Length - 1)
            {
                T[] newArray = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[lastIndex++] = item;
        }

        public void Clear()
        {
            T[] newArray = new T[array.Length];
            array = newArray;
            lastIndex = 0;
        }

        public bool Contains(T item)
        {
            bool result = false;
            foreach (var someItem in array)
            {
                if (someItem.Equals(item))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void CopyTo(T[] arrayIn, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                arrayIn[i] = array[i - arrayIndex];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            int i = 0;
            while (i < Count)
            {
                yield return array[i];
                i++;
            }
        }

        public int IndexOf(T item)
        {
            int result = -1;
            for(int i = 0; i <= Count; i++)
            {
                if (array[i].Equals(item))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public void Insert(int index, T item)
        {
            int indexNewArr = 0;
            T[] newArray = new T[array.Length];
            for (int i = 0; i <= Count; i++)
            {
                if (i == index)
                {
                    var tmp = array[i];
                    newArray[indexNewArr] = item;
                    indexNewArr++;
                    newArray[indexNewArr] = tmp;
                    indexNewArr++;

                }
                else
                {
                    newArray[indexNewArr] = array[i];
                    indexNewArr++;
                }
            }
            array = newArray;
        }

        public bool Remove(T item)
        {
            bool result = false;
            int indexNewArr = 0;
            T[] newArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(item) && result == false)
                {
                    newArray[indexNewArr] = array[i];
                    indexNewArr++;
                }
                else if ((array[i].Equals(item) && result == false))
                {
                    result = true;
                    lastIndex--;
                }
                else
                {
                    newArray[indexNewArr] = array[i];
                    indexNewArr++;
                }
            }
            array = newArray;

            return result;
        }

        public void RemoveAt(int index)
        {
            int indexNewArr = 0;
            T[] newArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    lastIndex--;
                }
                else
                {
                    newArray[indexNewArr] = array[i];
                    indexNewArr++;
                }
            }
            array = newArray;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
