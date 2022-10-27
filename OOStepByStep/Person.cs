using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            var roleInformation = string.Empty;
            if (this is Teacher || this is Student)
            {
                roleInformation = $" I am a {GetType().Name.ToLower()}.";
            }

            return $"My name is {name}. I am {age} years old.{roleInformation}";
        }
    }
}
