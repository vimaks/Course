//using System;

//namespace Module2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Vehicle vehicle = new Vehicle()
//            {
//                Make = "Honda",
//                Model = "Accord"
//            };
//            Car car = vehicle;
//            Bike bike = (Bike)vehicle;

//            Console.WriteLine(car.Model);
//            Console.WriteLine(car.Make);
//        }
//    }

//    class Vehicle
//    {
//        public ModeOfTransportation Mode { get; set; }
//        public string Model { get; set; }
//        public string Make { get; set; }

//        public static  implicit  operator Car(Vehicle vehicle)
//        {
//            return new Car() { Model = vehicle.Model, Make = vehicle.Make };
//        }

//        public static explicit operator Bike(Vehicle vehicle)
//        {
//            return new Bike() { Make = vehicle.Make };
//        }        
//    }
//    class Car
//    {
//        public string Model { get; set; }
//        public string Make { get; set; }
//    }

//    class Bike
//    {
//        public string Make { get; set; }
//    }
//    enum ModeOfTransportation
//    {
//        Land,
//        Water,
//        Air
//    }
//}
