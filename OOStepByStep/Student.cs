using System.Runtime.InteropServices;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNum;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNum) : base(name, age)
        {
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            return classNum == 0
                ? $"My name is {Name}. I am {Age} years old. I am a student."
                : $"My name is {Name}. I am {Age} years old. I am a student of class {classNum}.";
        }

        public string Introduce(string newComerName)
        {
            return $"My name is {Name}. I am {Age} years old. I am a student of class {classNum}. Welcome {newComerName} join class {classNum}";
        }
    }
}