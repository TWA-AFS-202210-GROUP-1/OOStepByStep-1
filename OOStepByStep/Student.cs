namespace OOStepByStep
{
    using System;
    public class Student : Person
    {
        private string name;
        private int age;

        public Student(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public override string Introduce()
        {
            return $"My name is {name}. I am {age} years old. I am a student.";
        }

        //public void Print()
        //{
        //    Console.WriteLine("console");
        //}
    }
}
