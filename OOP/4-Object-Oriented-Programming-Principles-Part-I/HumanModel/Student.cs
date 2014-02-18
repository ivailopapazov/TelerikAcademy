using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanModel
{
    /// <summary>
    /// Represents a student object.
    /// </summary>
    class Student : Human
    {
        private int grade;

        public int Grade 
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value > 12 || value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid grade.");
                }

                this.grade = value;
            }
        }

        /// <summary>
        /// Initializes new instance of student class to a sepcified firstname, lastname and grade.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="grade"></param>
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
