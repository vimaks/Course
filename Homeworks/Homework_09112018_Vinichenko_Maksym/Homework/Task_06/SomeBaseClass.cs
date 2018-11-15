using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public class SomeBaseClass
    {
        private int _y = 5;
        private int _z = 6;

        public virtual int Y { get => _y; set => _y = value; }
        public virtual int Z { get => _z; set => _z = value; }


        

        
    }
}
