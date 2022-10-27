using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string profession = "teacher";
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old. I am a {profession}.";
        }
    }
}
