//using System;

//namespace Module2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person1 = new Person()
//            {
//                Weight = 60
//            };
//            Person person2 = new Person()
//            {
//                Weight = 80
//            };
//            var bulkLoad = person1 + person2;
//            Console.WriteLine(bulkLoad.Weight);
//        }
//    }

//    class Person
//    {
//        public string Name { get; set; }
//        public double Weight { get; set; }
//        public double Height { get; set; }
//        public decimal Salary { get; set; }

//        public static Person operator + (Person per1, Person per2)
//        {
//            return new Person()
//            {
//                Weight = per1.Weight + per2.Weight
//            };
//        }
//    }
//}
