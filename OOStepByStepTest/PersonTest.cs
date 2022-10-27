using System;
using System.IO;
using System.Text;
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
      var fakeOutput = new StringBuilder();
      Console.SetOut(new StringWriter(fakeOutput));

      // when
      var person = new Person("Tom", 21);
      person.Introduce();

      // then
      Assert.Equal("My name is Tom. I am 21 years old\r\n", fakeOutput.ToString());
    }
  }
}
