namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Credit

class Credit
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Client? Client { get; init; }
    public double Amount { get; set; }
    public double Percent { get; init; }
    public int Months { get; init; }


    public Credit(Guid ıd, Client? client, double amount, double percent, int months)
    {
        Id = ıd;
        Client = client;
        Amount = amount;
        Percent = percent;
        Months = months;
    }

    public double CalculatePercent() => Amount * Percent / 100;
    public double GetPayment() => ((Amount * Percent / 100) + Amount) / Months;

    public override string ToString() => $@"

Id: {Id}
Amount: {Amount}
Percent: {Percent}
Months: {Months}

Client info:
{Client}";
}