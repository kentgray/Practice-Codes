﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Program
    {
        if (true)
	{

	}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please:");

            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
