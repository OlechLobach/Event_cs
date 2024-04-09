using System;
using System.Linq;

namespace PersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person { Name = "John", Surname = "Doe", Age = 25 },
                new Person { Name = "Alice", Surname = "Smith", Age = 30 },
                new Person { Name = "Bob", Surname = "Johnson", Age = 22 },
                new Person { Name = "Emma", Surname = "Brown", Age = 35 }
            };

            var minAgePerson = persons.OrderBy(p => p.Age).First();
            var maxAgePerson = persons.OrderByDescending(p => p.Age).First();

            Console.WriteLine($"Person with minimum age: {minAgePerson.Name} {minAgePerson.Surname}, Age: {minAgePerson.Age}");
            Console.WriteLine($"Person with maximum age: {maxAgePerson.Name} {maxAgePerson.Surname}, Age: {maxAgePerson.Age}");

            double averageAge = persons.Average(p => p.Age);
            Console.WriteLine($"Average age: {averageAge}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    public static class PersonExtensions
    {
        public static double CalculateAverageAge(this Person[] persons)
        {
            return persons.Average(p => p.Age);
        }
    }
}