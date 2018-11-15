using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box
        private int _startPositionX;
        private int _startPositionY;
        private int _width;
        private int _height;
        private char _symbol;
        private string _message;
        public int StartPositionX { get => _startPositionX; set => _startPositionX = value; }
        public int StartPositionY { get => _startPositionY; set => _startPositionY = value; }
        public int Width { get => _width; set => _width = value - 1; }
        public int Height { get => _height; set => _height = value - 1; }
        public char Symbol { get => _symbol; set => _symbol = value; }
        public string Message { get => _message; set => _message = value; }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message
        public void Draw()
        {
            draw(StartPositionX, StartPositionY, Width, Height, Symbol, Message);
        }
        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
        private void draw(int startPositionX, int startPositionY, int width, int height, char symbol, string message)
        {
            Console.Clear();
            Console.SetCursorPosition(startPositionX,  + startPositionY);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(startPositionX + i, startPositionY);
                Console.Write(symbol);
            }

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(startPositionX, startPositionY + i);
                Console.Write(symbol);
            }

            for (int i = 0; i <= width; i++)
            {
                Console.SetCursorPosition(startPositionX + i, startPositionY + height);
                Console.Write(symbol);
            }

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(startPositionX + width, startPositionY + i);
                Console.Write(symbol);
            }

            Console.SetCursorPosition(startPositionX + 1 + width / 2 - message.Length / 2, height / 2 + startPositionY);
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(message.Trim());
            Console.Write((width + 1) * (height + 1));
            Console.SetCursorPosition(startPositionX + 1, startPositionY +height + 1);
            Console.ResetColor();
        }


    }
}
