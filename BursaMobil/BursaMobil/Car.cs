using System;
using System.Collections.Generic;
using System.Text;

namespace BursaMobil
{
    class Car
    {
        private void checkAccu()
        {
            Console.WriteLine("checkup accu");
        }

        private void checkRadiator()
        {
            Console.WriteLine("checkup radiator");
        }

        public void checkFuel()
        {
            Console.WriteLine("checkup fuel");
        }

        public virtual void startEngine()
        {
            checkAccu();
            checkRadiator();
            checkFuel();
        }
    }
}
