namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_information_when_introduce_given_name_and_age()
        {
            //given
            Person person = new Person("Tom", 18);
            //when
            string info = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old.", info);
        }
    }
}
