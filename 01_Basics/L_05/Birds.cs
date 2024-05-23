using System;
using System.Globalization;

namespace L_05
{
    public abstract class Birds
    {
        public abstract bool Fly();
    

        public abstract bool Swim();

        public abstract bool Walk();

        public abstract bool Run();

       
        public Birds(string name)
        {
            Name = name;
        }
       
        public string Name { get; }

    }
}
