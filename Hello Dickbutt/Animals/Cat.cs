using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    public class Cat : AAnimalBase
    {
        public Cat()
        {
            _maxStomachCapacity = 60;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow.");
        }

        public virtual void Eat(int amountOfFood)
        {
            //StomachCapacity = StomachCapacity + amountOfFood;
            StomachCapacity += amountOfFood / 2;

            if (StomachCapacity > _maxStomachCapacity)
            {
                Console.WriteLine("Your " + _animalName + " is dead, it exploded.");
            }
        }
    }
}
