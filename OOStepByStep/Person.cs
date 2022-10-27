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

        public virtual string Print()
        {
            var name = this.name;
            var age = this.age;
            return $"My name is {name}.I am {age} years old.";
        }
    }
}