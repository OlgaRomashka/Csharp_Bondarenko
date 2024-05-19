using System;

namespace Lesson_04
{
    public class Car
    {
        string _marka;
        int _year;
        double _price;
        Color _color;

        public Car(string marka, int year, double price, Color color)
        {
            _marka = marka;
            _year = year;
            _price = price;
            _color = color;
        }
        public void ChangePrice(double newPrice)
        {
            _price = newPrice;
        }
        public string GetInfoCar()
        {
            var info = "Mapка: " + _marka + ", Год: " + _year + ", Цвет: " + _color + ", Цена: " + _price;
            return info;
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
}
