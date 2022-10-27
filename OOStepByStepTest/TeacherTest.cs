using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class TeacherTest
  {
    [Fact]
    public void Should_return_introduction_when_introduce_given_teacher_Amy_30()
    {
      // given
      var class2 = new Classroom(2);
      var teacher = new Teacher("Amy", 30, class2);

      // when
      string introduction = teacher.Introduce();

      // then
      Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", introduction);
    }
  }
}
