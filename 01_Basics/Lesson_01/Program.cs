using System;


namespace Lesson_01
{
    internal class Program
    {
        static void Main()
        {
            //SortNumbers();
            //SayHello();
            //SayHelloUser();
            //CalculateAreaSquare();
            // CalculateAreaCircle();
            //CalculateTwoNumbers();
            //PictureA();
            //PictureB();
            PictureC();
        }

        static void PictureC()
        {
            var count = 12;

            for (var y = count; y > 0; y--)
            {
               
                for (var x = 0; x <= count; x++)
                {
                    if (x < y)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("+ ");
                    }
                   
                }
               
                Console.WriteLine();
            }
        }

        static void PictureB()
        {
            for (var y = 0; y < 10; y++)
            {
                for (var x = 0; x <= y; x++)
                {
                    Console.Write("#  ");
                }
                Console.WriteLine();
            }
        }

         static void PictureA()
        {
            for (var y = 10; y > 0; y--)
            {
                for (var x = 0; x < y; x++)
                {
                    Console.Write("#  ");
                }
                Console.WriteLine();
            }
        
        }


        static void CalculateTwoNumbers()
        {
            double result1;
            double result2;

            Console.Write("Input first number:");
            var input1 = Console.ReadLine();

            Console.Write("Input second number:");
            var input2 = Console.ReadLine();

            bool success1 = double.TryParse(input1, out result1);
            bool success2 = double.TryParse(input2, out result2);

            if (success1 && success2)
            {
                if (result1 > result2)
                {
                    Console.Write("result:" + result1 * result2);
                }
                else 
                {
                    if (result2 != 0)
                    {
                        Console.Write("result:" + result1 / result2);
                    }
                    else
                    {
                        Console.Write("delenie na 0");
                    }
                }

            }
            else
            {
                Console.Write("Input is not correct");
            }
        }

        static void CalculateAreaCircle()
        {
            double PI = Math.PI;
            Console.Write("Input square radius circle:");
            var input = Console.ReadLine();
              double result;
              bool Success = double.TryParse(input, out result);
            if (Success)
            {
                Console.Write("Square area = " + result * result * PI);
            }
            else
            {
                Console.Write("Input is not correct");
            }
        }


        static void CalculateAreaSquare()
        {
            Console.Write("Input square side length:");

            var input = Console.ReadLine();
            double result;
            bool Success = double.TryParse(input, out result); // true / false

            if (Success)
            {
                //если парсинг успешный - считаем площадь
                Console.Write("Square area = " + result * result);
            }
            else
            {
                //если парсинг НЕ успешный - ругаем пользователя
                Console.Write("Input is not correct");
            }

            //Console.ReadKey();
        }



        static void SayHelloUser()
        {
            for (var i = 0; i< 14; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine("/" + "Hello, user!" + "\\");
            for (var j = 0; j < 16; j++) 
            {
                Console.Write("=");
            }
        }


        static void SayHello()
        {
            string hello = ("Hello Ivan!");
            Console.Write(hello);
        }

        static void SortNumbers()
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
