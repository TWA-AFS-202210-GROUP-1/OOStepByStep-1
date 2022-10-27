namespace OOStepByStep.Person
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public CourseClass CourseClass { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }

        public virtual string Welcome(Person person)
        {
            return $" Welcome {person.Name} join {person.CourseClass.ClassName}.";
        }
    }
}
