using System;

namespace L_07_02
{
    public class Waiter
    {
        public Waiter()
        {
             AllOrders = new();
        }

        public Dictionary<int, List<Menu>> AllOrders { get; }

        public void TakeOrder(Table table)
        {
            AllOrders.Add(table.Number, table.Orders);
        }
    }
}
