﻿namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old. I am a student.";
        }
    }
}