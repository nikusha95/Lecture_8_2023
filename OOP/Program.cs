// See https://aka.ms/new-console-template for more information

using OOP;

Person p = new Person("a", "b", "123456");

Console.WriteLine(p);
Console.WriteLine(p.VirtualSample());

Console.WriteLine();

Student s = new Student("n", "b", "11111", 10, 3);

s.Dummy();
Console.WriteLine(s);
Console.WriteLine(s.VirtualSample());

Person newPerson = s;

newPerson.VirtualSample();



