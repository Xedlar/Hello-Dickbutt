using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    public class Bird
    {
        public Bird()
        {
            _stomachCapacity = 0;
        }

        #region Fields

        private int _maxStomachCapacity = 10;

        #endregion

        #region Properties

        private int _stomachCapacity;
        public int StomachCapacity
        {
            get { return _stomachCapacity; }
            private set { _stomachCapacity = value; }
        }

        #endregion

        #region Methods

        public void MakeNoise()
        {
            Console.WriteLine("Cheep cheep.");
        }

        public void Eat(int amountOfFood)
        {

        }

        #endregion
    }
}
