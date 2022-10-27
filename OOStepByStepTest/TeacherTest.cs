using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class TeacherTest
  {
    [Fact]
    public void Should_print_introduction_when_introduce_given_teacher_Amy_30()
    {
      // given
      var teacher = new Teacher("Amy", 30);

      // when
      string introduction = teacher.Introduce();

      // then
      Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduction);
    }
  }
}
