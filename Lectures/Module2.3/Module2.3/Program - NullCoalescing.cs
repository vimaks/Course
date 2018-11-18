//using System;

//namespace Module2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //null coalescing operator
//            ReturnProgram returnProgram = new ReturnProgram();
//            var prog =  returnProgram.ReturnSomething();
//        }
//    }

//    class ReturnProgram
//    {
//        private Program _value;

//        public ReturnProgram() { }
//        public ReturnProgram(Program value)
//        {
//            _value = value;
//        }

//        public Program ReturnSomething()
//        {
//           /*
//            if (_value == null)
//            {
//                return new Program();
//            }
//            else
//            {
//                return _value;
//            }
//            */
//            return _value ?? new Program();
//        }
//    }
//}
