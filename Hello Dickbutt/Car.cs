using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    class Car
    {
        public Car()
        {

        }

        #region Fields / Members  // Fields are named with _lowerCase

        public string _color = "Black";
        public int _distanceTravelled = 0;

        #endregion

        #region Methods

        public void MoveForward()
        {
            Console.WriteLine("My car " + _color + " is moving foward.");
            _distanceTravelled = _distanceTravelled + 10;

        }

        public void MoveBackward()
        {
            Console.WriteLine("My car " + _color + " is moving backwards.");
            _distanceTravelled = _distanceTravelled - 10;
        }

        public void DistanceTravelled()
        {
            Console.WriteLine(_distanceTravelled);
        }

        #endregion
    }
}
