using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace PersonInfo.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestCalculateAverageAge()
        {
            Person[] persons = new Person[]
            {
                new Person { Name = "John", Surname = "Doe", Age = 25 },
                new Person { Name = "Alice", Surname = "Smith", Age = 30 },
                new Person { Name = "Bob", Surname = "Johnson", Age = 22 },
                new Person { Name = "Emma", Surname = "Brown", Age = 35 }
            };

            double averageAge = persons.CalculateAverageAge();

            Assert.AreEqual(28.0, averageAge);
        }

        [TestMethod]
        public void TestMinAndMaxAges()
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

            Assert.AreEqual("Bob", minAgePerson.Name);
            Assert.AreEqual("Emma", maxAgePerson.Name);
        }
    }
}