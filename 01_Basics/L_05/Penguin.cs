using System;

namespace L_05
{
    public class Penguin : BirdsBase
    {
        public Penguin(string name) : base(name)
        { }

        public override bool Swim()
        {
            return true;
        }

        public override bool Walk()
        {
            return true;
        }

        public override bool Fly()
        {
            return false;
        }

        public override bool Run()
        {
            return false;
        }
    }
}

