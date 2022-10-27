namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNum;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNum) : base(name, age)
        {
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            return classNum == 0
                ? $"My name is {Name}. I am {Age} years old. I am a teacher."
                : $"My name is {Name}. I am {Age} years old. I am a teacher of class {classNum}.";
        }

        public string Introduce(string newComerName)
        {
            return $"My name is {Name}. I am {Age} years old. I am a teacher of class {classNum}. Welcome {newComerName} join class {classNum}";
        }
    }
}