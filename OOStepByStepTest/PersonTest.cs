namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_message_when_given_name_and_age()
        {
            // given
            Person person = new Person("Tom", 21);
            // when
            string message = person.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old.", message);
        }
    }
}
