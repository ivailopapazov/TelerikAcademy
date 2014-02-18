using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SchoolModel
{
    public class SchoolClass : SchoolObject
    {
        public SchoolClass(string classID) : this(classID, null)
        {
        }

        public SchoolClass(string classID, IEnumerable<Teacher> teachers)
        {
            this.ClassID = classID;
            this.Teachers = teachers.ToList();
        }

        public List<Teacher> Teachers { get; private set; }
        public string ClassID { get; private set; }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
    }
}
