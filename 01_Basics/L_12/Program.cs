namespace L_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();

            var client = new Client();

            server.OnChestGenerated += client.Print;
           

            server.GenerateChests(4);
        }
    }
}
