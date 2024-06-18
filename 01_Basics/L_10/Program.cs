namespace L_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var thrower = new ExceptionThrower();

            try
            {
                thrower.Throw();
            }
            catch (Exception ex)
            {
                try
                {
                    throw new MyCustomException(ex);
                }
                catch
                { 
                    Console.WriteLine("My costom exeption!!!");
                }
            }
        } 
    }
}
