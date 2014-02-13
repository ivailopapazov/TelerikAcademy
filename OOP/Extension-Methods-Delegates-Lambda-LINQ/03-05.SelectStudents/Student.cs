using System;

namespace SelectStudents
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    public struct Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Initializes new instance of student struct to a specified first name, last name and age.
        /// </summary>
        /// <param name="firstName">First name of the student.</param>
        /// <param name="lastName">Last name of the student.</param>
        /// <param name="age">Age of the student.</param>
        public Student(string firstName, string lastName, int age) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
