using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    class SomeClass
    {
        public int X { get; set; }
        private int _y;
        private int _z;

        public int Y { get => _y; set => _y = value; }

        public int GetZ()
        {
            return _z;
        }

        public void SetZ(int value)
        {
            _z = value;
        }
        
    }
}
