namespace L_07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table_5 = new Table(5, Menu.Sushi, Menu.Tea);
            var table_3 = new Table(3, Menu.Pizza, Menu.Cola);
            var table_8 = new Table(8, Menu.Vodka, Menu.Beer);

            var waiter = new Waiter();

            waiter.TakeOrder(table_5);
            waiter.TakeOrder(table_5);
            waiter.TakeOrder(table_3);
            waiter.TakeOrder(table_8);

            var ordersToKitchen = waiter.AllOrders;

            foreach(var order in ordersToKitchen)
            {
                Console.WriteLine($"table < {order.Key} > :: < {string.Join(", ", order.Value)} >");
            }
        }
    }
}
