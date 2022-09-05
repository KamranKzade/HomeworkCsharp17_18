using static System.Console;
namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Bank


class Bank
{
    public string? Name { get; set; }
    public double Budget { get; set; }
    public double Profit { get; set; }

    Ceo Ceo;

    List<Worker>? Workers = new();
    List<Manage>? Manages = new();
    List<Client>? Clients = new();
    List<Credit>? Credits = new();

    public Bank(string? name, double budget, double profit, Ceo ceo)
    {
        Name = name;
        Budget = budget;
        Profit = profit;
        Ceo = ceo;
    }

    public void AddWorker(Worker worker)
    {
        if (worker == null)
            throw new NullReferenceException("Null");
        Workers?.Add(worker);
    }
    public void AddManage(Manage manage)
    {
        if (manage == null)
            throw new NullReferenceException("Null");
        Manages?.Add(manage);
    }
    public void AddClient(Client client)
    {
        if (client == null)
            throw new NullReferenceException("Null");
        Clients?.Add(client);
    }
    public void AddCredit(Credit credit)
    {
        if (credit == null)
            throw new NullReferenceException("Null");
        Credits?.Add(credit);
    }

    public void ShowClientCredit(string fullname)
    {
        for (int i = 0; i < Clients?.Count; i++)
        {
            if (Clients[i].Name == fullname)
            {
                WriteLine(Clients[i]);
                return;
            }
        }
    }
    public void PayCredit(Client client, double money)
    {
        foreach (var credit in Credits!)
        {
            if (credit?.Client?.Id == client.Id)
            {
                credit.Amount -= money;
            }
        }
    }
    public void ShowAllCredit()
    {
        foreach (var credit in Credits!)
            WriteLine(credit);
    }
}