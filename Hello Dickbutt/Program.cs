using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Important code below here

            string dog = "woof";
            string cat = "meow";

            Console.WriteLine(dog); // this will display the word woof as the string in the parenthesis is dog and dog = woof as per string line above
            Console.WriteLine(cat);

            int first = 1;
            int second = 2;
            int third = first + second;
            Console.WriteLine(third); // this will add the first two intergers to result in an answer
            // WriteLine will return to a new line, Write will display two 

            int one = 1;
            int two = 2;
            Console.WriteLine(1 + 2); // this simplifies the above

            int begin = 1;
            double andthen = 2.5;
            Console.WriteLine(begin + andthen); // double lets you add decimals






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
