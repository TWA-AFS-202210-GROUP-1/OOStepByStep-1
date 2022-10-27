using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class ClassroomTest
  {
    [Fact]
    public void Should_return_welcome_message_when_add_new_student_given_class2_with_teacher_and_1_student()
    {
      // given
      var classroom = new Classroom(2);
      var teacher = new Teacher("Amy", 30);
      var oldStudent = new Student("Tom", 18);
      var newStudent = new Student("Jim", 19);

      // when
      teacher.JoinClass(classroom);
      oldStudent.JoinClass(classroom);
      newStudent.JoinClass(classroom);
      string welcomeMessage = classroom.ShowWelcome(newStudent);

      // then
      Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2. My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.", welcomeMessage);
    }

    [Fact]
    public void Should_return_welcome_message_when_add_new_student_given_class3_with_teacher_and_no_student()
    {
      // given
      var classroom = new Classroom(3);
      var teacher = new Teacher("David", 32);
      var newStudent = new Student("Jim", 19);

      // when
      teacher.JoinClass(classroom);
      newStudent.JoinClass(classroom);
      string welcomeMessage = classroom.ShowWelcome(newStudent);

      // then
      Assert.Equal("My name is David. I am 32 years old. I am a teacher of class 3. Welcome Jim join class 3.", welcomeMessage);
    }

    [Fact]
    public void Should_return_welcome_message_when_add_new_student_given_class1_with_teacher_and_2_students()
    {
      // given
      var classroom = new Classroom(1);
      var teacher = new Teacher("David", 32);
      var studentJim = new Student("Jim", 19);
      var studentTom = new Student("Tom", 18);
      var newStudent = new Student("Paul", 20);

      // when
      teacher.JoinClass(classroom);
      studentJim.JoinClass(classroom);
      studentTom.JoinClass(classroom);
      newStudent.JoinClass(classroom);
      string welcomeMessage = classroom.ShowWelcome(newStudent);

      // then
      Assert.Equal("My name is David. I am 32 years old. I am a teacher of class 1. Welcome Paul join class 1. My name is Jim. I am 19 years old. I am a student of class 1. Welcome Paul join class 1. My name is Tom. I am 18 years old. I am a student of class 1. Welcome Paul join class 1.", welcomeMessage);
    }

    [Fact]
    public void Should_return_empty_message_when_show_welcome_given_empty_class()
    {
      // given
      var classroom = new Classroom(4);
      var newStudent = new Student("Paul", 20);

      // when
      newStudent.JoinClass(classroom);
      string welcomeMessage = classroom.ShowWelcome(newStudent);

      // then
      Assert.Equal(string.Empty, welcomeMessage);
    }
  }
}
