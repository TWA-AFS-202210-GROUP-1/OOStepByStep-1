using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_introduce_with_name_and_age_when_introduce_give_person_with_name_age()
        {
            // given
            var person = new Person("Tom", 21);

            // when
            var result = person.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }
}
