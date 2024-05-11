class Person
{
    public string Name {get; set;}
    public int Id { get; set; }
    public char Gender {get; set;}
}

class Client: Person
{
    public int Code { get; set; }
    public double Limit {get; set;}
    public List<Account> Accounts { get; set; }

    public Client(string name, int id, char gender, int code, double limit)
    {
        Name = name;
        Id = id;
        Gender = gender;    
        Code = code;
        Limit = limit;
        Accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }
}

class Account
{
    public int Number { get; set; }
    public double Balance { get; set; }
    public int Type { get; set; } // 1-caja de ahorro, 2-cuenta corriente


    public Account(int number, double balance, int type)
    {
        Balance = balance;
        Type = type;
        Number = number;
    }
}

class Bank
{
    private List<Client> clients;

    public Bank()
    {
        clients = new List<Client>();
    }

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    //public void CalculateStatistics()
    //{
    //    int savingsBank = 0;
    //    int currentAccount = 0;
    //    double balanceTotalCashSavings = 0; 
    //    double balanceTotalCurrentAccount = 0;
    //    int femaleClients = 0;
    //    Client clientMajorLimitCredit = null;

    //    foreach (Client client in clients)
    //    {
    //        foreach (Account account in client.Accounts)
    //        {
    //            if(account.Type == 1)
    //            {
    //                savingsBank++;
    //                balanceTotalCashSavings += account.Balance;
    //            }
    //            else
    //            {
    //                currentAccount++;
    //                balanceTotalCurrentAccount += account.Balance;
    //            }
    //        }
    //        if(client.Gender == "F")
    //        {
    //            femaleClients++;
    //        }
    //        if()
    //    }
    //}
}
class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Client client1 = new Client("Juan Perez", 11225, "M", 0033, 5000.0);
        client1.AddAccount(new Account(1001, 1, 2500.2));
        bank.AddClient(client1);
    }
}
