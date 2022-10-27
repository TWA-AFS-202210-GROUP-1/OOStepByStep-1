using System;

namespace OOStepByStep
{
  public class Person
  {
    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
      Console.WriteLine($"My name is {this.Name}. I am {this.Age} years old");
    }
  }
}
