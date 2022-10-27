using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTest
    {
        [Fact]
        public void Should_introduce_student_with_name_and_age_when_introduce_give_student_with_name_age()
        {
            // given
            var student = new Student("Tom", 18);

            // when
            var result = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", result);
        }
    }
}