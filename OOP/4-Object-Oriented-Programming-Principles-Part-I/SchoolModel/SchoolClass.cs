using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolModel
{
    /// <summary>
    /// Represent a class in the school.
    /// </summary>
    public class SchoolClass : SchoolObject
    {
        /// <summary>
        /// Initializes new instance of SchoolClass class to the specified unique text identifier.
        /// </summary>
        /// <param name="classID">Class unique text identifier.</param>
        public SchoolClass(string classID) : this(classID, null)
        {
        }

        /// <summary>
        /// Initializes new instance of SchoolClass class to teh specified unique text identifier and set of teachers.
        /// </summary>
        /// <param name="classID">Class unique text identifier.</param>
        /// <param name="teachers">Set of teachers.</param>
        public SchoolClass(string classID, IEnumerable<Teacher> teachers)
        {
            this.ClassID = classID;
            this.Teachers = teachers.ToList();
        }

        /// <summary>
        /// Gets the list of teachers.
        /// </summary>
        public List<Teacher> Teachers { get; private set; }

        /// <summary>
        ///  Gets the Class text identifier.
        /// </summary>
        public string ClassID { get; private set; }

        /// <summary>
        /// Adds a teacher to the set of teachers.
        /// </summary>
        /// <param name="teacher"></param>
        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
    }
}
