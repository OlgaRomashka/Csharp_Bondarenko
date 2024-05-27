using System;

namespace L_06_02
{
    public class Client
    {
        public void SortChests(Chest[] chests)
        { 
            for(int j  = 0; j < chests.Length; j++)
            {
                for (var i = chests.Length - 1; i > j; i--)
                {
                    if (chests[i].GoldQuantity > chests[i-1].GoldQuantity)
                    {
                        var swap = chests[i];
                        chests[i] = chests[i-1];
                        chests[i-1] = swap;
                    }
                }
            }
        }
 
        public string GetString(Chest[] chests)
        {
            int[] golds = new int[chests.Length];

            for (var i = 0; i < chests.Length; i++)
            {
                golds[i] = chests[i].GoldQuantity;
            }
            return string.Join(", ", golds);
        }
    }
}
