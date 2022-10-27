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

        public string Join(Teacher teacher)
        {
            teacher.ClassBelong = classname;
            return teacher.Introduce();
        }
    }
}