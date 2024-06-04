using System;

namespace L_08_01
{
    public static class Log
    {
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }

        public static void Warning(string message)
        {
            Console.WriteLine("WARNING :: " + message);
        }

        public static void Error(string message)
        {
            Console.WriteLine("ERROR :: " + message);
        }
    }
}
