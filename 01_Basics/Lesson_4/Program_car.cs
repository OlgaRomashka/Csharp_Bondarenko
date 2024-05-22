using System;

namespace Lesson_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Audi", 2001, 1000, Car.Color.Red);
            var car2 = new Car("Ford", 2002, 2000, Car.Color.Blue);
            var car3 = new Car("Hunda", 2003, 3000, Car.Color.Black);

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
               
        private static void PrintCar(Car a)
        {
            string s = a.GetInfo();
            Console.WriteLine(s);
        }

        private class Car
        {
           private string _marka;
           private int _year;
           private int _price;
           private Color _color;

            private Car(string marka, int year, int price, Color color)
            {
                _marka = marka;
                _year = year;
                _price = price;
                _color = color;
            }

            private void ChangePrice(double newPrice)
            {
                _price = newPrice;
            }

            private string GetInfo()
            {
                var return = "Mapка: " + _marka + ", Год: " + _year + ", Цвет: " + _color + ", Цена: " + _price;
            }
        }
    }
    public enum Color
    {
        Black,
        White,
        Blue,
        Green,
        Red
    }

}
