using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    public class Dog : AAnimalBase
    {
        public Dog()
        {
            _maxStomachCapacity = 80;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Woof.");
        }
    }
}
