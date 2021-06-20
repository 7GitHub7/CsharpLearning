using System;
using System.Collections.Generic;

namespace SandBox
{
    interface IVehicle
    {
        void getName();
        void getType();

    }
    public class Car : IVehicle
    {

        public void getName()
        {
            throw new NotImplementedException();
        }

        public void getType()
        {
            throw new NotImplementedException();
        }
        void printRoad() {
            Console.WriteLine("ss");
        }

    }

    public class Start
    {

        // Main Method
        static public void Main(String[] args)
        {
            List<IVehicle> CarList = new List<IVehicle>();
            CarList.Add(new Car());


            Console.WriteLine("Main Method");
        }
    }
}
