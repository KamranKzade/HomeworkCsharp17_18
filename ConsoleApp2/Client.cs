namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Client


class Client : Base
{
    public string? LiveAddress { get; init; }
    public string? WorkAddress { get; init; }

    public Client(Guid id, string? name, string? surname, DateOnly age, double salary, string? liveAddress, string? workAddress)
        : base(id, name, surname, age, salary)
    {
        LiveAddress = liveAddress;
        WorkAddress = workAddress;
    }

    public override string ToString() =>
$@"{base.ToString()}
LiveAddress: {LiveAddress}
WorkAddress: {WorkAddress}";
}