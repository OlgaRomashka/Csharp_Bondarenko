using System;

namespace L_05
{
    public abstract class BirdsBase
    {
        public BirdsBase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract bool Fly();
    
        public abstract bool Swim();

        public abstract bool Walk();

        public abstract bool Run();
    }
}
