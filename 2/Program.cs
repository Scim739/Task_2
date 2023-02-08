
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
Person Ivan = new Person();
Person Kirill = new Person("Кирилл", 18);
Ivan.move("Ivan");
Kirill.talk("Kirill");
public class Person
{
    string fullName = "None";
    int age = 18;

    public void move(string Person)
    {
        Console.WriteLine("Такой-то " + Person + " говорит");
    }
    public void talk(string Person)
    {
        Console.WriteLine("Такой-то " + Person + " говорит");
    }

    public Person() 
    { 
    
    }

    public Person (string fullName, int age)
    {
        this.fullName= fullName;
        this.age= age;
    }
}