namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string title;

        public Teacher()
        {
        }

        public Teacher(string name, int age) : base(name, age)
        {
            this.title = "teacher";
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