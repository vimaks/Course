using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Implement start position, width and height, symbol, message input

                Console.WriteLine("Input startPositionX");
                int startPositionX = InputInt();

                Console.WriteLine("Input startPositionY");
                int startPositionY = InputInt();
                Console.WriteLine("Input width border");
                int width = InputInt();
                Console.WriteLine("Input height border");
                int height = InputInt();
                Console.WriteLine("Input char value '*', '+', '.' for border");
                char symbol = InputCharForBorder();
                Console.WriteLine(" Input Message");
                string mesage = Console.ReadLine();


                //Create Box class instance
                Box box = new Box();
                box.StartPositionX = startPositionX;
                box.StartPositionY = startPositionY;
                box.Width = width;
                box.Height = height;
                box.Symbol = symbol;
                box.Message = mesage;
                //Use  Box.Draw() method
                box.Draw();
                Console.WriteLine("Press any key...");
            Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
        }
        static int InputInt()
        {
            int i = 0;
            string input = Console.ReadLine();
            while (int.TryParse(input, out i) == false)
            {
                Console.WriteLine("Plese input int value: ");
                input = Console.ReadLine();
            }
            i = int.Parse(input);
            return i;
        }

        static char InputCharForBorder()
        {
            char c = '1';
            string input = Console.ReadLine();

            if (input.Equals("*") || input.Equals("+") || input.Equals(".") == true)
            {
                c = char.Parse(input);
               
            }
            else
            {
                Console.WriteLine("Input char value '*', '+', '.' for border");
                InputCharForBorder();
            }
            c = char.Parse(input);
            return c;
        }

    }
}
