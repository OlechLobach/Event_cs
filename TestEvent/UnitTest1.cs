using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentGrades;
using System.Linq;
using TemperatureAnalyzer;

namespace TemperatureAnalyzer.Test
{
    [TestClass]
    public class StudentGradeTests
    {
        [TestMethod]
        public void CalculateAverageGrade_ValidInput_ReturnsCorrectResult()
        {
            var studentGrades = new[]
            {
                new StudentGrade { Name = "Alice", Grades = new int[] { 80, 85, 90 } },
                new StudentGrade { Name = "Bob", Grades = new int[] { 75, 80, 85 } },
                new StudentGrade { Name = "Charlie", Grades = new int[] { 70, 75, 80 } }
            };

            var averageGrades = studentGrades.Select(s => s.Grades.Average()).ToArray();

            CollectionAssert.AreEqual(new[] { 85.0, 80.0, 75.0 }, averageGrades);
        }

        [TestMethod]
        public void CalculateMaximumGrade_ValidInput_ReturnsCorrectResult()
        {
            var studentGrades = new[]
            {
                new StudentGrade { Name = "Alice", Grades = new int[] { 80, 85, 90 } },
                new StudentGrade { Name = "Bob", Grades = new int[] { 75, 80, 85 } },
                new StudentGrade { Name = "Charlie", Grades = new int[] { 70, 75, 80 } }
            };

            var maximumGrades = studentGrades.Select(s => s.Grades.Max()).ToArray();

            CollectionAssert.AreEqual(new[] { 90, 85, 80 }, maximumGrades);
        }
    }
}