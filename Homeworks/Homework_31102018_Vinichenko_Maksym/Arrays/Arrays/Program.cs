using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            ForthTask();

        }

        // Объявить массив на 10 элементов, заполнить его элементами от 0 до 9 и вывести
        static void FirstTask()
        {
            Console.WriteLine("Первое задание: ");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        //Найти минимальный элемент произвольно заданного массива
        static void SecondTask()
        {
            Console.WriteLine("Второе задание: ");
            Console.WriteLine("Введите размер массива: ");
            int arrayLength = 0;
            string input = Console.ReadLine();
            while (int.TryParse(input, out arrayLength) == false)
            {
                Console.WriteLine("Введите целое число: ");
                input = Console.ReadLine();
            }
                arrayLength = int.Parse(input);
                
            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива: ");
                string inputElemntOfArray = Console.ReadLine();
                while (int.TryParse(inputElemntOfArray, out arrayLength) == false)
                {
                    Console.WriteLine("Введите целое число: ");
                    inputElemntOfArray = Console.ReadLine();
                }
                array[i] = int.Parse(inputElemntOfArray);
            }
            Console.WriteLine("Полученный массив: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            int minElementOfArray = array[0];
            for (int i = 0; i < array.Length; i++)
                for(int j = i + 1; j < array.Length ; j++)
                {
                    {
                        if (array[j] <= array[i] && array[j] <= minElementOfArray)
                        {
                            minElementOfArray = array[j];
                        }

                    }

                }
            Console.WriteLine();
            Console.WriteLine($"Минимальный елемент массива: {minElementOfArray}");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        //Считать с клавиатуры массив строк заданного пользователем размера. Считать еще одну строку, вывести все строки содержащие данную строку и индекс с которого такая подстрока начинается.
        static void ThirdTask()
        {
            Console.WriteLine("Третье задание: ");
            Console.WriteLine("Введите размер массива строк: ");
            int arrayLength = 0;
            string input = Console.ReadLine();
            while (int.TryParse(input, out arrayLength) == false)
            {
                Console.WriteLine("Введите целое число: ");
                input = Console.ReadLine();
            }
            arrayLength = int.Parse(input);

            string[] array = new string[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива: ");
                string inputElemntOfArray = Console.ReadLine();
                array[i] = inputElemntOfArray;
            }
            Console.WriteLine("Полученный массив: ");
            foreach (string element in array)
            {
                Console.Write(element + "\n");
            }

            Console.WriteLine("Введите строку для поиска: ");
            string substring = Console.ReadLine();
            int indexOfSubstring;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                indexOfSubstring = array[i].IndexOf(substring);
                if (indexOfSubstring >= 0)
                {
                    Console.WriteLine($"Строка: {array[i]} , индекс подстроки для поиска: {indexOfSubstring}");
                    counter++;
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("Не найдено строк с такой подстрокой!");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        //Найти и вывести сумму цифр числа
        static void ForthTask()
        {
            Console.WriteLine("Четвертое задание: ");
            Console.WriteLine("Введите число: ");
            long number;
            string input = Console.ReadLine();
            while (long.TryParse(input, out number) == false)
            {
                Console.WriteLine("Введите целое число: ");
                input = Console.ReadLine();
            }
            number = long.Parse(input);
            Console.WriteLine($"Вы вели число: {number}");
            long numberSum = 0;
            while (number > 0)
            {
                numberSum += number % 10;
                number = number / 10;
            }

            Console.WriteLine($"Сумма цифр числа: {numberSum}");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
