namespace OOP;

public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected string _personalId;

    public Person(string firstName, string lastName, string personalId)
    {
        _firstName = firstName;
        _lastName = lastName;
        _personalId = personalId;
    }

    public override string ToString()
    {
        return $"firstname:{_firstName}\nlastName:{_lastName}\npersonalId:{_personalId}";
    }

    public virtual string VirtualSample()
    {
        return "from Person";
    }
}