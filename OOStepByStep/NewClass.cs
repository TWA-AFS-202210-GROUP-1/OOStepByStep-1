using System;

namespace OOStepByStep
{
    public class NewClass
    {
        private string classname;

        public NewClass(string classname)
        {
            this.classname = classname;
        }

        public string Join(Person person)
        {
            person.ClassBelong = classname;
            return person.Introduce();
        }
    }
}