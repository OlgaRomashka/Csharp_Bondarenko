using System;

namespace L_13
{
    public class Program
    {
        private const string path = "Product.txt";
        public static void Main()
        {
            var milk = new Product("Milk", 2024, 7, 19);
            var eggs = new Product("Eggs", 2024, 7, 21);
            var cheese = new Product("Cheese", 2025, 8, 16);
            var milk2 = new Product("Milk2", 2024, 7, 21);

            var list = new List<Product>();

            list.Add(milk);
            list.Add(eggs);
            list.Add(cheese);
            list.Add(milk2);

            var sortedList = list.OrderBy(p=>p.Remained).ToList();
           
            Streamer.WriteAsync(path, sortedList);

            using (var streamReader = new StreamReader(path))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            };
        }
    }
}
