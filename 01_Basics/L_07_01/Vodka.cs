using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_07_01
{
    internal class Vodka : IDrinkable
    {
        public string Name => "Vodka";

        public void Drink()
        {
            Console.WriteLine($"{Name} had drunk");
        }
    }
}
