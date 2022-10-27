using System.IO;
using System.Text;
using OOStepByStep.Person;

namespace OOStepByStepTest.PersonTest
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

        [Fact]
        public void Should_introduce_teacher_with_name_and_age_when_introduce_give_teacher_with_name_age()
        {
            // given
            var teacher = new Teacher("Amy", 30);

            // when
            var result = teacher.Introduce();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }
    }
}
