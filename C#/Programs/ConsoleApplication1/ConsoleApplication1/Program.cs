using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));

           /* bool canVote = true;

            char grade = 'A';

            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);

            var anotherName = "Tom";

            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());*/

            /*       Console.WriteLine("What is your name");
                   string name = Console.ReadLine();
                   Console.WriteLine("Hello " + name); */
        }
    }
}
