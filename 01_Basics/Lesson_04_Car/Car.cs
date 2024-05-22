using System;

namespace L04_Cars
{
    public class Car
    {
        private string _marka;
        private int _year;
        private float _price;
        private Color _color;
        public Car(string marka, int year, float price, Color color)
        {
            _marka = marka;
            _year = year;
            _price = price;
            _color = color;
        }
        public void ChangePrice(float newPrice)
        {
            _price = newPrice;
        }
        public string GetInfo()
        {
             return  "Mapка: " + _marka + ", Год: " + _year + ", Цвет: " + _color + ", Цена: " + _price;
        }
    }
}
