using static System.Console;
namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Class Manage


class Manage : Base, IOrganize
{
    public string? Position { get; set; }
    public Manage(Guid id, string? name, string? surname, DateOnly age, double salary, string? position)
        : base(id, name, surname, age, salary)
    {
        Position = position;
    }

    public void Organize() => WriteLine("Manage Organized");
    public double CalculateSalaries() => Salary * 3;


    public override string ToString() =>
$@"{base.ToString()}
Position: {Position}";
}
