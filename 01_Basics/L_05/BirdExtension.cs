using System;

namespace L_05
{
    public static class BirdExtension
    {
        public static Egg LayEgg(this BirdsBase bird)
        {           
            return new Egg(bird);
        }
    }
}

