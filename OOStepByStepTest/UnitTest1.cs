namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_get_name_and_age_when_is_a_person_if_given_name_and_age()
        {
            var person = new Person();
            var res = person.Print();
            Assert.Equal("My name is Tom.I am 21 years old.", res);
        }
    }
}
