using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            //privte constant -> not available
            //int motoWheels = Motorcycle.WheelsPrivate;

            moto.ColorPublic = "Black";

            //protected field -> not available
            //moto.numberProtected = "4E257010-A74C-453C";

            //privte field -> not available
            //string motoModel = moto._modelPrivate;

            //privte field -> not available
            //int motoSpeed = moto._currentSpeed;

            //protected property -> not available
            //moto.MaxSpeedProtected = 180;

            //protected internal property
            //moto.CurrentSpeedProtectedInternal = 60;

            moto.ChooseModel("BMW");

            //internal method
            //moto.GetInfo();     

            //class SportBike is internal
            //SportBike sport = new SportBike();
        }
    }
}
