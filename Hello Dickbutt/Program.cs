﻿using System;

namespace Hello_Dickbutt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Important code below here

            bool blah = true;
            bool glarg = false;
            bool lala = true;

            Console.WriteLine("Before Testing for true.");
            // && = AND
            // ! = NOT
            // || = OR

            bool isTrue = !(glarg && blah) || false && true || !false;

            if (isTrue)
            {
                Console.WriteLine("The thing was true.");
            }
            else
            {
                Console.WriteLine("The thing was not true.");
            }

            Console.WriteLine("After testing for true.");

            Console.ReadLine();
        }

        public static void DoSomething()
        {
            Console.WriteLine("Doing one thing");
            Console.WriteLine("Doing another thing");
            Console.WriteLine("Doing the last thing");
        }

        public static void DoSomethingElse()
        {
            Console.WriteLine("Doing the thing");
        }

        public static void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        public static int Add(int a, int b, string s)
        {
            return a + b;
        }
    }
}
