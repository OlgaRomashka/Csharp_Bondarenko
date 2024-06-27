using L_12;

namespace L_12
{
    public class Basket
    {
        public int Credits { get; private set; }

        public int[] Ids => _collections.Select(x => x.Id).ToArray();

        private readonly List<Collection> _collections;

        public Basket(int credit , List<Collection> collections)
        {
            Credits = credit;
            _collections = collections;
        }
    }
}

