//////https://docs.microsoft.com/ru-ru/dotnet/api/system.datetime?view=netframework-4.7.2
//////https://blogs.msdn.microsoft.com/bclteam/2007/06/18/a-brief-history-of-datetime-anthony-moore/
//////https://www.timeanddate.com/worldclock/timezone/utc

/////Azure Cloud
/////DateTime.Now = DateTime.UtcNow для Ажура
//using System;
//using System.Globalization;

//namespace Module2._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine(default(DateTime));
//            //DateTime dateTime = new DateTime(); 
//            //var now = DateTime.Now;
//            //Console.WriteLine(now);
//            //var utcNow = DateTime.UtcNow;
//            //Console.WriteLine(utcNow);

//            //DateTime dateTime = new DateTime(2018,11,16,12,12,12);
//            //Console.WriteLine(dateTime);
//            //DateTime dateTime = new DateTime(56767868678678);
//            //Console.WriteLine(dateTime);

//            //DateTime date = DateTime.MaxValue;
//            //Console.WriteLine(date);
//            //DateTime date = DateTime.Now.AddDays(-5);
//            //Console.WriteLine(date);
//            // var value = DateTime.Now.DayOfWeek;
//            // Console.WriteLine(value);

//           // DateTime date = DateTime.Now;
//            // Console.WriteLine(date.ToString());
//            // Console.WriteLine(date.ToShortTimeString());
//            // Console.WriteLine(date.ToLongDateString());

//            // string str = date.ToLongDateString();
//            // Console.WriteLine(str);
//            // DateTime dt = DateTime.Parse(str);
//            // Console.WriteLine(dt);
//            //to sting + culture + DateTimeFormatInfo
//            //2008-09-15T15:53:00 ISO 8601  -- ISO format 

//           // DateTime dt = DateTime.Parse("2008-09-15T15:53:00");
//           // CultureInfo cultureInfo = new CultureInfo("ru-RU");
//           // Console.WriteLine(dt.ToString(cultureInfo.DateTimeFormat.ShortDatePattern));
//           //
//           // CultureInfo usFormat = new CultureInfo("en-US");
//           // Console.WriteLine(dt.ToString(usFormat.DateTimeFormat.ShortDatePattern));
//        }
//    }
//}
