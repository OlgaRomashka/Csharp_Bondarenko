using System;
using System.Drawing;

namespace L_08_01
{
    public class Account
    {
        public Account( string name, double amount)
        {
            Name = name;
            Amount = amount;
        }

        public override string ToString()
        {
            return $" :: {Name} : ${Amount}";
        }

        public string Name { get; }
        public double Amount { get; set; }
    }
}

