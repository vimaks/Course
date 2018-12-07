using System;

namespace CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IteratorGenerator n = new IteratorGenerator(6);
            foreach (var item in n)
            {
                Console.WriteLine((int)item);
            }

            Console.WriteLine();

            FibonacciGenerator fi = new FibonacciGenerator();
            foreach (var item in fi)
            {
                Console.WriteLine((int)item);
            }

            Console.WriteLine();

            FactorialGenerator fa = new FactorialGenerator();
            int i = 1;
            foreach (var item in fa)
            { 
                Console.WriteLine($"{i}! = {(int)item}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
