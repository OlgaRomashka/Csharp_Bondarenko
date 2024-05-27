using System;

namespace L_06_02
{
    public class Server
    {
        int[] variants = new int[] { 5, 10, 20, 50, 100, 500, 1000 };

        public Chest[] GenerateChests(int count)
        {
            Chest[] chests = new Chest[count]; 

            for (int i=0; i < count; i++)
            {
                var gold = GetRandomGold();

                chests[i] = new Chest();

                chests[i].FillChest(gold);
            }
            return chests;
        }

        private int GetRandomGold()
        {
            Random rnd = new Random();
            var index = rnd.Next(0, variants.Length);
            return variants[index];
        }
    }
}