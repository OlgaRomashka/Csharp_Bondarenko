using System;
namespace Lesson_02
{
    class Program
    {
        static void Main()
        {
            TwoNumber();
            Calculator();
            Fibonacci();
            Shop();
            MoveSguare();
        }
        static void MoveSguare()
        {
            int posX = 0;
            int posY = 0;
            var isStop = false;

            while (true)
            {
                Console.Clear();
                Draw(posX, posY, "# ");

                var key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (posX > 0) 
                        { posX--; }
                        break;

                    case ConsoleKey.RightArrow:
                        posX++;
                        break;

                    case ConsoleKey.UpArrow:
                        if (posY > 0) 
                        { posY--; }
                        break;

                    case ConsoleKey.DownArrow:
                        posY++;
                        break;

                    case ConsoleKey.Spacebar:
                        isStop = true;
                        break;

                    defaul:
                        break;
                }
                if (isStop)
                {
                    break;
                }
            }
        }
        static void Draw(int xPos, int yPos, string s)
        {
            for (var y = 0; y < 10; y++)
            {
                for (var x = 0; x < 10; x++)
                {
                    Console.SetCursorPosition(xPos + x * s.Length, yPos + y);
                    Console.Write(s);
                }

                Console.WriteLine();
            }
        }
        //----------------------------------------------------------------------------
        static void Shop()
        {
            double summaProduct = AskForInput("ВВести общую стоимость: ");

            if (summaProduct <= 0)
            {
                Console.Write("Товар бесплатный");
                return;
            }
            double differenceProduct = AskForInput("ВВести разницу в стоимости: ");

            if (differenceProduct < 0 || differenceProduct > summaProduct)
            {
                Console.Write("Неверные данные");
                return;
            }
            double costPhoduct1 = (summaProduct - differenceProduct) * 0.5;
            double costPhoduct2 = costPhoduct1 + differenceProduct;

            Console.WriteLine("Стоимость товара МЯЧ: " + costPhoduct1);
            Console.Write("Стоимость товара БИТА: " + costPhoduct2);
        }

        static double AskForInput(string text)
        {
            string? input;
            double result;

            do
            {
                Console.Write(text);
                input = Console.ReadLine();
            }
            while (!double.TryParse(input, out result));

            return result;
        }
        //-------------------------------------------------------------------------

        static void Fibonacci()
        {
            string userInput;
            int length;

            do
            {
                Console.Write("Input number fibonacci: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out length));

            int first = 0;
            int second = 0;

            for (var i = 0; i < length; i++)
            {
                var result = first + second;

                Console.Write(result + ", ");

                if (i == 0)
                {
                    second++;
                }
                first = second;
                second = result;
            }
        }
        //-------------------------------------------------------------------------
        static void Calculator()
        {
            double result1;
            double result2;

            Console.Write("Input first number: ");
            var firstNumber = Console.ReadLine();

            while (!double.TryParse(firstNumber, out result1))
            {
                Console.Write("Input first number: ");
                firstNumber = Console.ReadLine();
            }

            Console.Write("Input second number: ");
            var secondNumber = Console.ReadLine();

            while (!double.TryParse(secondNumber, out result2))
            {
                Console.Write("Input second number: ");
                secondNumber = Console.ReadLine();
            }

            Console.Write("Input calculator symbol:( +, -, *, /, %) ");
            var symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    Console.Write("Сумма: " + (result1 + result2));
                    break;
                case "-":
                    Console.Write("Сумма: " + (result1 - result2));
                    break;
                case "*":
                    Console.Write("Сумма: " + (result1 * result2));
                    break;
                case "/":
                    if (result2 == 0)
                    {
                        Console.WriteLine("Division by zero");
                        break;
                    }
                    Console.Write("Сумма: " + (result1 / result2));
                    break;
                case "%":
                    if (result2 == 0)
                    {
                        Console.WriteLine("Remainder division by zero");
                        break;
                    }
                    Console.Write("Сумма: " + (result1 % result2));
                    break;
                default:
                    Console.Write("Invalid calculator symbol");
                    break;
            }
        }
            //-----------------------------------------------------------------------------
            static void TwoNumber()
            {
                int result1;
                int result2;

                Console.Write("Input first number: ");
                var firstNumber = Console.ReadLine();

                while (!int.TryParse(firstNumber, out result1))
                {
                    Console.Write("Input first number: ");
                    firstNumber = Console.ReadLine();
                }

                Console.Write("Input second number: ");
                var secondNumber = Console.ReadLine();

                while (!int.TryParse(secondNumber, out result2))
                {
                    Console.Write("Input second number: ");
                    secondNumber = Console.ReadLine();
                }

                switch (result2)
                {
                    case 0:
                        Console.WriteLine("Division by zero");
                        break;
                default:
                    var result = result1 % result2;

                    var text = (result == 0)
                      ? "Без остатка: " + result1 + " и " + result2
                      : "Остаток: " + result;

                    Console.Write(text);
                    break;
                }

           

        }
    }
    
}

