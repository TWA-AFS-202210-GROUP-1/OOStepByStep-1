namespace OOStepByStep
{
    public class Student : Person
    {
        private string title;
        private int classname;

        public Student()
        {
        }

        public Student(string name, int age) : base(name, age)
        {
            this.title = "student";
        }

        public int Classname
        {
            get
            {
                return classname;
            }

            set
            {
                classname = value;
            }
        }

        public override string Print()
        {
            var name = this.Name;
            var age = this.Age;
            var title = this.title;
            if (this.classname > 0)
            {
                var classname = this.classname;
                return $"My name is {name}.I am {age} years old.I am a {title} of class {classname}.";
            }

            return $"My name is {name}.I am {age} years old.I am a {title}.";
        }
    }
}