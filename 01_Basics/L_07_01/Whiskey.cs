using System;

namespace L_07_01
{

    public class Whiskey : IDrinkable
    {
        public string Name => "Wiskey";

        public void Drink()
        {
            Console.WriteLine($"{Name} had drunk");
        }
    }


}
