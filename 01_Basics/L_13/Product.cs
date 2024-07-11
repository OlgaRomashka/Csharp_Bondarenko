using System;

namespace L_13
{
   public class Product
    {
        private DateTime _date;
        private string _productName;
        public Product(string productName, int year, int month, int day)
        {
            _productName = productName;
            _date = new DateTime(year,month, day); 
        }

        public int Remained => _date.Subtract(DateTime.Now).Days;

        public override string ToString()
        {
            return $"{_productName} срок годности {Remained} дней";
        }
    }
}

