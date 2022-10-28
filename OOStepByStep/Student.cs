namespace OOStepByStep
{
    using System;
    public class Student : Person
    {
        private string name;
        private int age;
        private int classNum;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNum) : base(name, age)
        {
            this.name = name;
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            return classNum != 0 ? $"{base.Introduce()} I am a student of class {classNum}." :
                $"{base.Introduce()} I am a student.";
        }

        public string WelcomeNewStudent(Student newStudent)
        {
            return $"{this.Introduce()} Welcome {newStudent.Name} join class {classNum}.";
        }

        public string Name => this.name;
    }
}
