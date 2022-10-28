namespace OOStepByStep.Person;

public class Student : Person
{
    public Student(string name, int age) : base(name, age)
    {
    }

    public override string Introduce()
    {
        return base.Introduce() + $" I am a student{GetClassSuffix()}.";
    }

    public override string Welcome(Person person)
    {
        return Introduce() + base.Welcome(person);
    }
}