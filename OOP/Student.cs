namespace OOP;

public class Student : Person
{
    private readonly int _credits;
    private readonly int _semester;

    public Student(string firstName, string lastName, string personalId,
        int credits, int semester) : base(firstName, lastName, personalId)
    {
        _credits = credits;
        _semester = semester;
    }

    public void Dummy()
    {
        Console.WriteLine(_firstName);
        Console.WriteLine(_lastName);
    }
    public override string ToString()
    {
        return $"{base.ToString()}\ncredits:{_credits}\nsemester:{_semester}";
    }

    public override string VirtualSample()
    {
        return "From Student";
    }
}