using System;

namespace L_07_01
{
   public class Banda
    {
        public void DrinkAlcohol(List<IDrinkable> drinks)
        {
            foreach (IDrinkable drink in drinks)
            {
                drink.Drink();
            }

        }

    }
}
