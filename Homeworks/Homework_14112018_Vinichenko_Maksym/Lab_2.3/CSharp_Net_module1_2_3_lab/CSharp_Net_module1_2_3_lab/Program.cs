using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money money1 = new Money(100, CurrencyTypes.UAH);
            Money money2 = new Money(200, CurrencyTypes.UAH);
            // 11) do operations
            // add 2 objects of Money
            Money money3 = money1 + money2;
            Console.WriteLine($"{money3.Amount}  {money3.Types}");

            // add 1st object of Money and double
            money1.Amount = money1.Amount + (decimal)140.4d;

            // decrease 2nd object of Money by 1 
            money2--;

            // increase 1st object of Money
            money1 = money1 * money1;

            // compare 2 objects of Money

            bool b = money1 > money2;


            // compare 2nd object of Money and string
            // не понял задание
            // check CurrencyType of every object
            if (money1)
            {

            }
            if (money2)
            {

            }
            if (money3)
            {

            }
            // convert 1st object of Money to string
            string s = (string)money1;
            Console.ReadLine();

        }
    }
}
