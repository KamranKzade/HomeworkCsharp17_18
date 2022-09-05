namespace HomeworkCsharp17_18;

//////////////////////////////////////////////////////////////////////////////////////
/// Base class


abstract class Base
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateOnly Age { get; set; }

    public double Salary { get; set; }

    public Base(Guid id, string? name, string? surname, DateOnly age, double salary)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Salary = salary;
    }

    public override string ToString() => $@"
Id: {Id}
Name: {Name}
Surname: {Surname}
Age: {Age}
Salary: {Salary}";
}