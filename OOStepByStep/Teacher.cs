namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string title;
        private int classname;

        public Teacher()
        {
        }

        public Teacher(string name, int age) : base(name, age)
        {
            this.title = "teacher";
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