using System;

namespace L_06
{
    public static class Helper
    {
        public static int GetRandom(int from, int to)
        {
            Random rnd = new Random();
            return rnd.Next(from, to);
        }
    }
}
