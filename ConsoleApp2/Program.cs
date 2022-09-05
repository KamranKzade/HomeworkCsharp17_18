using static System.Console;
namespace HomeworkCsharp17_18;

class Program
{
    static void Main()
    {
        /////////////////
        //// Client

        Client client1 = new(Guid.NewGuid(), "Aydin", "Xirdanlanli", new DateOnly(2000, 01, 01), 1500, "Baku", "Nizami");
        Client client2 = new(Guid.NewGuid(), "Elsad", "Hesimov", new DateOnly(2001, 01, 01), 2000, "Baku", "Azadliq");

        /////////////////
        //// Ceo

        Ceo ceo = new(Guid.NewGuid(), "Kamran", "Karimzada", new DateOnly(1999, 03, 27), 4500, ".Net Developer");
       
        /////////////////
        //// Manage

        Manage manage = new(Guid.NewGuid(), "Abdulla", "Abdullayev", new DateOnly(2005, 01, 01), 3500, "HR Department");
       

        /////////////////
        //// Credit

        Credit credit1 = new(Guid.NewGuid(), client1, 15000, 20, 18);
        Credit credit2 = new(Guid.NewGuid(), client2, 20000, 20, 18);
        

        /////////////////
        //// Operation

        Operation operation = new(Guid.NewGuid(), "Credit", new DateTime(2022, 9, 5));

        List<Operation> operations = new();
        operations.Add(operation);


        /////////////////
        //// Worker

        Worker worker1 = new(Guid.NewGuid(), "Asif", "Abdullayev", new DateOnly(2005, 01, 01), 3500, "HR Department", new DateOnly(2022, 01, 01), new DateOnly(2022, 10, 01), operations);
        Worker worker2 = new(Guid.NewGuid(), "Vasif", "Abdullayev", new DateOnly(2002, 01, 01), 2500, "IT Department", new DateOnly(2019, 03, 10), new DateOnly(2022, 10, 01), operations);
        Worker worker3 = new(Guid.NewGuid(), "Agarsif", "Abdullayev", new DateOnly(2001, 01, 01), 1500, "Enginering Department", new DateOnly(2018, 05, 25), new DateOnly(2022, 10, 01), operations);
       
        /////////////////
        //// Bank

        Bank bank = new("Kapital Bank", 25000000, 1000000, ceo);

        bank.AddManage(manage);

        bank.AddWorker(worker1);
        bank.AddWorker(worker2);
        bank.AddWorker(worker3);

        bank.AddClient(client1);
        bank.AddClient(client2);

        //// Show Client Credit Info 

        WriteLine("Client Credits: ");
        bank.ShowClientCredit(client1?.Name);


        //// Show ALL Credit

        bank.AddCredit(credit1);
        bank.AddCredit(credit2);

        WriteLine();
        WriteLine("ShowAllKredits: ");
        
        bank.ShowAllCredit();


        //// PayCredit 

        WriteLine();
        bank.PayCredit(client1, 3000);
        WriteLine($"Qalan kredit borcu: {credit1.Amount}");

    }
}