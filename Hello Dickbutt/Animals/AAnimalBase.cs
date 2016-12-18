using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    // base class
    public abstract class AAnimalBase
    {
        protected AAnimalBase()
        {
            //
        }

        #region Fields

        protected int _maxStomachCapacity = 0;
        protected string _animalName = "";
        #endregion

        #region Properties

        private int _stomachCapacity = 0;
        public int StomachCapacity
        {
            get { return _stomachCapacity; }
            set { _stomachCapacity = value; }
        }

        #endregion

        #region Methods

        public abstract void MakeNoise();

        public virtual void Eat(int amountOfFood)
        {
            //StomachCapacity = StomachCapacity + amountOfFood;
            StomachCapacity += amountOfFood;

            if (StomachCapacity > _maxStomachCapacity)
            {
                Console.WriteLine("Your " + _animalName + " is dead, it exploded.");
            }
        }

        public void Poop()
        {
            StomachCapacity -= 5;
            if (StomachCapacity < 0)
            {
                StomachCapacity = 0;
            }
        }

        #endregion
    }
}
