using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _8_Ball
{
    //class KG
    //{
    //    private static string name = "KG";
    //    public static string alias = "awe";
    //    private static int age = 31;
    
    }

// Entry point for the magic 8 Ball Program
    class Program
    {
        static void Main(string[] args)
        {
        // Preserve current console text color
        ConsoleColor oldColor = Console.ForegroundColor;

        TellPeopleWhatProgramThisIs();

        // Create a randomizer ovject
        Random randomObject = new Random();
        
        // Loop forever
        while (true)
        {
            string questionString = GetQuestionFromUser();

            
            // Make the computer pause between 1 and 5 seconds before giving an answer...
            int numberOfSecondsToSleep =  randomObject.Next(5) + 1;
            Console.WriteLine("Thinking about your answer, stand by...");
            Thread.Sleep(numberOfSecondsToSleep * 1000);
        
            if (questionString.Length == 0)
            {
                Console.WriteLine("You need to type a question silly sally!");
                continue;
            }

            // See if the user typed 'quit' as the question
            if (questionString.ToLower() == "quit")
            {
                break;
            }
            
            if( questionString.ToLower() == "who")
            {
                Console.WriteLine("You need to ask yes or no questions only");
                continue;
            }

            // I user insults with you no good then retort accordingly
            if( questionString.ToLower() == "you no good")
            {
                Console.WriteLine("You really no good. Oh burn!");
                break;
            }
            // Get a random number
            int randomNumber = randomObject.Next(4);

            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

            // Use Random number to determine response
            switch (randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("YES!");
                        break;
                    }
                   
                case 1:
                    {
                        Console.WriteLine("Maybe");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Way Off!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("For Shizzle!");
                        break;
                    }

            }

           // Console.WriteLine("{0}", randomObject.Next(10) + 1);
        }  // End of the while loop

        // Cleaning Up
        Console.ForegroundColor = oldColor;
        }

    // This will print the name of the program and who created it.
    static void TellPeopleWhatProgramThisIs()
    {
    // Change console text color
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.Write("M");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("agic 8 Ball (by: KG)");
    }

    // This function will return the text the user types
    static string GetQuestionFromUser()
    {
        // This block of code will ask the user for a question
        // and store the question text in questionString variable
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ask a question?: ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        string questionString = Console.ReadLine();

        return questionString;
    }
}
