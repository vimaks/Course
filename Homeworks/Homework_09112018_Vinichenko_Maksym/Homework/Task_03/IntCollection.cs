using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class IntCollection
    {
        private int[] _arrayInt;
        public int this[int index]
        {
            get
            {
                return _arrayInt[index];
            }
            set
            {
                _arrayInt[index] = value;
            }
        }

        public IntCollection(int size)
        {
            _arrayInt = new int[size];
        }

        public void ResizeArray(int[] array,int size)
        {
            Array.Resize(ref array, size);
        }
    }
}
