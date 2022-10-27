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
            this.title = "Student";
        }

        public override string Print()
        {
            return null;
        }
    }
}