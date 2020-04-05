using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const int WheelsPrivate = 2;

        public string ColorPublic = "red";
        protected string numberProtected = "8098F5B7-DBD3-4F33";
        string _modelPrivate = "Honda";
        int _currentSpeed;

        protected int MaxSpeedProtected { get; set; } = 250;
        protected internal int CurrentSpeedProtectedInternal
        {
            get { return _currentSpeed; }
            set
            {
                if (value >= 0 && value <= MaxSpeedProtected)
                    _currentSpeed = value;
                else
                    Console.WriteLine("Something is wrong");
            }
        }

        public void ChooseModel (string model)
        {
            _modelPrivate = model;
            
            switch (_modelPrivate)
            {
                case "Yamaha":
                    MaxSpeedProtected = 300;
                    break;
                case "Kawsaki":
                    MaxSpeedProtected = 220;
                    break;
                case "BMW":
                    MaxSpeedProtected = 320;
                    break;
                case "Harley":
                    MaxSpeedProtected = 280;
                    break;
                default:
                    Console.WriteLine("Choose another model");
                    break;
            }            
        }
        internal void GetInfo()
        {
            Console.WriteLine($"{WheelsPrivate} Wheels \n{ColorPublic} \n{numberProtected} \n{_modelPrivate} \n{_currentSpeed} km/h \n{MaxSpeedProtected} km/h");
        }
    }
}
