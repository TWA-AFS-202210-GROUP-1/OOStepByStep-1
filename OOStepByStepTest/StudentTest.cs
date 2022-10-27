using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class StudentTest
  {
    [Fact]
    public void Should_print_introduction_when_introduce_given_student_Tom_18_class2()
    {
      // given
      var class2 = new ClassRoom(2);
      var student = new Student("Tom", 18, class2);

      // when
      class2.AddStudent(student);
      var introduction = student.Introduce();

      // then
      Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", introduction);
    }
  }
}
