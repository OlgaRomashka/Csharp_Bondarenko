using System;

namespace L_05
{
    public class Egg
    {
        public Egg(BirdsBase bird)
        {
            Parent = bird;
        }
        public BirdsBase Parent{get; }
    }
}
