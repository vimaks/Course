//using System;

//namespace Module2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TheOnlyOne theOne = TheOnlyOne.GetInstance();
//            TheOnlyOne theTwo = TheOnlyOne.GetInstance();
//        }
//    }

//    class TheOnlyOne
//    {
//        private static TheOnlyOne _instance;

//        public static TheOnlyOne GetInstance()
//        {
//            if (_instance == null)
//            {
//                _instance = new TheOnlyOne();
//            }
//            return _instance;
//        }

//        public int InstanceProperty { get; set; }
//        public string OtherInstanceProperty { get; set; }
//    }
//}
