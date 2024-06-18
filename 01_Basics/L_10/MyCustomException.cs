using System;

namespace L_10
{
    public class MyCustomException : Exception
    { 
        public MyCustomException(Exception ex)
        { 
            Console.WriteLine($"CATCHE:{ex.Source}:{ex.Message}");
        }
    }
    
}
