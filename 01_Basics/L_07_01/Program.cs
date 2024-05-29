namespace L_07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var barman = new Barman();

            var banda = new Banda();

            var drinks = barman.GetDrinks();

            banda.DrinkAlcohol(drinks); 
        }
    }
}
