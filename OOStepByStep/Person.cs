using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        public CourseClass CourseClass { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            var introduceSuffix = string.Empty;
            if (IsTeacherOrStudent())
            {
                var role = GetType().Name.ToLower();
                introduceSuffix = $" I am a {role}.";

                if (CourseClass != null)
                {
                    introduceSuffix = $" I am a {role} of {CourseClass.ClassName}.";
                }
            }

            return $"My name is {name}. I am {age} years old." + introduceSuffix;
        }

        private bool IsTeacherOrStudent()
        {
            return this is Teacher || this is Student;
        }
    }
}
