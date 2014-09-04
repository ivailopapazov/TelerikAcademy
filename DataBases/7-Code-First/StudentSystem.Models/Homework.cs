using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Homework
    {
        private ICollection<Student> students;

        public Homework()
        {
            this.students = new HashSet<Student>();
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        
    }
}
