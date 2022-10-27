namespace OOStepByStep.Person;

public class Teacher : Person
{
    public Teacher(string name, int age) : base(name, age)
    {
    }

    public override string Introduce()
    {
        var classSuffix = CourseClass != null ? $" of {CourseClass.ClassName}" : string.Empty;
        return base.Introduce() + $" I am a teacher{classSuffix}.";
    }

    public override string Welcome(Person person)
    {
        return Introduce() + base.Welcome(person);
    }
}