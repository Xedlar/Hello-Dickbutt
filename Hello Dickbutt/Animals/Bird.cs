using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    // derived class
    public class Bird : AAnimalBase
    {
        public Bird()
        {
            _maxStomachCapacity = 10;
            _animalName = "bird";
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Cheep cheep.");
        }

        public override string ToString()
        {
            return "Hurr durr, I'm a bird, with Stomach " +StomachCapacity;
        }
    }
}
