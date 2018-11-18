using System;

namespace Module2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Civic", 60000M, new Engine() { Type = "Internal Combastion", HorsePower = 1000 });
            Car otherCar = (Car)car.Clone();


            bool b = Object.ReferenceEquals(car.Engine, otherCar.Engine);

            Console.WriteLine(b);
           // Console.WriteLine(car.Engine.Equals(otherCar.Engine));
           // var another = new Car(car.Make, car.Model, car.Price);
        }
    }

    class Car : ICloneable
    {
        public Car(string make, string model, decimal price, Engine engine )
        {
            Make = make;
            Model = model;
            Price = price;
            Engine = engine;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal  Price { get; set; }
        public Engine Engine { get; set; }
        public object Clone()
        {
            
           // return new Car(this.Make, this.Model, this.Price, this.Engine); // shallow copy
           return new Car(this.Make, this.Model, this.Price, new Engine() { Type = this.Engine.Type, HorsePower = this.Engine.HorsePower }); //deep copy 
            //IClonable должен реализовывать deep copy

            //вариант возврата shallow copy
          //  return this.MemberwiseClone();
        }
    }

    class Engine
    {
        public string Type { get; set; }
        public double HorsePower { get; set; }
    }
}
