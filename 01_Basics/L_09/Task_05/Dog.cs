using System;

namespace L_09.Task_05
{
    public class Dog:AnimalBase
    {
        private int _age = 2;

        public Dog()
        {
            name = "Dog";
            whereLive = "Yard";
        }

        public override void GetInfo()
        {
           base.GetInfo();

           Console.WriteLine($" Age: {_age}");
        }
    }
}
