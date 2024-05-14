using System;

    internal class Program
    {
    static void Main()
    {
        int a;
        a = int.Parse(Console.ReadLine());
        int result = a % 2;


        if ((a | 0) == 0)
        {
            Console.WriteLine("число четное");
        }
        else
        {
            Console.WriteLine("число нечетное");
        }
    }
   
    }

