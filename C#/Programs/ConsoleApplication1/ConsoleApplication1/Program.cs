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

            int[] randNumArray;

            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5 };

            int[,] multArray = new int[5, 3];

            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for(int x= 0; x < multArray2.GetLength(0); x++)
            {
                for(int y= 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                }

            }

            /* Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            string nameStr = string.Join(",", names);

            string[] nameArray = nameStr.Split(',');

            /*   Console.WriteLine("Array Length " + randArray2.Length);

            Console.WriteLine("Item 0 " + randArray2[0]);

            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, randArray2[i]);
            }

            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }
            /*   StringBuilder sb = new StringBuilder();

               sb.Append("This is the first sentence. ");
               sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Pennsylvania");

               sb.Replace("a", "e");

               sb.Remove(5, 7);

               Console.WriteLine(sb.ToString());


               /* string sampString = "A bunch of random words";

               string sampString2 = "More random words";

               string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

               Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));

               /* sampString = sampString.Replace("words", "characters");

               sampString = sampString.Remove(0, 2);

               string[] names = new string[3] { "Matt", "Joe", "Paul" };

               Console.WriteLine("Name List " + String.Join(",", names));

              //Console.WriteLine(sampString);

              // sampString = sampString.Trim(); TrimEnd TrimStart

               /*  Console.WriteLine("Strings Equal " + sampString.Equals(sampString2));

               Console.WriteLine("Starts with \"A bunch\" " + sampString.StartsWith("A bunch"));

               Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

               /*  Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));

               Console.WriteLine("2nd Word " + sampString.Substring(2, 6));

               /*(Console.WriteLine("Is empty" + String.IsNullOrEmpty(sampString));

               Console.WriteLine("Is empty" + String.IsNullOrWhiteSpace(sampString));

               Console.WriteLine("String Length" + sampString.Length);


               /* string randStr = "Here are some random character";

               foreach(char c in randStr)
               {
                   Console.WriteLine(c);

               }

               /* for (int i = 0; i < 10; i++)
               {
                   if((i % 2) > 0)
                   {
                       Console.WriteLine(i);
                   }    

               }

             /*  string guess;

               do
               {
                   Console.WriteLine("Guess a Number ");
                   guess = Console.ReadLine();


               } while (!guess.Equals("15"));

               /* int i = 0;

               while (i < 10)
               {
                   if (i == 7)
                   {
                       i++;
                       continue;
                   }

                   if (i == 9)
                   {
                       break;
                   }

                   if ((i % 2) > 0)
                   {
                       Console.WriteLine(i);
                   }
                   i++;
               }

              /* int age = 17;

               if ((age >= 5) && (age <= 7))
               {
                   Console.WriteLine("Go to elementary school");
               }
               else if ((age > 7) && (age < 13))
               {
                   Console.WriteLine("Go to middle school");
               }
               else
               {
                   Console.WriteLine("Go to high school");
               }

               switch (age)
               {
                   case 0:
                       Console.WriteLine("Infant");
                       break;
                   case 1:
                   case 2:
                       Console.WriteLine("Toddler");
                   default:
                       Console.WriteLine("Child");
                       break;
                      // goto Cute;
               }

             //  Cute:
             //  Console.WriteLine("Toddlers are Cute");





               // int canDrive = age >= 16 ? 1 : 0;
               // bool canDrive = age >= 16 ? true : false;
               // Console.WriteLine("! true " + (!true));






               /*if ((age < 14) || (age > 67))
               {
                   Console.WriteLine("You shouldn't work");
               }


           /*  double number1 = 10.5;
               double number2 = 15;

               Random rand = new Random();
               Console.WriteLine("Random Number between 1 and 10 " + (rand.Next(1, 11)));


               /*
               Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
               Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
               Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
               Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
               Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
               Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
               Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
               Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));



             /*  double pi = 3.14
               int intPi = (int)pi;

              /* Console.WriteLine("5 + 3 = " + (5 + 3));
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
