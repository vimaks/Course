using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public class SomeClass : SomeBaseClass
    {
        private int _y;
        private int _z;
        private int _u;
        private int _v;
        public override int Y { get => _y; set => _y = value; }
        public override int Z { set => _z = value; }

        public int U { get => base.Y; set => _u = value; }
        public int V { get => base.Z; set => _v = value; }
        
    }
}
