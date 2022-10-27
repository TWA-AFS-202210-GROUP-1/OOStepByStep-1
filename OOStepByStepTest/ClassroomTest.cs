using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class ClassroomTest
  {
    [Fact]
    public void Should_return_welcome_message_when_add_new_student_given_class_with_teacher_and_students()
    {
      // given
      var class2 = new Classroom(2);
      var teacher = new Teacher("Amy", 30, class2);
      var oldStudent = new Student("Tom", 18, class2);
      var newStudent = new Student("Jim", 19, class2);

      // when
      class2.AddTeacher(teacher);
      class2.AddStudent(oldStudent);
      string welcomeMessage = class2.AddStudent(newStudent);

      // then
      Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2. My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.", welcomeMessage);
    }
  }
}
