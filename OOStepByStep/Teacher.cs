namespace OOStepByStep
{
    using System;
    public class Teacher : Person
    {
        private string name;
        private int age;

        public Teacher(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public override string Introduce()
        {
            return $"My name is {name}. I am {age} years old. I am a teacher.";
        }

        //public void Print()
        //{
        //    Console.WriteLine("console");
        //}
    }
}
