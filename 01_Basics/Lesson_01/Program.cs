using System;


namespace Lesson_01
{
    internal class Program
    {
        static void Main()
        {
            //Task01();
            SayHello();

        }



        static void SayHello()
        {
            string hello = ("Hello Ivan!");
            Console.Write(hello);
        }

        static void Task01()
        {
            int i = 5;
            int j = 7;
            if (i > j)
            {
                Console.Write(i + ", " + j);
            }
            else
            {
                Console.Write(j + ", " + i);
            }
        }


    }
}
