using static System.Console;
namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Ceo


class Ceo : Base, IOrganize, IControl
{
    public string? Position { get; set; }

    public Ceo(Guid id, string? name, string? surname, DateOnly age, double salary, string position) :
      base(id, name, surname, age, salary)
    {
        Position = position;
    }

    public void MakeMeeting() => WriteLine("Ceo make Meeting");
    public double DecreasePercentage(double percent) => Salary * percent / 100;

    public void Control() => WriteLine("Ceo is Control");
    public void Organize() => WriteLine("Ceo is Organize");

    public override string ToString() =>
$@"{base.ToString()}
Position: {Position}";
}