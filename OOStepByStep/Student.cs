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
            this.name = name;
            this.age = age;
        }

        public Student(string name, int age, int classNum) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            if (classNum == 0)
            {
                return $"My name is {name}. I am {age} years old. I am a student.";
            }
            else
            {
                return $"My name is {name}. I am {age} years old. I am a student of class {classNum}.";
            }
        }

        public string WelcomeNewStudent(Student newStudent)
        {
            return $"My name is {name}. I am {age} years old. I am a student of class {classNum}. " +
                   $"Welcome {newStudent.Name} join class {classNum}.";
        }

        public string Name => this.name;

        //public void Print()
        //{
        //    Console.WriteLine("console");
        //}
    }
}
