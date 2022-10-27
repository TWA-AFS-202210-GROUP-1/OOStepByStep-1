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
            return null;
        }
    }
}