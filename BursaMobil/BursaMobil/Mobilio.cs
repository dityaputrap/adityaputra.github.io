using System;
using System.Collections.Generic;
using System.Text;

namespace BursaMobil
{
    class Mobilio : Car
    {
        public override void startEngine()
        {
            Console.WriteLine("Mobilio preparation....");
            base.startEngine();
            lockTheDoor();
        }

        private void lockTheDoor()
        {
            Console.WriteLine("Mobilio lock the door");
        }
    }
}
