namespace OOStepByStep;

public class CourseClass
{
    public string ClassName { get; }
    private Teacher classTeacher;

    public CourseClass(string className)
    {
        ClassName = className;
    }

    public bool AddTeacher(Teacher teacher)
    {
        classTeacher = teacher;
        teacher.CourseClass = this;
        return true;
    }
}