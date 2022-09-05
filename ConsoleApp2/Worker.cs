using static System.Console;
namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Worker


class Worker : Base
{
    public string? Position { get; init; }
    public DateOnly? StartTime { get; init; }
    public DateOnly? EndTime { get; init; }

    List<Operation>? Operations;

    public Worker(Guid id, string? name, string? surname, DateOnly age, double salary, string? position, DateOnly? start, DateOnly? end, List<Operation>? operations)
        : base(id, name, surname, age, salary)
    {
        Position = position;
        StartTime = start;
        EndTime = end;
        Operations = operations;
    }



    public void AddOperation(Operation operation) => Operations?.Add(operation);

    public void PrintOperation(Guid Operationid)
    {
        foreach (var Operation in Operations!)
            if (Operation.Id == Operationid)
            {
                WriteLine(Operation);
                return;
            }
    }



    public override string ToString() =>
$@"{base.ToString()}
Position: {Position}
StartTime: {StartTime}
EndTime: {EndTime}";
}
