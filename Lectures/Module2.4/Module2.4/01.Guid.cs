//////https://docs.microsoft.com/en-us/dotnet/api/system.guid
//////https://stackoverflow.com/questions/371762/what-exactly-is-guid-why-and-where-i-should-use-it
//using System;
////2's complement notation
////Дополнительный код
///*
//0111  +
//0001
//1000

//1111
//1111
//0000
// */
//namespace Module2._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {            
//            //Guid guid = Guid.NewGuid();
//            ////Console.WriteLine(guid);
//            Guid empty = Guid.Empty;

//            Console.WriteLine(default(Guid));
            
//            Guid parsed = Guid.Parse("e08f2dcd-b1ac-4f7e-9d39-d42187dae870");

//            // Guid exactParsed = Guid.ParseExact("e08f2dcdb1ac4f7e9d39d42187dae871", "N");
           
//           byte[] bytes = parsed.ToByteArray();
//           int intFromGuid = BitConverter.ToInt32(bytes, 0);            

//            checked
//            {
//                //if overflow
//            }
//        }
//    }
//}

///*
//            decimal dec = 10M;
//            double dou = 10;
//            bool b = dec > (decimal)dou;
// */
