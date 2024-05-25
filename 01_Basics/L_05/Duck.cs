using System;

namespace L_05
{
    public class Duck : BirdsBase
    {
        public Duck(string name) : base(name)
        { }

        public override bool Fly()
        {
            return true;
        }

        public override bool Swim()
        {
            return true;
        }

        public override bool Walk()
        {
            return true;
        }

        public override bool Run()
        {
            return false;
        }
    }
}



