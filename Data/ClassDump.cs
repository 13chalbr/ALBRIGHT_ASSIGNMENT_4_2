using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_4_2.Data
{
    public class Teacher
    {
        
        public string UserID = "Teacher";

        private string _password = "Admin";

        public bool VerifyPassword(string pass)
        {
            return (String.Compare(pass, _password) == 0);
        }

    }

    public class Student : IComparable<Student>
    {
        public int StudentID { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double StudentGPA { get; set; }


        // Constructor to initialize the properties of a new Student
        public Student(int studentID, string firstName, string lastName, double studentGPA)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            StudentGPA = studentGPA;
        }

        // Default constructor 
        public Student()
        {
            StudentID = 0;
            FirstName = String.Empty;
            LastName = String.Empty;
            StudentGPA = 0.00;
        }

        // Compare Student objects based on their LastName and FirstName properties
        public int CompareTo(Student other)
        {
            // Concatenate the LastName and FirstName of this student
            string thisStudentsFullName = LastName + FirstName;

            // Concatenate the LastName and FirstName of the "other" student
            string otherStudentsFullName = other.LastName + other.FirstName;

            // Use String.Compare to compare the concatenated names and return the result
            return (String.Compare(thisStudentsFullName, otherStudentsFullName));
        }
    }


}
