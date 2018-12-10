using System;
using System.Collections;
using System.Collections.Generic;

namespace StackTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ")(dVSDv ( DVDSV) (SDVDSVS )DSVDvSDV ) dSVSDv(DSVSDVSDv )SDVsDV ( SDVSDV( SDVDSV(SDVSDv )DSVDSV ) DVSDv)";
            bool b = BracketsCheck(text);
            
        }

        static bool BracketsCheck(string text)
        {
            Stack<char> stack = new Stack<char>();
            int counter = 0;


            foreach (char item in text)
            {
                if (item == '(')
                {
                    counter++;
                    stack.Push(item);
                }
                try
                {
                    if (item == ')' && stack.Pop() == '(')
                        counter--;
                }
                catch(System.InvalidOperationException)
                {
                     return false;
                }
            }
            if (counter != 0)
                return false;
            return true;
        }
    }
}
