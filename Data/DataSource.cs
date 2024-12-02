using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_4_2.Data
{
    internal class DataSource
    {
        public static List<Student> Students;

        public static List<Student> CreateData()
        {
            Students = new List<Student>()
            {
                new Student() { StudentID = 1, FirstName = "Kevin", LastName = "Liu", StudentGPA = 3.89},
                new Student() { StudentID = 2, FirstName = "Martin", LastName = "Weber", StudentGPA = 4.00 },
                new Student() { StudentID = 3, FirstName = "George", LastName = "Li", StudentGPA = 2.15},
                new Student() { StudentID = 4, FirstName = "Lisa", LastName = "Miller", StudentGPA = 3.20 },
                new Student() { StudentID = 5, FirstName = "Run", LastName = "Liu", StudentGPA = 1.84 },
        };
            return Students;

        }
    }
}
