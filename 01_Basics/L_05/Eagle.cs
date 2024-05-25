using System;

namespace L_05
{
    public class Eagle: BirdsBase
    {
        public Eagle(string name) : base(name)
        { }

        public override bool Fly()
        {
            return true;
        }

        public override bool Swim()
        {
            return false;
        }

        public override bool Walk()
        {
            return false;
        }

        public override bool Run()
        {
            return false;
        }
    }
}
