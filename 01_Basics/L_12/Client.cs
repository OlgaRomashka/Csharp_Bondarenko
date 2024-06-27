using System;

namespace L_12
{
    public class Client
    {
        //public void СameErrorChest(List<Chest> chests)
        //{
        //    if (chests == null)
        //    {
        //        Console.WriteLine("Ошибка 1 : ссылка на список равна null");
        //    }

        //    if (chests.Count == 0)
        //    {
        //        Console.WriteLine("Ошибка 2 : список сундуков пуст");
        //    } 
        //}

        //public void SortChest(List<Chest> chests)
        //{
        //    List<Chest> OnChestGenerated


        //  var result = List.OrderBy(x=>x.credits). ThenBy(x=>x.collections);
        //}

        

        public void Print(List<Chest> chests)
        {
            Log.Message($"*-------------------------------");

            foreach (Chest chest in chests)
            {
                Log.Message(chest.ToString());
            }

            Log.Message($"*-------------------------------");

        }

    }
}
