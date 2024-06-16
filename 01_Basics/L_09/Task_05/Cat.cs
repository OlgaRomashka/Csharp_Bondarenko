using System;

namespace L_09.Task_05
{
  public class Cat:AnimalBase
    {
        private int _age = 5;

        public Cat()
        {
            name = "Cat";
            whereLive = "Home";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            
            Console.WriteLine($" Age: {_age}");
        }
    
    }
}
