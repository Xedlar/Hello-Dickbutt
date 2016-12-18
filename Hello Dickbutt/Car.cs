using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dickbutt
{
    public class Car
    {

        public Car()
        {
        }

        #region Fields / Members  // Fields are named with _lowerCase




        #endregion

        #region Properties

        public int NumberOfWheels { get; set; }

        private int _distanceTravelled = 0;
        public int DistanceTravelled
        {
            get { return _distanceTravelled; }
            private set { _distanceTravelled = value; }
        }

        private string _color = "Black";
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                switch (value)
                {
                    case "Red":
                    case "Blue":
                    case "Green":
                        _color = value;
                        break;
                    case "Pink":
                        Console.WriteLine("Rad color choice");
                        _color = value;
                        break;
                    default:
                        Console.WriteLine("Not allowed to set color to " + value);
                        break;
                }
            }
        }

        #endregion

        #region Methods

        public void MoveForward()
        {
            Console.WriteLine("My car " + Color + " is moving foward.");
            DistanceTravelled = DistanceTravelled + 10;

            if (Color == "Black" && DistanceTravelled > 20)
            {
                NumberOfWheels--;
            }

        }

        public void MoveBackward()
        {
            Console.WriteLine("My car " + Color + " is moving backwards.");
            DistanceTravelled = DistanceTravelled - 10;
        }

         public string GetColor()
        {
            return _color;
        }

        public void SetColor(string newColor)
        {
            //if (newColor == "Red")
            //{
            //    _color = newColor;
            //}
            //else if (newColor == "Green")
            //{
            //    _color = newColor;
            //}
            //else if (newColor == "Blue")
            //{
            //    _color = newColor;
            //}

            // Only works on strings and primitives.
            switch (newColor)
            {
                case "Red":
                case "Blue":
                case "Green":
                    _color = newColor;
                    break;
                case "Pink":
                    Console.WriteLine("Rad color choice");
                    _color = newColor;
                    break;
                default:
                    Console.WriteLine("Not allowed to set color to " + newColor);
                    break;
            }
        }

        #endregion
    }
}
