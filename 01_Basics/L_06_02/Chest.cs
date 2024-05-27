using System;

namespace L_06_02
{
    public class Chest
    {
        public int GoldQuantity { get; private set; }

        public void FillChest(int goldQuantity)
        {
            GoldQuantity = goldQuantity;
        }
    }
}