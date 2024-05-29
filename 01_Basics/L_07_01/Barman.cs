using System;

namespace L_07_01
{
    public class Barman
    {
        public List<IDrinkable> GetDrinks()
        {
            var drinks = new List<IDrinkable>();

            drinks.Add(new Rum());
            drinks.Add(new Gin());
            drinks.Add(new Whiskey());
            drinks.Add(new Vodka());

            return drinks;

        }
       
    }
}
