using System;

namespace FindTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Sasha", "Vasya", "Petya", "Ivan"};
            Console.WriteLine(FindLast(array, a => a.Contains("ya")));
            Console.WriteLine(Find(array, a => a.Contains("ya")));
            Console.WriteLine(FindIndex(array, a => a.Contains("ya")));
            Console.WriteLine(FindIndexLast(array, a => a.Contains("ya")));
            Console.WriteLine();
            var testArr = FindAll(array, a => a.Contains("ya"));
            foreach (var item in testArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Exists(array, a => a.Contains("ya")));
            Console.WriteLine(TrueForAll(array, a => a.Contains("a")));



        }

        static T FindLast<T>(T[] array, Predicate<T> predicate)
            {
            T result = default(T);
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }
            return result;
        }

        static T Find<T>(T[] array, Predicate<T> predicate)
        {
            T result = default(T);
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        static int FindIndex<T>(T[] array, Predicate<T> predicate)
        {
            int result = -1;
            int counter = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result = counter;
                    break;
                }
                counter++;
            }
            return result;
        }

        static int FindIndexLast<T>(T[] array, Predicate<T> predicate)
        {
            int result = -1;
            int counter = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result = counter;
                }
                counter++;
            }
            return result;
        }

        static T[] FindAll<T>(T[] array, Predicate<T> predicate)
        {
            int length = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    length++; ;
                }
            }
            T[] result = new T[length];
            int counter = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result[counter] = item;
                    counter++;
                }
            }
            return result;
        }

        static bool Exists<T>(T[] array, Predicate<T> predicate)
        {
            bool result = false;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        static bool TrueForAll<T>(T[] array, Predicate<T> predicate)
        {
            bool result = false;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

    }
}
