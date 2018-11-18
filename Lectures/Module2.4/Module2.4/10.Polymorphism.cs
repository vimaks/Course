//using System;

//namespace Module2._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            A aa = new A();
//            aa.Method();
//            aa = new B();
//            aa.Method();
//            aa = new C();
//            aa.Method();
//            aa = new D();
//            aa.Method();
//            aa = new Z();
//            aa.Method();
//            aa = new X();
//            aa.Method();

//        }
//    }


//    public class A
//    {
//        public virtual void Method()
//        {
//            Console.WriteLine("method of class A");
//        }
//    }

//    public class B : A
//    {
//        public override void Method()
//        {
//            Console.WriteLine("method of class B");
//        }
//    }

//    public class C : B
//    {
//        public new void Method()
//        {
//            Console.WriteLine("method of class C");
//        }
//    }
//    public class D : C
//    {
//        public virtual void Method()
//        {
//            Console.WriteLine("method of class D");
//        }
//    }

//    public class Z : A
//    {
//        public override void Method()
//        {
//            Console.WriteLine("method of class Z");
//        }
//    }

//    public class X : Z
//    {
//        public virtual void Method()
//        {
//            Console.WriteLine("method of class X");
//        }
//    }
//}
