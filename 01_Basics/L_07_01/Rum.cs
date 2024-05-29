using System;

namespace L_07_01
{
    internal class Rum: IDrinkable
    {
        public string Name => "Rum";

        public void Drink()
        {
            Console.WriteLine($"{Name} had drunk");
        }
    }
}
