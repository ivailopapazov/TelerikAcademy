using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        private ICollection<Course> courses;

        public Student()
        {
            this.courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        
        public string name { get; set; }
        
        public int Number { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
        
    }
}
