using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
  public class PersonTest
  {
    [Fact]
    public void Should_print_introduction_when_introduce_given_person_Tom_21()
    {
      // given
      var person = new Person("Tom", 21);

      // when
      string introduction = person.Introduce();

      // then
      Assert.Equal("My name is Tom. I am 21 years old.", introduction);
    }
  }
}
