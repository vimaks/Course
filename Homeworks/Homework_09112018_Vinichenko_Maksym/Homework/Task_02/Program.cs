using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[8];
            array[1] = new int[5];
            array[2] = new int[7];

            FillArray(array);
            ShowArray(array);
            Console.WriteLine();
            ChangeArrayLength(array);
            Array.Resize(ref array, 5);
            array[3] = new int[3] { 2, 3, 5 };
            array[4] = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            ShowArray(array);
            Console.WriteLine();
            Array.Reverse(array);
            ShowArray(array);
            Console.ReadLine();
        }

        static void FillArray(int[][] array)
        {
            Random randomInt = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = randomInt.Next(100);
                }
            }
        }

        static void ShowArray(int[][] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}, ");
                }
                Console.WriteLine();
            }
            
        }

        static void ChangeArrayLength(int[][] array)
        {
            int[][] arrayTemp = new int[4][];
            for (int i = 0; i < array.Length; i++)
            {
                arrayTemp[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    arrayTemp[i][j] = array[i][j];
                }
            }
            array = new int[4][]; 
            array = arrayTemp;
        }
    }
}
