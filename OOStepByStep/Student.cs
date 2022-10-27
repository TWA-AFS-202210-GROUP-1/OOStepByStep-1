using System;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string profession = "student";
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old. I am a {profession} of {ClassBelong}.";
        }
    }
}