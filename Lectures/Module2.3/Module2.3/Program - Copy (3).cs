//using System;

//namespace Module2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Car car1 = new Car()
//            {
//                IsInStock = true,
//                ListPrice = 6000M
//            };
//            Car car2 = new Car()
//            {
//                IsInStock = false,
//                ListPrice = 3000M
//            };

//            //   bool val = car1 && car2;
//        }
//    }

//    struct Car
//    {
//        public bool IsInStock { get; set; }
//        public decimal ListPrice { get; set; }
//        public decimal SalesPrice { get; set; }

//        public static decimal operator +(Car car, decimal value)
//        {
//            return car.ListPrice + value;
//        }

//        // public static decimal operator +(Car car1, Car car2)
//        // {
//        //     return car1.ListPrice + car2.ListPrice;
//        // }

//        public static Car operator +(Car car1, Car car2)
//        {
//            return new Car() { ListPrice = car1.ListPrice + car2.ListPrice };
//        }

//        public static Car operator * (Car car, double value)
//        {
//            return new Car() { SalesPrice = car.ListPrice * (decimal)value };
//        }
//        public static bool operator true(Car car)
//        {
//            return car.IsInStock;
//        }
//        public static bool operator false(Car car)
//        {
//            return car.IsInStock;
//        }

//        public static bool operator &(Car car1, Car car2)
//        {
//            if (car1.IsInStock && car2.IsInStock)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}
