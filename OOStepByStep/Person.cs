namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string ClassBelong { get; internal set; }

        public virtual string Introduce()
        {
                return $"My name is {name}. I am {age} years old.";
        }
    }
}