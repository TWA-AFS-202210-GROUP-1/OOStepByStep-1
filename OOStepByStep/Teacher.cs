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
            this.name = name;
            this.age = age;
        }

        public Teacher(string name, int age, int classNum) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            if (classNum == 0)
            {
                return $"My name is {name}. I am {age} years old. I am a teacher.";
            }
            else
            {
                return $"My name is {name}. I am {age} years old. I am a teacher of class {classNum}.";
            }
        }

        //public void Print()
        //{
        //    Console.WriteLine("console");
        //}
    }
}
