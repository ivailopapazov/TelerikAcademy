using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStudentSelection
{
    /// <summary>
    /// Represents student object.
    /// </summary>
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; set; }
        public int Group { get; set; }
        public List<int> Marks { get; set; }

        /// <summary>
        /// Initializes new instance of student class.
        /// </summary>
        public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber, List<int> marks, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
            this.Group = group;
        }

    }
}
