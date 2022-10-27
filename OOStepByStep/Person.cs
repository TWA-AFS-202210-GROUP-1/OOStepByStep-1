using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        protected string MyInformation { get; set; } = string.Empty;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return $"My name is {name}. I am {age} years old.{MyInformation}";
        }
    }
}
