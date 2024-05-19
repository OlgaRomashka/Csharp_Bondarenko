using System;

namespace Lesson_03
{ 
    {
        static void Main()
        {
            Factorial_1();
            Factorial_2();
            CounterSpaces();
            PositiveNegativeNumbers();
        }
//-------------------------------------------------------------
        static void PositiveNegativeNumbers()
        {

            int number = InputNumber();

            if (number == 0)
            {
                Console.Write (" число равно 0 ");
            }
            else
            {
                int result = ((number >> 31) & 1);

                bool Negative = Convert.ToBoolean(result);

                if (Negative)
                {
                    Console.Write(number + " - число отрицательное");
                }
                else
                {
                    Console.Write(number + " - число положительное");
                }  
            }
                
            static int InputNumber()
            {
                Console.Write(("Введите целое число отличное от 0: "));
                string input = Console.ReadLine();

                int number;

                while (!int.TryParse(input, out number))
                    {
                    input = Console.ReadLine();
                    }
                return number;
            }

        }

       // ---------------------------------------------------------------------
        static void CounterSpaces()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            int result = Spaces(input);

            PrintSpaces(result);

            static int Spaces(string text)
            {
                int i = 0;

                foreach (char space in text)
                {
                    if (space == ' ')
                    {
                        i++;
                    }
                }
                return i;
            }

            static void PrintSpaces(int result)
            {
                if (result == 0)
                {
                    Console.WriteLine("No spaces");
                }
                else
                {
                    Console.WriteLine("Spaces: " + result);
                }
            }
        }
       // ---------------------------------------------------------------------
        static void Factorial_2()
        {
            uint number = GetNumberFromInput();

            var result = Factorial(number);
            Console.WriteLine("Factorial of a number: " + number + " is: " + result);

        }
        static uint GetNumberFromInput()
        {
            Console.Write(("Enter number factorial: "));
            string input = Console.ReadLine();

            uint number;

            while (!uint.TryParse(input, out number))
            {
                input = Console.ReadLine();
            }
            return number;
        }

        static uint Factorial(uint number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        //-----------------------------------------------------------------------------
        static void Factorial_1()
        {
            Console.Write("Enter number factorial: ");
            var resultFactotial = Console.ReadLine();

            uint result;

            while (!uint.TryParse(resultFactotial, out result))
            {
                Console.Write("Enter number factorial: ");
                resultFactotial = Console.ReadLine();
            }

            if (result == 1)
            {
                Console.Write("Factorial of a number: " + result + " is: " + 1);
            }
            else
            {
                ulong f = 1;
                for (uint i = result; i > 1; i--)
                {
                    f = f * i;

                }
                Console.Write("Factorial of a number: " + result + " is: " + f);
            }
        }


    }
}
