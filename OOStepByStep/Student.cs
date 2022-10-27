namespace OOStepByStep
{
    public class Student : Person
    {
        private string title;

        public Student()
        {
        }

        public Student(string name, int age) : base(name, age)
        {
            this.title = "student";
        }

        public override string Print()
        {
            var name = this.Name;
            var age = this.Age;
            var title = this.title;
            return $"My name is {name}.I am {age} years old.I am a {title}.";
        }
    }
}