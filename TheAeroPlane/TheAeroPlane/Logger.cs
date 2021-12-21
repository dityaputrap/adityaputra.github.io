using System;

namespace TheAeroPlane
{
    class Logger
    {
        public void info(string message)
        {
            Console.WriteLine("info\t : " + message);
        }

        public void warning(string message)
        {
            Console.WriteLine("warning\t : " + message);
        }

        public void error(string message)
        {
            Console.WriteLine("error\t : " + message);
        }
    }
}
