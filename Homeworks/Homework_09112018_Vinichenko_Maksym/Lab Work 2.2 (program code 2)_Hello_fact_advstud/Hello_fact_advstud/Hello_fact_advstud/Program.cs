using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            Console.WriteLine($"Enter number for facrorial ");
            int number;
            string input = Console.ReadLine();
            while (int.TryParse(input, out number) == false)
            {
                Console.WriteLine($"Enter int number for facrorial ");
                input = Console.ReadLine();
            }
            number = int.Parse(input);

            //Call fact() method to calculate
            Console.WriteLine($"{number}! = {Fact(number)}");
            Console.ReadLine();

        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator
        public static int Fact(int i)
        {
            i = i <= 1 ? 1 : i * Fact(i - 1);
            return i;
        }
    }
}

