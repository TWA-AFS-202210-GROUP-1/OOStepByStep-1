namespace OOStepByStep.Person;

public class Teacher : Person
{
    public Teacher(string name, int age) : base(name, age)
    {
    }

    public override string Introduce()
    {
        return base.Introduce() + $" I am a teacher{GetClassSuffix()}.";
    }

    public override string Welcome(Person person)
    {
        return Introduce() + base.Welcome(person);
    }
}