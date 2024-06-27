using System;

namespace L_12
{
    public class Chest
    {


        private int _id;
        private readonly List<Collection> _collections;
        private readonly List<Basket> _baskets;

        private readonly int _chestCredits;
        private readonly int _basketsCredits;
        private readonly int[] _chestCollectionIds;

        public Chest(int id, int credits, List<Collection> collections, List<Basket> baskets)
        {
            _id = id;
            _collections = collections;
            _baskets = baskets;

            _chestCredits = credits;
            _chestCollectionIds = _collections.Select(x => x.Id). ToArray();

            _basketsCredits = _baskets.Sum(x=> x.Credits);
        }

        public override string ToString()
        {
            var credits = _chestCredits + _basketsCredits;
            var collectionIds = string.Join(", ", _chestCollectionIds);


            return $"Сундук {_id}: {credits}({_chestCredits}/{_basketsCredits}) кредитов," +
                $" {_collections.Count} коллекшенов (id: {collectionIds}), " +
                $"{_baskets.Count} корзин.";
        }
    }
}

