using System;

namespace L_05
{
    public class Eagle: Birds
    {
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

        public Eagle(string name) : base(name)
        { }
    }
}
