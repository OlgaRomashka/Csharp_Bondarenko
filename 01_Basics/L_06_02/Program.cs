namespace L_06_02
{
   public class Program
    {
        static void Main()
        {
            Server server = new Server();
            Client client = new Client();

            var chests = server.GenerateChests(10);

            client.SortChests(chests);

            string s = client.GetString(chests);

            Console.WriteLine(s);
        }
    }
}