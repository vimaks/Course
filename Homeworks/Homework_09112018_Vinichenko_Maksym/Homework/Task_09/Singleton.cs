using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Singleton
    {
        private static Singleton instance;

        private int _x = 5;
        private int _y = 6;


        private Singleton()
        {
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }


    }
}
