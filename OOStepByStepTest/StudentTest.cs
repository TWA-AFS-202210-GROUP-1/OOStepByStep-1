using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class StudentTest
  {
    [Fact]
    public void Should_print_introduction_when_introduce_given_student_Tom_18()
    {
      // given
      var student = new Student("Tom", 18);

      // when
      string introduction = student.Introduce();

      // then
      Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduction);
    }
  }
}
