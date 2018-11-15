namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true;
            char ch = '1';
            byte b = 129;
            sbyte sb = -128;
            short sh = 10000;
            ushort ush = 25;
            int i = -223;
            uint ui = 300;
            long l = 100000;
            decimal de = 8;
            float fl = -33.1f;
            double d0 = -33.1;



            //2) declare constants of int and double. Try to change their values.

            const int intConst = 9;
            const double doubleConst = 3.14;
            //intConst = 10;
            //doubleConst = 9;


            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var someVar1 = 20; //int
            var someVar2 = 20.5; //double
            //someVar1 = 20.5; // Не удается неявно преобразовать тип "double" в "int".
            someVar2 = 20; // reinitialize ok.


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?

            System.Int32 int32Value = i;
            System.Double doubleValue = d0;

           

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                /*
                int i = -223;
                char ch = '1';
                double d0 = -33.1;
                */
                //not possible

                // 6) change values of variables from 1)

                boo = false;
                ch = 'A';
                b = 29;
                sb = -118;
                sh = 30000;
                ush = 225;
                i = 23;
                ui = 100;
                l = 1000;
                de = 83;
                fl = -3344.1f;
                d0 = -335.1;



            }

            // 7)check values of variables from 1). Are they changed? Think, why

            System.Console.WriteLine(boo);
            System.Console.WriteLine(ch);
            System.Console.WriteLine(b);
            System.Console.WriteLine(sb);
            System.Console.WriteLine(sh);
            System.Console.WriteLine(ush);
            System.Console.WriteLine(i);
            System.Console.WriteLine(ui);
            System.Console.WriteLine(l);
            System.Console.WriteLine(de);
            System.Console.WriteLine(fl);
            System.Console.WriteLine(d0);
            System.Console.ReadLine();

            //Yes, variables are changed

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            // bool -> short
            //short boolToShort = (short)boo; //not possible

            // double -> long
            long doubleToLong = (long)d0; //обрезается переменная

            // float -> char 
            char floatToChar = (char)fl; //вывод не соответствует значению, хотя ошибок нет.
            // int to char
            char intToChar = (char)i; //вывод не соответствует значению, хотя ошибок нет.
            // decimal -> double
            double decimalToDouble = (double)de;
            // byte -> uint
            uint byteToUint = b;
            // ulong -> sbyte
            ulong ul = 2566687;
            sbyte ulongToSbyte = (sbyte)ul; //обрезается переменная

            System.Console.WriteLine(doubleToLong);
            System.Console.WriteLine(floatToChar);
            System.Console.WriteLine(intToChar);
            System.Console.WriteLine(decimalToDouble);
            System.Console.WriteLine(byteToUint);
            System.Console.WriteLine(ulongToSbyte);
            System.Console.ReadLine();

            // 9) and reverse conversion with fixing compilation errors.

            // double -> long
            double longToDouble = doubleToLong; 

            // float -> char 
            float charToFloat = floatToChar; //вывод не соответствует значению, хотя ошибок нет.
            // int to char
            int charToInt = intToChar;
            // decimal -> double
            decimal doubleToDecimal = (decimal)decimalToDouble;
            // byte -> uint
            byte uintToByte = (byte)byteToUint; // перевелось, но обрезалось если бы была болше переменная
            // ulong -> sbyte
            ulong sbyteToUlong = (ulong)ulongToSbyte; 

            System.Console.WriteLine(longToDouble);
            System.Console.WriteLine(charToFloat);
            System.Console.WriteLine(charToInt);
            System.Console.WriteLine(doubleToDecimal);
            System.Console.WriteLine(uintToByte);
            System.Console.WriteLine(sbyteToUlong);
            System.Console.ReadLine();

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int ?nullableInt = null;
            //i = null; //not possible
            //i = nullableInt; // not possible


        }
    }
}
