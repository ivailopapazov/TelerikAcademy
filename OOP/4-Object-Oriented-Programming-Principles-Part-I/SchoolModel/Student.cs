using System;
using System.Linq;

namespace SchoolModel
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Initializes new instance of student class to the specified name and class number.
        /// </summary>
        /// <param name="name">Name of the student.</param>
        /// <param name="classNumber">Student's class number.</param>
        public Student(string name, string classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        /// <summary>
        /// Gets class number of the student.
        /// </summary>
        public string ClassNumber { get; private set; }
    }
}
