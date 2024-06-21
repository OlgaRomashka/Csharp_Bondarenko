using System;

namespace L_10
{
    public class MyClass
    {
        private ExceptionThrower _thrower = new ();

        public void Execute()
        {
            try
            {
                _thrower.Throw();
            }
            catch (Exception ex)
            {
               throw new MyCustomException(ex);
            }
        }
    }
}
