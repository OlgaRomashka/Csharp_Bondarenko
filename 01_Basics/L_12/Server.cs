using System;
using System.Collections;

namespace L_12
{
    public class Server
    {
        public event Action<List<Chest>> OnChestGenerated;

        private int[] _credit = { 0, 10, 50, 100 };

        private Collection[] _collections = {
            new Collection(1), new Collection(2), new Collection(3),
            new Collection(4), new Collection(5), new Collection(6),
            new Collection(7), new Collection(8), new Collection(9),
            new Collection(10) };


        private Random _random = new();

        public void GenerateChests(int count)
        {
            var chests = GetChests(count);
            OnChestGenerated?.Invoke(chests);
        }

        private List<Chest> GetChests(int count)
        {
            var list = new List<Chest>();

            for (int i = 1; i <= count; i++)
            {
                var credits = _credit[_random.Next(0, _credit.Length)];

                var collections = GetCollections(_random.Next(0, 6));

                var baskets = GetBaskets(_random.Next(0, 3));

                list.Add(new Chest(i, credits, collections, baskets) );
            }
            return list;
        }

        private List<Basket> GetBaskets(int count)
        {
            var list = new List<Basket>();

            for (int i = 0; i < count; i++)
            {
                var credits = _credit[_random.Next(1, 2 + 1)];

                var collections = GetCollections(_random.Next(1, 4));

                list.Add(new Basket(credits, collections));
            }
            return list;
        }

        private List<Collection> GetCollections(int count)
        {
            var list = new List<Collection>();

            for (int i = 0; i < count; i++)
            {
                var index = _random.Next(0, _collections.Length);

                list.Add(_collections[index]);
            }
            return list;
        }
    }
}

