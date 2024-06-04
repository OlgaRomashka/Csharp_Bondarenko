using L_08_01;

namespace L_08_01
{
    public class Bank:ICloneable
    {
        Dictionary<int, Account> _accounts;

        public Bank()
        {
            _accounts = new Dictionary<int, Account>();
        }

        public Bank(Dictionary<int, Account> accounts)
        {
            _accounts = new Dictionary<int, Account>(accounts);
        }
        public int CreateAccount( string name, double amount)
        {
            var account = new Account(name, amount);
            var id = _accounts.Count + 1;

            _accounts.Add(id, account);
           
            PrintInfo(id, account);

            return id;
        }

        public void DeleteAccount(int id)
        {
            Write.Message($"Count id: <{_accounts.Count}>");

            _accounts.Remove(id);

            Write.Message($"Count id: <{_accounts.Count}>");
        }

        public int AddAccount(int id, double plusAmount)
        {
            var a = _accounts[id];

            a.Amount = a.Amount + plusAmount;
           
            PrintInfo(id, a);

            return id;
        }

        public int AwayAccount(int id, double minusAmount)
        {
            var a = _accounts[id];

            if (a.Amount > minusAmount)
            {
                a.Amount = a.Amount - minusAmount;

                PrintInfo(id, a);
            }
            else
            {
                Write.Error("Недостаточно средств");
            }
            return id;
        }

        public void PrintInfo(int id)
        {
            if (_accounts.TryGetValue(id, out var account))
            {
                PrintInfo(id, account);
            }
            else
            {
                Write.Error($"<{id}> is not found");  
            }
        }

        public void PrintInfo(string name)
        { 
            foreach (var pair in _accounts)
            {
                if (pair.Value.Name == name)
                {
                    PrintInfo(pair.Key, pair.Value);
                }
            }   
        }

        private void PrintInfo(int id, Account account)
        {
            Write.Message($"{id}: {account}");
        }

        public object Clone()
        {
            return new Bank(_accounts);
        }
    }
}