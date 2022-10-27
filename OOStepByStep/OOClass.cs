namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;

    public class OOClass
    {
        private string teacher;
        private string name;
        private List<string> students;

        public OOClass(string teacher, string name, List<string> students)
        {
            this.name = name;
            this.teacher = teacher;
            this.students = students;
        }

        public OOClass()
        {
        }

        public string Print()
        {
           return null;
        }
    }
}
