using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudents
{
    /// <summary>
    /// Represents student object
    /// </summary>
    public struct Student
    {
        public string Name { get; private set; }
        public string Group { get; private set; }

        /// <summary>
        /// Initializes new instance of student struct to a specified name and group.
        /// </summary>
        /// <param name="name">Name of the student.</param>
        /// <param name="group">Groupname student belongs.</param>
        public Student(string name, string group) : this()
        {
            this.Name = name;
            this.Group = group;
        }
    }
}
