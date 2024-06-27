using System;

namespace L_12
{
    public class Client
    {
        public void Output(List<Chest> chests)
        {
            var sorted = SortChest(chests);

           Print(sorted);
        }

        private List<Chest> SortChest(List<Chest> chests)
        {
            return chests
             .OrderByDescending(c => c.Credits)
             .ThenByDescending(c => c.CollectionCount)
             .ThenByDescending(c => c.BasketCount)
             .ToList();
        }

        private void Print(List<Chest> chests)
        {
            Log.Message($"*-------------------------------");

            foreach (Chest chest in chests)
            {
                Log.Message(chest.ToString());
            }

            Log.Message($"Всего:");
            Log.Message($"  - сундуков: {chests.Count}");
            Log.Message($"  - корзин:{chests.Select(x=>x.BasketCount).Sum()}");
            Log.Message($"  - коллекшенов: {chests.Select(x => x.CollectionCount).Sum()}");
            Log.Message($"  - кредитов: {chests.Select(x=>x.Credits).Sum()}");

            Log.Message($"*-------------------------------");
        }
    }
}
