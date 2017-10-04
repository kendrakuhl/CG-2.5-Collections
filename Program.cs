using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student() { FirstName = "SpongeBob", LastName = "Squarepants", Grade = 2, GPA = 2 },
                new Student() { FirstName = "Patrick", LastName = "Star", Grade = 2, GPA = 1.5M },
                new Student() { FirstName = "Squidward", LastName = "Tentacles", Grade = 11, GPA = 3.5M },
                new Student() { FirstName = "Sandy", LastName = "Cheeks", Grade = 10, GPA = 4 },
                new Student() { FirstName = "Eugene", LastName = "Krabs", Grade = 12, GPA = 2.5M },
                new Student() { FirstName = "Gary", LastName = "Snail", Grade = 1, GPA = 1.75M },
                new Student() { FirstName = "Pearl", LastName = "Krabs", Grade = 10, GPA = 3.1M },
                new Student() { FirstName = "Sheldon", LastName = "Plankton", Grade = 11, GPA = 3.6M },
                new Student() { FirstName = "Mrs.", LastName = "Puff", Grade = 12, GPA = 3.2M },
                new Student() { FirstName = "Karen", LastName = "Plankton", Grade = 12, GPA = 4 }
            };

            var filteredStudents = students.Where(s => s.GPA >= 3 && s.Grade >= 9)
                .OrderByDescending(s => s.Grade).ThenByDescending(s => s.GPA)
                .ThenByDescending(s => s.LastName).ThenByDescending(s => s.FirstName).ToList();


            Console.WriteLine("{0,20}{1,20}{2,20}{3,20}",
                "First Name", "Last Name", "Grade", "GPA");

            foreach (var student in filteredStudents)
            {
                Console.WriteLine("{0,20}{1,20}{2,20}{3,20}", 
                    student.FirstName,
                    student.LastName,
                    student.Grade,
                    student.GPA);
            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public decimal GPA { get; set; }
    }
}
