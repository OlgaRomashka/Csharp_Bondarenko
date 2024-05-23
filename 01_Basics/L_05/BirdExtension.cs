using System;

namespace L_05
{
    public static class BirdExtension
    {
        public static Egg LayEgg(this Birds bird)
        {           
            return new Egg(bird);
        }
    }
}

