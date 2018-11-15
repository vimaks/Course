using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Bonuses
{
    Melee = 0,
    Fire = 1,
    Ise = 2,
    Poison = 4
}

public struct Bonus
{
    public Bonuses bonusType;
    public char iconDamage;
    public Bonus(Bonuses bonusType, char iconDamage)
    {
        this.bonusType = bonusType;
        this.iconDamage = iconDamage;
    }
}

namespace GameTask
{
    class Program
    {
        public static List<Bonus> bonus = new List<Bonus>();
        static void Main(string[] args)
        {
            
            EnterKey();
        }

        static void EnterKey()
        {
            Console.WriteLine("Plese enter key fo attack p - poison, m - melee, f - fire, i - ice");
            string key = Console.ReadLine();

            if (key.Equals("m"))
            {
                bonus.Add(new Bonus(Bonuses.Melee, 'm'));
                BonusCheck();
            }
            else if (key.Equals("f"))
            {
                bonus.Add(new Bonus(Bonuses.Fire, '*'));
                BonusCheck();
            }
            else if (key.Equals("i"))
            {
                bonus.Add(new Bonus(Bonuses.Ise, '*'));
                BonusCheck();
            }
            else if (key.Equals("p"))
            {
                bonus.Add(new Bonus(Bonuses.Poison, 'p'));
                BonusCheck();
            }
            else
            {
                Console.WriteLine("Plese enter keys p - poison, m - melee, f - fire, i - ice");
                EnterKey();
            }



        }

        static void BonusCheck()
        {
            if (bonus.Count > 4)
            {
                bonus.RemoveRange(0,4);
            }
            bool iceCheck = false;
            bool fireCheck = false;
            foreach(Bonus bonusCheck in bonus)
            {
                if (bonusCheck.bonusType == Bonuses.Fire)
                    fireCheck = true;
                if (bonusCheck.bonusType == Bonuses.Ise)
                    iceCheck = true;
            }
            if (iceCheck & fireCheck)
            {
                try
                {

                    foreach (Bonus bonusCheck in bonus)
                    {
                        if (bonusCheck.bonusType == Bonuses.Fire)
                            bonus.Remove(bonusCheck);
                    }
                }
                catch (System.InvalidOperationException)
                {
                    try
                    {

                        foreach (Bonus bonusCheck in bonus)
                        {
                            if (bonusCheck.bonusType == Bonuses.Ise)
                                bonus.Remove(bonusCheck);
                            iceCheck = false;
                            fireCheck = false;
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        BonusPrint();
                    }
                }
            }
            BonusPrint();
        }

        static void BonusPrint()
        {
            foreach (Bonus bonusCheck in bonus)
            {
                if (bonusCheck.bonusType == Bonuses.Fire)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (bonusCheck.bonusType == Bonuses.Ise)
                    Console.ForegroundColor = ConsoleColor.White;
                else if (bonusCheck.bonusType == Bonuses.Poison)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (bonusCheck.bonusType == Bonuses.Melee)
                    Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write($"{bonusCheck.iconDamage.ToString()}");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            EnterKey(); //example
        }
    }
}
