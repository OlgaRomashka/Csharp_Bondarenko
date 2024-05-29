using System;

namespace L_07_01
{
    internal class Gin : IDrinkable
    {
        public string Name => "Gin";

        public void Drink()
        {
            Console.WriteLine($"{Name} had drunk");
        }
    }
}
