////Non virtual methods resolution is done based on variable type
////Virtual method resolution done based on on istance type

//using System;
//using System.Globalization;

//namespace Module2._4
//{
//    class Program
//    {

//        class Parent
//        {
//            public virtual void Foo(int x)
//            {
//                Console.WriteLine("Parent.Foo(int x)");
//            }
//        }

//        class Child : Parent
//        {
//            public override void Foo(int x)
//            {
//                Console.WriteLine("Child.Foo(double y)");
//            }
//        }


//        static void Main(string[] args)
//        {
//            Child c = new Child();
//            c.Foo(10);
//        }
//    }
//}
