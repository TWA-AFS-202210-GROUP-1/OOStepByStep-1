namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        private string occupation;

        public Person(string name, int age, string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        public string Introduce()
        {
            return $"My name is {name}. I am {age} years old. I am a {occupation}.";
        }
    }
}