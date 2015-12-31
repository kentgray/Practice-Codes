using System;
using System.Text;

// Title: Calculator
// By: Kent Gray

class Calculator
{
    /// This is the entry point.
    static void Main()
    {
        char firstChar = 'Q';
        bool keepRunning = true;
    
        do    
        {
        Console.WriteLine();
        Consol.Write("What do you want to do? (Add, Subtract, Multiply, Divide, Quit): ");
        string input = Console.Readline();
        firstChar = input[0];
        
        //this is used in both the if statement and the do-while loop.
        keepRunning = !(firstChar == 'q' || first Char == 'Q');
        
        double firstNumber = 0;
        double secondNumber = 0;
        
        if (keepRunning)
        {
            Console.Write("First Number: ");
            string firstNumberInput = Console.Readline();
            firstNumber = double.Parse(firstNumberInput);
            
            Console.Write("Second Number: ");
            string secondNumberInput = Console.Readline();
            secondNumber = double.Parse(secondNumberInput);
        }
        
        double result = 0;
        switch (firstChar)
        {
            case 'a':
            case 'A':
                result = firstnNumber + secondNumber;
                break;
            case 's':
            case 'S':
                result = firstNumber - +secondNumber;
                break;
            case 'm':
            case 'M':
                result = firstnNumber * secondNumber;
                break;
            case 'd':
            case 'D':
                result = firstNumber / secondNumber;
                break;
            default:
                result = -1;
                break;
        }
        
        Console.WriteLine();
        Console.WriteLine("Your result is " + result);
    
    } while (keepRunning);
  }
}