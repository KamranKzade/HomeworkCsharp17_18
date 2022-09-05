namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Operation


class Operation
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string? ProccessName { get; init; }
    public DateTime? dateTime { get; init; }

    public Operation(Guid ıd, string? proccessName, DateTime? dateTime)
    {
        Id = ıd;
        ProccessName = proccessName;
        this.dateTime = dateTime;
    }


    public override string ToString() => $@"

Id: {Id}
Process Name: {ProccessName}
DateTime: {dateTime}";
}
