using System;

namespace L_12
{
    public class Chest
    {
        public int Credits => _chestCredits + _basketsCredits;
        public int BasketCount => _baskets.Count;
        public int CollectionCount => _collectionIds.Length;

        private int _id;
        private readonly List<Collection> _collections;
        private readonly List<Basket> _baskets;

        private readonly int _chestCredits;
        private readonly int _basketsCredits;

        private readonly int[] _chestCollectionIds;
        private readonly int[] _basketCollectionIds;
        private readonly int[] _collectionIds;
       


        public Chest(int id, int credits, List<Collection> collections, List<Basket> baskets)
        {
            _id = id;
            _collections = collections;
            _baskets = baskets;

            _chestCredits = credits;
            _basketsCredits = _baskets.Sum(x => x.Credits);

           _chestCollectionIds = _collections.Select(x => x.Id).ToArray();
           _basketCollectionIds = _baskets.SelectMany(x => x.Ids).ToArray();

            _collectionIds = _chestCollectionIds.Concat(_basketCollectionIds).ToArray();
        }


        public override string ToString()
        {
            var collectionIds = string.Join(", ", _collectionIds);


            return $"Сундук {_id}: {Credits}({_chestCredits}/{_basketsCredits}) кредитов," +
                $" {CollectionCount}({_chestCollectionIds.Length}/{_basketCollectionIds.Length}) коллекшенов (id: {collectionIds}), " +
                $"{BasketCount} корзин.";
        }
    }
}

