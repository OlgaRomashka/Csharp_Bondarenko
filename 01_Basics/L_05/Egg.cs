using System;

namespace L_05
{
    public class Egg
    {
        public Egg(Birds bird)
        {
            Parent = bird;
        }
        public Birds Parent{get; private set; }
    }
}
