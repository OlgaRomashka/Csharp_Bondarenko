using System;

namespace L_10
{
    public class MyCustomException : Exception
    {
        Exception _ex;
        public MyCustomException(Exception ex)
        { 
            _ex = ex;
        }
        public  string Message => $"My Exception :: PREVIOUS: {_ex.Message}";
    } 
}