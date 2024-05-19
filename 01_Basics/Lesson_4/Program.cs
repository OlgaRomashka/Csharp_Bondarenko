using System;

namespace Lesson_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarTesting();
        }
       

        private static void CarTesting()
        {
            Car car1 = new Car("Audi", 2001, 1000, Car.Color.Red);
            Car car2 = new Car("Ford", 2002, 2000, Car.Color.Blue);
            Car car3 = new Car("Hunda", 2003, 3000, Car.Color.Black);

            PrintCar(car1);
            PrintCar(car2);
            PrintCar(car3);

            car1.ChangePrice(10000);
            car2.ChangePrice(20000);
            car3.ChangePrice(30000);

            PrintCar(car1);
            PrintCar(car2);
            PrintCar(car3);
        }
        static void PrintCar(Car a)
        {
            string s = a.GetInfoCar();
            Console.WriteLine(s);
        }

    }

}
