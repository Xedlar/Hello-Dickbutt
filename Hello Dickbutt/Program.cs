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
           
            // && = AND
            // ! = NOT
            // || = OR

            

            bool fun = true;
            bool funny = false;

            Console.WriteLine("if it's fun and funny");

            bool yesisTrue = fun && !funny;

            if (yesisTrue)
            {
                Console.WriteLine("You better not laugh your arse off");

            }
            else
            {
                Console.WriteLine("Oh look how dumb your face became.");




            }
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
