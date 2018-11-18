using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    public enum CurrencyTypes
    {
        //Uknown,
        UAH,
        USD,
        EU
    }

    public class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public decimal Amount { get; set; }
        public CurrencyTypes Types { get; set; }
        // 3) declare parameter constructor for properties initialization
        public Money(decimal amount, CurrencyTypes types )
        {
            Amount = amount;
            Types = types;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money money1, Money money2)
        {
            if (money1.Types == money2.Types)
            {
                return new Money(money1.Amount + money2.Amount, money1.Types);
            }else
            return null;
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money money1)
        {
            money1.Amount = money1.Amount - 1;
            return money1;
        }
        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money money1, Money money2)
        {
            money1.Amount = money1.Amount * 3;
            return money1;
        }
        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money money1, Money money2)
        {
            if (money1.Amount > money2.Amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Money money1, Money money2)
        {
            if (money1.Amount < money2.Amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object
        
        public static bool operator true(Money money1)
        {
            
            Console.WriteLine(money1.Types);
            return true;
        }

        public static bool operator false(Money money1)
        {

            Console.WriteLine(money1.Types);
            return false;
        }
        
        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static explicit operator double(Money money)
        {
            return Convert.ToDouble(money.Amount);
        }

        public static explicit operator string(Money money)
        {
            //ok, но я б еще код валюты учел
            //return money.Amount.ToString();

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            //такой формат создания строки  - знак доллара и фигурные скобки - интерполяция
            return $"{money.Types.ToString()} {money.Amount}";
        }


        public static implicit operator Money(string value)
        {
            //мы это не рассматривали, но в задании оно есть
            // Enum.Parse - механизм приведения строки к енумке: в метод передали тип и строку, на выходе получили object который привели к нужному типу
            //string.Split() - получения массива стрингов по разделителю (пробел, запятая и т.п.)
            //value.Split()[0] вернет нам значение до пробела
            //value.Split()[1] вернет нам значение после пробела
            string strCur = value.Split()[0];
            CurrencyTypes currency = (CurrencyTypes)Enum.Parse(typeof(CurrencyTypes), strCur);
            string strAmount = value.Split()[1];
            decimal amount = decimal.Parse(strAmount);
            return new Money(amount, currency);
        }

    }
}
