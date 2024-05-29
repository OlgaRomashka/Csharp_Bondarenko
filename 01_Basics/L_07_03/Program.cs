namespace L_07_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foodFactory = new Factory();

            var pizza = foodFactory.GetItem<Pizza>();
            var sushi = foodFactory.GetItem<Sushi>();
            var burger = foodFactory.GetItem<Burger>();
        }
    }

    public class Factory
    {
        public T GetItem<T>()
            where T : class, new()
        {
            return  new T() ;
        } 
    }

    public class Pizza
    {
    }

    public class Burger
    {
    }

    public class Sushi
    {
    }
}
