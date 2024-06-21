namespace L_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            try
            {
                myClass.Execute();
            }
            catch (MyCustomException customEx)
            {
                Console.WriteLine($"CATCHED:: {customEx.Message}");
            }
        } 
    }
}
