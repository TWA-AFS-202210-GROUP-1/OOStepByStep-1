namespace OOStepByStep
{
    using System;
    public class Teacher : Person
    {
        private string name;
        private int age;
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
            return classNum == 0 ? $"{base.Introduce()} I am a teacher." :
                $"{base.Introduce()} I am a teacher of class {classNum}.";
        }

        public string WelcomeNewStudent(Student student)
        {
            return $"{this.Introduce()} Welcome {student.Name} join class {classNum}.";
        }
    }
}
