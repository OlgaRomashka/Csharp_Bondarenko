using System;

namespace L_10
{
    public class ExceptionThrower
    {
        private readonly Random _random = new();

        public void Throw()
        {
            int index = _random.Next(0, 4);

            switch (index)
            {
                case 0: throw new IndexOutOfRangeException();
                case 1: throw new DivideByZeroException();
                case 2: throw new InvalidCastException();
                default: throw new NullReferenceException();
            }
        }
    }
}
