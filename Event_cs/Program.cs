using System;
using System.Linq;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentGrade[] studentGrades = new StudentGrade[]
            {
                new StudentGrade { Name = "Alice", Grades = new int[] { 85, 90, 95, 88 } },
                new StudentGrade { Name = "Bob", Grades = new int[] { 78, 82, 85, 80 } },
                new StudentGrade { Name = "Charlie", Grades = new int[] { 92, 88, 95, 90 } }
            };

            var maxGradeStudent = studentGrades.OrderByDescending(s => s.Grades.Max()).First();
            Console.WriteLine($"Student with maximum grade is {maxGradeStudent.Name} with grade {maxGradeStudent.Grades.Max()}");

            var averageGradeStudent = studentGrades.OrderByDescending(s => s.Grades.Average()).First();
            Console.WriteLine($"Student with average grade is {averageGradeStudent.Name} with grade {averageGradeStudent.Grades.Average()}");

            Console.ReadKey();
        }
    }

    public class StudentGrade
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }
    }
}