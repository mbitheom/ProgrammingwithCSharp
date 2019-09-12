using System;

namespace AdvancedCsharpProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Person_One("Humphry");
            

        }
       

    }
    public class Person
    {
        public string Name = "Johnson";
        public void WriteName(string name)
        {
            Console.WriteLine("Hi " + Name + " I am " + name);
        }
        static public Person Person_One(string name)
        {
            var person = new Person();
            person.Name = name;

            return person;
        }
    }
}
