using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentModel
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    class Student : ICloneable
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }
        public string Address { get; private set; }
        public string MobilePhone { get; private set; }
        public int Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }

        /// <summary>
        /// Initializes new instance of Student class.
        /// </summary>
        public Student(string firstName, string middleName, string lastName, string ssn, string address, string mobilePhone, int course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public static bool operator ==(Student first, Student second)  
        {
            // Returns true if two students are equal
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            // Returns the opposite of the equals operator
            return !(first == second);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current student.
        /// </summary>
        /// <param name="obj">The object to compare to the current student.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // Check if object is null
            if (obj == null)
            {
                return false;
            }

            // Cast object to student
            Student student = obj as Student;

            // Check if object is not Student derived 
            if (student == null)
            {
                return false;
            }

            // Return true if students are equal. University and SSN uniquely identifies a student.
            return this.SSN == student.SSN && this.University == student.University;
        }

        /// <summary>
        /// Return a hashcode of the current student.
        /// </summary>
        public override int GetHashCode()
        {
            return this.University.GetHashCode() ^ this.SSN.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current student.
        /// </summary>
        /// <returns>Student string representation.</returns>
        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            // Append student info
            studentInfo.AppendLine(string.Format("Name - {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            studentInfo.AppendLine(string.Format("Student number - {0}", this.SSN));
            studentInfo.AppendLine(string.Format("Address - {0}", this.Address));
            studentInfo.AppendLine(string.Format("Phone - {0}", this.MobilePhone));
            studentInfo.AppendLine(string.Format("Course - {0}", this.Course));
            studentInfo.AppendLine(string.Format("Specialty - {0}", this.Specialty));
            studentInfo.AppendLine(string.Format("University - {0}", this.University));
            studentInfo.AppendLine(string.Format("Faculty - {0}", this.Faculty));

            // Return student info as a string
            return studentInfo.ToString();
        }

        public object Clone()
        {
            //Type asd = this.GetType();
            //MemberInfo[] members = asd.GetDefaultMembers();
            //foreach (var member in members)
            //{
            //    member.
            //}
            throw new NotImplementedException();
        }
    }
}
