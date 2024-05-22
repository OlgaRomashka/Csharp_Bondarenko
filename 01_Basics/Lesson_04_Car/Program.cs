namespace L04_Cars
{
    public class Program
    {
        static void Main()
        {
            var car1 = new Car("Audi", 2001, 1000, Color.Red);
            var car2 = new Car("Ford", 2002, 2000, Color.Blue);
            var car3 = new Car("Hunda", 2003, 3000, Color.Black);

            PrintCar(car1);
            PrintCar(car2);
            PrintCar(car3);

            car1.ChangePrice(10000);
            car2.ChangePrice(20000);
            car3.ChangePrice(30000);

            PrintCar(car1);
            PrintCar(car2);
            PrintCar(car3);
        }

        private static void PrintCar(Car a)
        {
            string s = a.GetInfo();
            Console.WriteLine(s);
        }
    }
}
