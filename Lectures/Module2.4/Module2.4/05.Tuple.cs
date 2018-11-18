////https://msdn.microsoft.com/en-us/magazine/mt493248.aspx
////Tuple
////Кортеж

//using System;

//namespace Module2._4
//{
//   public class Program
//    {
//        static void Main(string[] args)
//        {
//            //Dimensions dimensions = new Dimensions()
//            //{
//            //    Height = 10,
//            //    Width = 11,
//            //    Length = 12
//            //};
//            //(int Height, int Width, int Length) dim = (11, 12, 13);
//            //Console.WriteLine(dim.Length);
//            //ValueTuple
//            //Console.WriteLine(dim.GetType());
//            // (int Height, int Width, int Length) = (11, 12, 13);
//            var dim = Return();
//            Console.WriteLine(dim.Height);

//        }

//        static (int Height, int Width, int Length) Return()
//        {
//            int j = new Random(10).Next();
//            int k = new Random(10).Next();
//            int m = new Random(10).Next();
//            return (j, k, m);
//        }
//       // private struct Dimensions 
//       // {
//       //     public int Height { get; set; }
//       //     public int Width { get; set; }
//       //     public int Length { get; set; }
//       // }
//    }

//}

