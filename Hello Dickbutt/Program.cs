using System;
using System.Collections.Generic;
using System.Windows;

namespace Hello_Dickbutt
{
    public struct Whatever
    {
        int a;
        int b { get; set; }

        void DoSomething()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Important code below here
            // PlayingWithForLoops();
            //PlayingWithInheritance();

            PlayingWithStructures();

            Console.ReadLine();
        }

        #region Basic Programming

        public static void PlayingWithList()
        {
            int blah = 3;
            bool isStupid = true;

            List<int> numbers = new List<int>();   // 1, 3, 2

            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(2);

            List<string> words = new List<string>(); // dick, butt, salami

            words.Add("dick");
            words.Add("butt");                   // index list, position of list starts at zero, because it's dumb
            words.Add("salami");

            //string somethingElse = words[2];

            Console.WriteLine(words[1]);

            words[1] = "blah blah blah";    // dick, blah blah blah, salami

            Console.WriteLine(words[1]);

            words.Remove("blah blah blah");  // dick, salami

            Console.WriteLine(words[1]);

            words.Clear();   // nothing in the list

            words.Add("something");
            words.Add("what waht");

            Console.WriteLine(words[1]);

            List<int> moreNumbers = new List<int>() { 1, 5, 17, 2 }; //so you don't have to type numvers.Add(1);

            List<bool> whyWouldYouEverDoThis = new List<bool>() { true, false, false, true, true };
        }

        public static void PlayingWithForLoops()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("The variable i is currently: ");
                Console.WriteLine(i);
            }

            Console.WriteLine("!!!!!NEW LINE!!!!!");

            List<string> words = new List<string>() { "dick", "butt", "salami", "moo" };
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }

            List<int> numbers = new List<int>();
            for (int i = 0; i < 300; i++)
            {
                numbers.Add(i);
            }
            
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void PlayingWithErrors()
        {
            List<string> words = new List<string>() { "dick", "butt", "salami", "moo" }; //can you here me now?

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(words[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The rest");
        }

        public static void PlayingWithBooleans()
        {
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

        #endregion // Basic Programming

        #region Classes

        public static void PlayingWithClasses()
        {
            Car myFirstCar = new Car();
            //myFirstCar._color = "Blue";
            myFirstCar.SetColor("Dickbutt");
            myFirstCar.Color = "Black";
            myFirstCar.MoveForward();
            myFirstCar.MoveForward();
            myFirstCar.MoveForward();
            Console.WriteLine(myFirstCar);

            int something = myFirstCar.DistanceTravelled;
            //myFirstCar._color = "Orange";

            Car mySecondCar = new Car();
            //mySecondCar._color = "Red";
            mySecondCar.MoveForward();
            mySecondCar.MoveBackward();

            Car mythirdCar = new Car();
            //mythirdCar._color = "Hot Pink";
            mythirdCar.MoveForward();
            mythirdCar.MoveForward();
            mythirdCar.MoveBackward();

            Math.Max(5, 1000);
            int answer = MathMe.Add(5, 6);
            int anotherAnswer = MathMe.Add(4, 7);
        }

        public static void PlayingWithInheritance()
        {
            Console.WriteLine("test");
            var bird = new Bird();
            bird.ToString();

        }

        #endregion // Classes

        #region Structures

        public static void PlayingWithStructures()
        {
            // ref vs val. Reference vs Value

            //var a = 5;

            //var c = a;

            //Console.WriteLine(c); //5

            //a = 10;

            //Console.WriteLine(c);

            //var aa = "5";

            //var cc = aa;

            //Console.WriteLine(cc);

            //aa = "10";

            //Console.WriteLine(cc);

            //var aaa = new List<int>();
            //aaa.Add(5);

            //var ccc = aaa;

            //foreach (var item in ccc)
            //{
            //    Console.WriteLine(item);
            //}

            //aaa = new List<int>();
            //aaa.Add(6);

            //foreach (var item in ccc)
            //{
            //    Console.WriteLine(item);
            //}

            var a = 5;
            a = 6;
            Console.WriteLine(a);

            IncreaseVariable(ref a);

            Console.WriteLine(a);

            var p = new Point(5, 5);
            p.Y++;

            p = new Point(5, 6);
        }

        public static void IncreaseVariable(ref int q)
        {
            q++;
        }

        #endregion // Structures
    }
}
