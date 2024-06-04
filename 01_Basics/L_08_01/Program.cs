namespace L_08_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();

            var id1 = bank.CreateAccount("Иванов Иван Иванович", 1000);
            var id2 = bank.CreateAccount("Петров Петр Иванович", 2000);
            var id3 = bank.CreateAccount("Иванов Иван Иванович", 3000);
            var id4 = bank.CreateAccount("Сидоров Семен Семенович", 20000);

            bank.AddAccount(id2, 2000);

            bank.AwayAccount(id2, 500);
            bank.AwayAccount(id2, 5000);

            bank.PrintInfo(id4);
            bank.PrintInfo(10);

            bank.PrintInfo("Иванов Иван Иванович");

           // bank.DeleteAccount(id1);


            Bank clone = (Bank)bank.Clone();
            clone.PrintInfo(id4);
            clone.PrintInfo(10);

            clone.PrintInfo("Иванов Иван Иванович");
        }
    }
}
