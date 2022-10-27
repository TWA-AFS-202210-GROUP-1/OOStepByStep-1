namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_information_when_introduce_give_name_and_age()
        {
            //give
            Person person = new Person("Tom", 18, "student");
            //when
            string info = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student", info);
        }
    }
}
