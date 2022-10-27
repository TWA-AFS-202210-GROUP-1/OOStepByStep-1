using System.Collections.Generic;

namespace OOStepByStep
{
    public class ClassWelcome
    {
        public string TeacherWelcome { get; set; }
        public IList<string> StudentsWelcome { get; set; }

        public ClassWelcome()
        {
            TeacherWelcome = string.Empty;
            StudentsWelcome = new List<string>();
        }
    }
}
